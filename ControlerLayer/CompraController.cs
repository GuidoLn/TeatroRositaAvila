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
            resultado = new LocalidadEspectaculoController().crearLocalidadEspectaculo(localidadEspectaculo);
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
        public string convertirCompraEnLocalidadAsiento(List<Compra> comprasFechaActual)
        {
            string asientos = "";
            using (TeatroEntities db = new TeatroEntities())
            {
                foreach (var item in comprasFechaActual)
                {
                    int numeroAsiento = db.LocalidadEspectaculo
                        .Where(x => x.Id == item.LocalidadEspectaculoid)
                        .Select(x => x.LocalidadAsiento.NumeroAsiento)
                        .First(); // Método de proyección para obtener el primer número de asiento

                    asientos += numeroAsiento + ", ";
                }
                // Eliminar la última coma y espacio
                asientos = asientos.TrimEnd(',', ' ');
            }
            return asientos;
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
        public bool eliminarCompras(long idEliminar)
        {
            bool result = false;  
            Dictionary<long, List<Compra>> diccionario = Diccionario.CompraByFechaCache;
            List<Compra> comprasEliminar = diccionario[idEliminar];
            using (TeatroEntities db = new TeatroEntities())
            {
                var idComprasEliminar = comprasEliminar.Select(c => c.Id).ToList();

                // Filtrar las compras de la base de datos que tienen un IdCompra en la lista idComprasEliminar
                var comprasActualizar = db.Compra.Where(c => idComprasEliminar.Contains(c.Id));

                // Actualizar el estado de las compras en la lista comprasActualizar
                comprasActualizar.ToList().ForEach(c => c.EstadoCompra = false);

                if (db.SaveChanges() > 0)
                {
                    Diccionario.GetInstance().actualizarDiccionario(idEliminar);                    
                    result = true;
                }
                
            }
            return result;
        }

    }
}
