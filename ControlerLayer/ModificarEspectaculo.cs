using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ControlerLayer
{
    public class ModificarEspectaculo
    {
        public bool modificarEspectaculo(Espectaculo espectaculo)
        {
            bool resultado = false;
            using (TeatroEntities db = new TeatroEntities())
            {
                db.Entry(espectaculo).State = System.Data.Entity.EntityState.Modified;                
                if (db.SaveChanges() == 1) resultado = true;
            }
            return resultado;
        }
    }
}
