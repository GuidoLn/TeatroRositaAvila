using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.DataLayer;

namespace ProyectoFinal.ControlerLayer
{
    class GetData
    {
        public List<Cuenta> GetCuentas ()
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            using (TeatroEntities db = new TeatroEntities()) cuentas = db.Cuenta.ToList();

            return cuentas;
        }
        public List<Espectaculo> GetEspectaculos()
        {
            List<Espectaculo> espectaculos = new List<Espectaculo>();

            using (TeatroEntities db = new TeatroEntities()) espectaculos = db.Espectaculo.ToList();

            return espectaculos;
        }
        public List<Compania> GetCompanias()
        {
            List<Compania> companias = new List<Compania>();

            using (TeatroEntities db = new TeatroEntities()) companias = db.Compania.ToList();

            return companias;
        }
        public Compania GetByIdCompañia(long id)
        {
            List<Compania> companias = new List<Compania>();

            using (TeatroEntities db = new TeatroEntities()) companias = db.Compania.ToList();

            foreach (var item in companias) if (id == item.Id) return item;

            return null;
        }
        public Compania GetByNameCompañia(string name)
        {
            List<Compania> companias = new List<Compania>();

            using (TeatroEntities db = new TeatroEntities()) companias = db.Compania.ToList();

            foreach (var item in companias) if (name == item.NombreCompania) return item;

            return null;
        }

        public Cuenta GetByIdCuenta( long id )
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            using (TeatroEntities db = new TeatroEntities()) cuentas = db.Cuenta.ToList();

            foreach (var item in cuentas) if (id == item.Id) return item;
            
            return new Cuenta();
        }

        public Persona GetByIdPersona(long id)
        {
            List<Persona> personas = new List<Persona>();

            using (TeatroEntities db = new TeatroEntities()) personas = db.Persona.ToList();

            foreach (var item in personas) if (id == item.Id) return item;

            return new Persona();        }
       

        public Empleado GetByIdCEmpleado(long id)
        {
            List<Empleado> empleados = new List<Empleado>();

            using (TeatroEntities db = new TeatroEntities()) empleados = db.Empleado.ToList();

            foreach (var item in empleados) if (id == item.Cuentaid) return item;

            return new Empleado();
        }
    }
}
