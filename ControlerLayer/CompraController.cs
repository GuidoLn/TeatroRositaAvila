using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.DataLayer;

namespace ProyectoFinal.ControlerLayer
{
    public class CompraController
    {
        public long crearLocalidadEspectaculo(LocalidadEspectaculo localidadEspectaculo)
        {
            long resultado = 0;
            resultado = new LocalidadEspectaculo().crearLocalidadEspectaculo(localidadEspectaculo);
            return resultado;
        }

        public List<Compra> GetComprasByEspectaculo(long espectaculoId)
        {
            List<Compra> compras = new List<Compra>();

            using (TeatroEntities db = new TeatroEntities())
            {
                compras = db.Compra
                    .Where(le => le.Espectaculoid == espectaculoId)
                    .ToList();
            }

            return compras;
        }

        public List<Compra> GetCompras()
        {
            List<Compra> compras = new List<Compra>();

            using (TeatroEntities db = new TeatroEntities()) compras = db.Compra.ToList();

            return compras;
        }

        public bool realizarCompra(Compra compra)
        {
            bool resultado = false;
            using (TeatroEntities db = new TeatroEntities())
            {
                db.Compra.Add(compra);
                if (db.SaveChanges() == 1)
                {
                    resultado = true;
                }
            }
            return resultado;
        }
    }
}
