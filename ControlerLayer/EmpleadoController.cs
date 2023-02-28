using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ControlerLayer
{
    public class EmpleadoController
    {
        public Empleado GetByIdCEmpleado(long id)
        {
            List<Empleado> empleados = new List<Empleado>();

            using (TeatroEntities db = new TeatroEntities()) empleados = db.Empleado.ToList();

            foreach (var item in empleados) if (id == item.Cuentaid) return item;

            return new Empleado();
        }

    }
}
