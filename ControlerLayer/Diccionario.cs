using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ControlerLayer
{
    public class Diccionario
    {
        private static Diccionario _instance;


        public static Diccionario GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Diccionario();
                _instance.llenarDiccionario();
            }
            return _instance;
        }

        private static Dictionary<long, List<LocalidadAsiento>> _asientosCache = new Dictionary<long, List<LocalidadAsiento>>();

        //public void actualizarDiccionario(List<string> asientosComprados, long espectaculoId)
        //{
        //    List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();
        //    if (_asientosCache.ContainsKey(espectaculoId))
        //    {
        //        asientos = _asientosCache[espectaculoId].ToList();
        //        // Iterar por los asientos comprados
        //        foreach (string asiento in asientosComprados)
        //        {
        //            // Verificar que el asiento esté en el diccionario

        //            if (asientos[])
        //            {
        //                // Actualizar el estado del asiento a "false"
        //                _asientosCache[espectaculoId][asiento] = false;
        //            }
        //        }
        //    }
        //}
        public List<string> getAsientosDisponibles(long espectaculoId)
        {
            var list = new List<string>();
            List<LocalidadAsiento> asientosEspectaculo = new List<LocalidadAsiento>();
            if (_asientosCache.ContainsKey(espectaculoId))
            {
                asientosEspectaculo = _asientosCache[espectaculoId].ToList();                
                foreach (var asiento in asientosEspectaculo)
                {
                   
                    if (asiento.EstadoAsiento)
                        list.Add(asiento.NumeroAsiento.ToString());                 
                }
                
            }
            return list;
        }
        public void actualizarDiccionario(List<string> asientosComprados, long espectaculoId)
        {
            List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();
            if (_asientosCache.ContainsKey(espectaculoId))
            {
                asientos = _asientosCache[espectaculoId].ToList();
                // Iterar por los asientos comprados
                foreach (string numeroAsiento in asientosComprados)
                {
                    // Buscar el objeto de tipo asiento correspondiente en la lista
                    LocalidadAsiento asiento = asientos.FirstOrDefault(a => a.NumeroAsiento == int.Parse(numeroAsiento));
                    if (asiento != null)
                    {
                        // Actualizar el estado del asiento a "comprado"
                        asiento.EstadoAsiento = false;
                    }
                }
                // Actualizar el diccionario con la lista de asientos actualizada
                _asientosCache[espectaculoId] = asientos;
            }
        }

        public void llenarDiccionario()
        {
            List<Espectaculo> espectaculos = new GetData().GetEspectaculos();
            foreach (var item in espectaculos)
            {
                _asientosCache.Add(item.Id, GetAsientosByEspectaculo(item.Id));
            }
        }
        private List<LocalidadAsiento> GetAsientosByEspectaculo(long espectaculoId)
        {
            using (TeatroEntities db = new TeatroEntities())
            {
                var compras = (
                    from c in db.Compra
                    join le in db.LocalidadEspectaculo on c.LocalidadEspectaculoid equals le.Id
                    where le.Espectaculoid == espectaculoId
                    select new { AsientoId = le.LocalidadAsientoid, Compra = c }
                ).ToDictionary(x => x.AsientoId, x => x.Compra);

                var asientos = (
                    from a in db.LocalidadAsiento
                    select new { a.Id, a.NumeroAsiento, a.Sectorid, a.EstadoAsiento, a.Sector }
                ).ToList();

                var result = new List<LocalidadAsiento>();

                foreach (var asiento in asientos)
                {
                    var estadoAsiento = !compras.ContainsKey(asiento.Id);
                    var localidadAsiento = new LocalidadAsiento
                    {
                        Id = asiento.Id,
                        NumeroAsiento = asiento.NumeroAsiento,
                        Sectorid = asiento.Sectorid,
                        EstadoAsiento = estadoAsiento,
                        Sector = asiento.Sector
                    };


                    result.Add(localidadAsiento);
                }

                return result;
            }
        }
        public List<LocalidadAsiento> GetAsientosDiccionarioByEspectaculo(long espectaculoId)
        {
            List<LocalidadAsiento> asientos = _asientosCache[espectaculoId];
            return asientos;
        }
        public List<LocalidadAsiento> GetAsientosDiccionarioByEspectaculoAndSector(string sectorName, long espectaculoId)
        {
            List<LocalidadAsiento> asientos = _asientosCache[espectaculoId];
            return asientos.Where(a => a.Sector.NombreSector == sectorName).ToList();
        }


    }
}
