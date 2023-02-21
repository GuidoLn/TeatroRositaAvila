using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ControlerLayer
{
	public class EspectaculoController
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

        public bool agregarEspectaculo(Espectaculo espectaculo)
        {
            bool resultado = false;
            using (TeatroEntities db = new TeatroEntities())
            {
                db.Espectaculo.Add(espectaculo);
                if (db.SaveChanges() == 1)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        public List<Espectaculo> GetEspectaculos()
        {
            List<Espectaculo> espectaculos = new List<Espectaculo>();

            using (TeatroEntities db = new TeatroEntities()) espectaculos = db.Espectaculo.ToList();

            return espectaculos;
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
    }
}
