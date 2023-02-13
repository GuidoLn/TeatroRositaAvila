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
        public bool realizarCompra(Compra compra)
        {
            bool resultado = false;
            resultado = new Compra().realizarCompra(compra);            
            return resultado;
        }
        public long crearLocalidadEspectaculo(LocalidadEspectaculo localidadEspectaculo)
        {
            long resultado = 0;
            resultado = new LocalidadEspectaculo().crearLocalidadEspectaculo(localidadEspectaculo);
            return resultado;
        }
    }
}
