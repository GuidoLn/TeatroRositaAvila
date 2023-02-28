using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ControlerLayer
{
    public class PersonaController
    {
        public Persona GetByIdPersona(long id)
        {
            List<Persona> personas = new List<Persona>();

            using (TeatroEntities db = new TeatroEntities()) personas = db.Persona.ToList();

            foreach (var item in personas) if (id == item.Id) return item;

            return new Persona();
        }

    }
}
