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
        public List<Espectaculo> GetEspectaculos()
        {
            List<Espectaculo> espectaculos = new List<Espectaculo>();

            using (TeatroEntities db = new TeatroEntities()) espectaculos = db.Espectaculo.ToList();

            return espectaculos;
        }
        public List<LocalidadAsiento> GetAsientos()
        {
            List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();

            using (TeatroEntities db = new TeatroEntities()) asientos = db.LocalidadAsiento.ToList();

            return asientos;
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
        public LocalidadEspectaculo GetLocalidadEspectaculoById(long id)
        {
            List<LocalidadEspectaculo> localidadEspectaculos = new List<LocalidadEspectaculo>();

            using (TeatroEntities db = new TeatroEntities()) localidadEspectaculos = db.LocalidadEspectaculo.ToList();

            foreach (var item in localidadEspectaculos) if (id == item.Id) return item;

            return null;
        }

        public List<Compra> GetComprasByEspectaculo(long espectaculoId)
        {
            List<Compra> compras = new List<Compra>();
            List<Compra> comprasAux = new List<Compra>();
            using (TeatroEntities db = new TeatroEntities()) compras = db.Compra.ToList();
            foreach (Compra item in compras)
            {
                if (item.Espectaculoid == espectaculoId)
                {
                    comprasAux.Add(item);
                }
            }

            return comprasAux;
        }

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
        public Sector GetSector(string name)
        {
            List<Sector> sectores = new List<Sector>();
            Sector sector = new Sector();
            using (TeatroEntities db = new TeatroEntities()) sectores = db.Sector.ToList();
            foreach (var item in sectores)
            {
                if (item.NombreSector == name) return item;
            }
            return sector;
        }
        public Sector GetSectorById(long id)
        {
            List<Sector> sectores = new List<Sector>();
            Sector sector = new Sector();
            using (TeatroEntities db = new TeatroEntities()) sectores = db.Sector.ToList();
            foreach (var item in sectores)
            {
                if (item.Id == id) return item;
            }
            return sector;
        }
        public Espectaculo GetEspectaculoById(long id)
        {
            List<Espectaculo> espectaculos = new List<Espectaculo>();
            Espectaculo espectaculo = new Espectaculo();
            using (TeatroEntities db = new TeatroEntities()) espectaculos = db.Espectaculo.ToList();
            foreach (var item in espectaculos)
            {
                if (item.Id == id) return item;
            }
            return espectaculo;
        }
        // Obtiene la lista de asientos por sector fijandose cuales ya estan comprados
        // viendo el espectaculo
        public List<LocalidadAsiento> GetAsientosBySector(string sectorName, long espectaculoId)
        {
            List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();
            List<LocalidadAsiento> asientosAux = new List<LocalidadAsiento>();
            using (TeatroEntities db = new TeatroEntities()) asientosAux = db.LocalidadAsiento.ToList();
            List<Compra> comprasByEspectaculo = new GetData().GetComprasByEspectaculo(espectaculoId);
            Sector sector = GetSector(sectorName);

            foreach (var asiento in asientosAux)
            {
                if (asiento.Sectorid == sector.Id)
                {
                    foreach (var compra in comprasByEspectaculo)
                    {
                        compra.LocalidadEspectaculo = new GetData().GetLocalidadEspectaculoById(compra.LocalidadEspectaculoid);
                        if (asiento.Id == compra.LocalidadEspectaculo.LocalidadAsientoid)
                        {
                            asiento.EstadoAsiento = false;
                            break;
                        }
                    }
                    asientos.Add(asiento);
                }
            }
            return asientos;
        }
        // Obtiene la lista de asientos por sector
        public List<LocalidadAsiento> GetAsientosBySector(string name)
        {
            List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();
            List<LocalidadAsiento> asientosAux = new List<LocalidadAsiento>();
            using (TeatroEntities db = new TeatroEntities()) asientosAux = db.LocalidadAsiento.ToList();
            Sector sector = GetSector(name);

            foreach (var asiento in asientosAux)
            {
                if (asiento.Sectorid == sector.Id)
                {
                    asientos.Add(asiento);
                }
                
            }
            return asientos;
        }
        public List<string> GetAsientosDisponibles(long idEspectaculo)
        {
            List<string> numerosAsientos = new List<string>();
            List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();
            using (TeatroEntities db = new TeatroEntities()) asientos = db.LocalidadAsiento.ToList();
            List<Compra> comprasByEspectaculo = new GetData().GetComprasByEspectaculo(idEspectaculo);
            foreach (var asiento in asientos)
            {
                foreach (var compra in comprasByEspectaculo)
                {
                    compra.LocalidadEspectaculo = new GetData().GetLocalidadEspectaculoById(compra.LocalidadEspectaculoid);
                    if (asiento.Id != compra.LocalidadEspectaculo.LocalidadAsientoid)
                    {
                        numerosAsientos.Add(asiento.NumeroAsiento.ToString());
                        break;
                    }
                }
            }
           

            return numerosAsientos;
        }
        public Sector GetSectorByAsiento(string asiento)
        {
            Sector sector = new Sector();
            List<LocalidadAsiento> asientos = new List<LocalidadAsiento>();
            using (TeatroEntities db = new TeatroEntities())
            {
                asientos = db.LocalidadAsiento.ToList();
            }
            foreach (var item in asientos)
            {
                if(int.Parse(asiento) == item.NumeroAsiento)
                {
                    sector = GetSectorById(item.Sectorid);
                }
            }
                        
            return sector;
        }
        public float calcularPrecio(List<string> asientos, long espectaculoID)
        {
            float precioFinal = 0;
            float precioByEspectaculo = float.Parse(GetEspectaculoById(espectaculoID).PrecioEspectaculo.ToString());
            float precioBySector; 
            foreach (var item in asientos)
            {
                precioBySector = float.Parse(GetSectorByAsiento(item).PrecioSector.ToString());
                precioFinal = precioFinal + (precioByEspectaculo * precioBySector);

            }
            return precioFinal;
        }

    }


}

