using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ControlerLayer
{
    internal class CuentaController
    {

        public List<Cuenta> GetCuentas()
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            using (TeatroEntities db = new TeatroEntities()) cuentas = db.Cuenta.ToList();

            return cuentas;
        }
        public Cuenta GetByIdCuenta(long id)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            using (TeatroEntities db = new TeatroEntities()) cuentas = db.Cuenta.ToList();

            foreach (var item in cuentas) if (id == item.Id) return item;

            return null;
        }

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

        public string verificarCuenta(string usuario, string clave)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            using (TeatroEntities db = new TeatroEntities())
            {
                cuentas = db.Cuenta.ToList();
            }

            foreach (Cuenta element in cuentas)
            {
                if (usuario == element.Usuario && clave == element.Contraseña)
                {
                    return element.TipoUsuario;
                }
            }

            return string.Empty;
        }
        public string verificarCuenta(string userName)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            using (TeatroEntities db = new TeatroEntities())
            {
                cuentas = db.Cuenta.ToList();
            }

            foreach (Cuenta element in cuentas)
            {
                if (userName == element.Usuario)
                {
                    return element.TipoUsuario;
                }
            }

            return string.Empty;
        }
        public long traerCuentaidByNombre(string userName)
        {
            using (TeatroEntities db = new TeatroEntities())
            {
                var cuenta = db.Cuenta.FirstOrDefault(c => c.Usuario == userName);
                if (cuenta != null)
                {
                    return cuenta.Id;
                }
                else
                {
                    // Si no se encuentra la cuenta con el nombre de usuario dado, se puede devolver un valor negativo o lanzar una excepción.
                    return -1;
                    //throw new Exception("No se encontró una cuenta con el nombre de usuario dado.");
                }
            }
        }

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
