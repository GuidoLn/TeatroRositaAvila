using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.DataLayer;

namespace ProyectoFinal.ControlerLayer
{
    class CrearUsuario
    {

        public bool Registrar(Persona p, Cuenta c)
        {
            using (TeatroEntities db = new TeatroEntities())
            {
                db.Persona.Add(p);
                if (db.SaveChanges() == 1)
                {
                    db.Cuenta.Add(c);
                    if (db.SaveChanges() == 1) 
                    {
                        Empleado empleado = new Empleado();
                        empleado.Cuentaid = c.Id;
                        empleado.Personaid = p.Id;
                        db.Empleado.Add(empleado);
                        if (db.SaveChanges() == 1) return true;
                    }
                }
            }

            return false;
        }

    }
}
