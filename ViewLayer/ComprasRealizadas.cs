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
            string[] datos = { "Usuario", "Fecha y hora", "Precio", "Asientos", "NumeroDeTicket", "Id" };
            new DataGridViewController().crearColumnas(dgvCompras, datos);
            llenarGrilla();
        }
        private void llenarGrilla()
        {
            dgvCompras.Rows.Clear();

            foreach (var item in Diccionario.LocalidadEspectaculoByFechaCache)
            {
                dgvCompras.Rows.Add(item., item.Compania.NombreCompania, item.FechaYHora, item1.PrecioEspectaculo, item1.DescripcionEspectaculo, item1.Id);
            }
        }
    }
}
