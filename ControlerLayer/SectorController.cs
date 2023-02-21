using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.DataLayer;

namespace ProyectoFinal.ControlerLayer
{
    public class SectorController
    {
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
        public long GetByNameSectorId(string nameSector)
        {
            using (TeatroEntities db = new TeatroEntities())
            {
                return db.Sector.FirstOrDefault(la => la.NombreSector == nameSector).Id;
            }

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
                if (int.Parse(asiento) == item.NumeroAsiento)
                {
                    sector = GetSectorById(item.Sectorid);
                }
            }

            return sector;
        }
    }
}
