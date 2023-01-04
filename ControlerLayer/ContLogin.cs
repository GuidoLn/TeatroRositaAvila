using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.DataLayer;

namespace ProyectoFinal.ControlerLayer
{
    public class ContLogin
    {
        public string verificarCuenta(string usuario, string clave)
        {
            string resultado = string.Empty;
            resultado = new Cuenta().verificarCuenta(usuario, clave);            
            return resultado;
        }
    }
}
