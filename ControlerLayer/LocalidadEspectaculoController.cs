using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ControlerLayer
{
    public class LocalidadEspectaculoController
    {
        public long crearLocalidadEspectaculo(LocalidadEspectaculo localidadEspectaculo)
        {
            long resultado = 0;
            using (TeatroEntities db = new TeatroEntities())
            {
                db.LocalidadEspectaculo.Add(localidadEspectaculo);
                if (db.SaveChanges() == 1)
                {
                    resultado = localidadEspectaculo.Id;
                    return resultado;
                }
            }
            return resultado;
        }

        public LocalidadEspectaculo GetLocalidadEspectaculoById(long id)
        {
            List<LocalidadEspectaculo> localidadEspectaculos = new List<LocalidadEspectaculo>();

            using (TeatroEntities db = new TeatroEntities()) localidadEspectaculos = db.LocalidadEspectaculo.ToList();

            foreach (var item in localidadEspectaculos) if (id == item.Id) return item;

            return null;
        }

        public LocalidadEspectaculo getLocalidadEspectaculoByCompra(Compra compra)
        {
            LocalidadEspectaculo localidadEspectaculo;
            using (TeatroEntities db = new TeatroEntities())
            {
                localidadEspectaculo = db.Compra
                .Where(c => c.Id == compra.Id) // filtramos por el Id de la compra
                .Select(c => c.LocalidadEspectaculo) // seleccionamos la localidad de asiento de la compra
                .FirstOrDefault();
            }


            return localidadEspectaculo;
        }
    }
}
