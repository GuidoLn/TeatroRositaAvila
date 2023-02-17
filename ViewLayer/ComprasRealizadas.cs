using ProyectoFinal.ControlerLayer;
using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.ViewLayer
{
    public partial class ComprasRealizadas : Form
    {
        public ComprasRealizadas()
        {
            InitializeComponent();
        }
        private void cargarGrilla()
        {
            string[] datos = { "Nombre", "Fecha y hora", "Precio", "Asientos", "NumeroDeTicket" ,"Id" };
            new DataGridViewController().crearColumnas(dgvCompras, datos);
            llenarGrilla(new GetData().GetEspectaculos());
        }
        private void llenarGrilla(List<Espectaculo> espectaculos)
        {
            dgvCompras.Rows.Clear();
            foreach (var item1 in espectaculos)
            {
                if (item1.EstadoEspectaculo)
                {
                    item1.Compania = new GetData().GetByIdCompañia(item1.Companiaid);
                    dgvCompras.Rows.Add(item1.NombreEspectaculo, item1.Compania.NombreCompania, item1.FechaYHora, item1.PrecioEspectaculo, item1.DescripcionEspectaculo, item1.Id);
                }
            }
        }
    }
}
