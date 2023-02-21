using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.DataLayer;

namespace ProyectoFinal.ControlerLayer
{
    class GetData
    {
 


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


        //public List<Compra> GetComprasByEspectaculo(long espectaculoId)
        //{
        //    List<Compra> compras = new List<Compra>();
        //    List<Compra> comprasAux = new List<Compra>();
        //    using (TeatroEntities db = new TeatroEntities()) compras = db.Compra.ToList();
        //    foreach (Compra item in compras)
        //    {
        //        if (item.Espectaculoid == espectaculoId)
        //        {
        //            comprasAux.Add(item);
        //        }
        //    }

        //    return comprasAux;
        //}






        public Compania GetByNameCompañia(string name)
        {
            List<Compania> companias = new List<Compania>();

            using (TeatroEntities db = new TeatroEntities()) companias = db.Compania.ToList();

            foreach (var item in companias) if (name == item.NombreCompania) return item;

            return null;
        }

        public Persona GetByIdPersona(long id)
        {
            List<Persona> personas = new List<Persona>();

            using (TeatroEntities db = new TeatroEntities()) personas = db.Persona.ToList();

            foreach (var item in personas) if (id == item.Id) return item;

            return new Persona();
        }


        public Empleado GetByIdCEmpleado(long id)
        {
            List<Empleado> empleados = new List<Empleado>();

            using (TeatroEntities db = new TeatroEntities()) empleados = db.Empleado.ToList();

            foreach (var item in empleados) if (id == item.Cuentaid) return item;

            return new Empleado();
        }
 


        // Obtiene la lista de asientos por sector fijandose cuales ya estan comprados
        // viendo el espectaculo
        //public List<LocalidadAsiento> GetAsientosBySector(string sectorName, long espectaculoId)
        //{
        //    List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();
        //    List<LocalidadAsiento> asientosAux = new List<LocalidadAsiento>();
        //    using (TeatroEntities db = new TeatroEntities()) asientosAux = db.LocalidadAsiento.ToList();
        //    List<Compra> comprasByEspectaculo = new GetData().GetComprasByEspectaculo(espectaculoId);
        //    Sector sector = GetSector(sectorName);

        //    foreach (var asiento in asientosAux)
        //    {
        //        if (asiento.Sectorid == sector.Id)
        //        {
        //            foreach (var compra in comprasByEspectaculo)
        //            {
        //                compra.LocalidadEspectaculo = new GetData().GetLocalidadEspectaculoById(compra.LocalidadEspectaculoid);
        //                if (asiento.Id == compra.LocalidadEspectaculo.LocalidadAsientoid)
        //                {
        //                    asiento.EstadoAsiento = false;
        //                    break;
        //                }
        //            }
        //            asientos.Add(asiento);
        //        }
        //    }
        //    return asientos;
        //}
        
        // Obtiene la lista de asientos por sector
        //public List<LocalidadAsiento> GetAsientosBySector(string name)
        //{
        //    List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();
        //    List<LocalidadAsiento> asientosAux = new List<LocalidadAsiento>();
        //    using (TeatroEntities db = new TeatroEntities()) asientosAux = db.LocalidadAsiento.ToList();
        //    Sector sector = GetSector(name);

        //    foreach (var asiento in asientosAux)
        //    {
        //        if (asiento.Sectorid == sector.Id)
        //        {
        //            asientos.Add(asiento);
        //        }

        //    }
        //    return asientos;
        //}
        //public List<string> GetAsientosDisponibles(long idEspectaculo)
        //{
        //    List<string> numerosAsientos = new List<string>();
        //    List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();
        //    using (TeatroEntities db = new TeatroEntities()) asientos = db.LocalidadAsiento.ToList();
        //    List<Compra> comprasByEspectaculo = new GetData().GetComprasByEspectaculo(idEspectaculo);
        //    foreach (var asiento in asientos)
        //    {
        //        foreach (var compra in comprasByEspectaculo)
        //        {
        //            compra.LocalidadEspectaculo = new GetData().GetLocalidadEspectaculoById(compra.LocalidadEspectaculoid);
        //            if (asiento.Id != compra.LocalidadEspectaculo.LocalidadAsientoid)
        //            {
        //                numerosAsientos.Add(asiento.NumeroAsiento.ToString());
        //                break;
        //            }
        //        }
        //    }


        //    return numerosAsientos;
        //}
      





    }


}

