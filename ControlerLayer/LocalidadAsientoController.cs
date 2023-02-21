using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ControlerLayer
{
    public class LocalidadAsientoController
    {
        public List<LocalidadAsiento> GetAsientos()
        {
            List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();

            using (TeatroEntities db = new TeatroEntities()) asientos = db.LocalidadAsiento.ToList();

            return asientos;
        }

        public List<LocalidadAsiento> GetAsientosBySectorAndEspectaculo(long sectorId, long espectaculoId)
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
                    where a.Sectorid == sectorId
                    select new LocalidadAsiento()
                    {
                        Id = a.Id,
                        NumeroAsiento = a.NumeroAsiento,
                        Sectorid = a.Sectorid,
                        EstadoAsiento = !compras.ContainsKey(a.Id)
                    }).ToList();

                return asientos;
            }
        }

        public LocalidadAsiento GetlocalidadAsientoByAsiento(int asiento)
        {
            LocalidadAsiento localidad = new LocalidadAsiento();
            List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();
            using (TeatroEntities db = new TeatroEntities())
            {
                asientos = db.LocalidadAsiento.ToList();
            }
            foreach (var item in asientos)
            {
                if (asiento == item.NumeroAsiento)
                {
                    localidad = item;
                }
            }

            return localidad;
        }

        public float calcularPrecio(List<string> asientos, long espectaculoID)
        {
            float precioFinal = 0;
            float precioByEspectaculo = float.Parse(GetEspectaculoById(espectaculoID).PrecioEspectaculo.ToString());
            float precioBySector;
            foreach (var item in asientos)
            {
                precioBySector = float.Parse(GetSectorByAsiento(item).PrecioSector.ToString());
                precioFinal = precioFinal + (precioByEspectaculo * precioBySector);

            }
            return precioFinal;
        }


    }
}
