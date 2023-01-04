using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.DataLayer;

namespace ProyectoFinal.ControlerLayer
{
    public class AgregarEspectaculo
    {
        public bool agregarEspectaculo(Espectaculo espectaculo)
        {
            bool resultado = false;
            using(TeatroEntities db = new TeatroEntities())
            {
                db.Espectaculo.Add(espectaculo);
                if (db.SaveChanges() == 1)
                {
                    resultado = true;
                }
            }
            return resultado;
        }
        
    }
}
