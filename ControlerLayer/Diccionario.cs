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
                _instance.llenarDiccionarioEspectaculos();
                _instance.llenarDiccionarioCompras();
            }
            return _instance;
        }

        private static Dictionary<long, List<LocalidadAsiento>> _asientosCache = new Dictionary<long, List<LocalidadAsiento>>();
        private static Dictionary<DateTime, List<Compra>> _compraByFechaCache = new Dictionary<DateTime, List<Compra>>();

        public static Dictionary<DateTime, List<Compra>> CompraByFechaCache { get => _compraByFechaCache; set => _compraByFechaCache = value; }

        public void llenarDiccionarioCompras()
        {
            // Obtener todas las compras de la base de datos
            List<Compra> compras = new CompraController().GetCompras();

            // Agrupar las compras por diferencia de minutos
            Dictionary<DateTime, List<Compra>> comprasPorMinuto = new Dictionary<DateTime, List<Compra>>();
            foreach (Compra compra in compras)
            {
                DateTime fechaCompra = compra.FechaHora;

                // Redondear la fecha y hora al minuto más cercano
                DateTime fechaCompraRedondeada = fechaCompra.AddMilliseconds(-fechaCompra.Millisecond);
                fechaCompraRedondeada = fechaCompraRedondeada.AddSeconds(-fechaCompraRedondeada.Second);


                if (comprasPorMinuto.ContainsKey(fechaCompraRedondeada))
                {
                    // Agregar la compra a la lista existente para este minuto
                    if(compra.EstadoCompra)
                    comprasPorMinuto[fechaCompraRedondeada].Add(compra);
                }
                else
                {
                    // Crear una nueva lista de compras para este minuto
                    if (compra.EstadoCompra)
                    {
                        List<Compra> comprasDeEsteMinuto = new List<Compra>();
                        comprasDeEsteMinuto.Add(compra);
                        comprasPorMinuto.Add(fechaCompraRedondeada, comprasDeEsteMinuto);
                    }    
          
                }
            }

            // Guardar el diccionario de compras por minuto en el diccionario de asientos por compras          
            _compraByFechaCache = comprasPorMinuto;
        }
        public LocalidadEspectaculo ConvertirCompraEnLocalidadAsiento(Compra compra)
        {
            LocalidadEspectaculo localidadEspectaculo = new LocalidadEspectaculo();
            localidadEspectaculo = new LocalidadEspectaculoController().getLocalidadEspectaculoByCompra(compra);
            return localidadEspectaculo;
        }
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
        public void actualizarDiccionario(List<Compra> asientosComprados, DateTime fechaComprado)
        {            
            if (!_compraByFechaCache.ContainsKey(fechaComprado))
            {
                _compraByFechaCache.Add(fechaComprado, asientosComprados);
            }
        }

        public void llenarDiccionarioEspectaculos()
        {
            List<Espectaculo> espectaculos = new EspectaculoController().GetEspectaculos();
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
                    where le.Espectaculoid == espectaculoId && c.EstadoCompra == true
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
