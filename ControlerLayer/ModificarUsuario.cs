using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.DataLayer;

namespace ProyectoFinal.ControlerLayer
{
    class ModificarUsuario
    {
        public bool Modificar(Persona p, Cuenta c)
        {
            using (TeatroEntities db = new TeatroEntities())
            {
                if (p != null && c != null)
                {

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    if (db.SaveChanges() == 1)
                    {
                        db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() == 1) return true;
                    }

                }

            }

            return false;
        }

    }
}
