using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ControlerLayer
{
    public class CompaniaController
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

        public Compania GetByNameCompañia(string name)
        {
            List<Compania> companias = new List<Compania>();

            using (TeatroEntities db = new TeatroEntities()) companias = db.Compania.ToList();

            foreach (var item in companias) if (name == item.NombreCompania) return item;

            return null;
        }
        public bool agregarCompania(Compania compania)
        {
            bool resultado = false;
            using (TeatroEntities db = new TeatroEntities())
            {
                db.Compania.Add(compania);
                if (db.SaveChanges() == 1)
                {
                    resultado = true;
                }
            }
            return resultado;

        }

        public bool modificarCompania(Compania compania)
        {
            bool resultado = false;
            using (TeatroEntities db = new TeatroEntities())
            {
                db.Entry(compania).State = System.Data.Entity.EntityState.Modified;
                if (db.SaveChanges() == 1) resultado = true;
            }
            return resultado;
        }

    }
}
