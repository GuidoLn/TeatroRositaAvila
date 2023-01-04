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
using ProyectoFinal.ControlerLayer;

namespace ProyectoFinal.ViewLayer
{
    public partial class EspectaculoGerente : Form
    {
        public EspectaculoGerente()
        {
            InitializeComponent();
            cargarGrilla();
            cargarListBox();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EspectaculoGerente_Load(object sender, EventArgs e)
        {

        }
        public void cargarListBox()
        {
            List<Compania> companias = new GetData().GetCompanias();
            foreach (var item in companias)
            {
                lbCompania.Items.Add(item.NombreCompania);
            }
        }
        private void cargarGrilla()
        {
            dgvEspectaculos.Columns.Clear();
            dgvEspectaculos.Rows.Clear();
            dgvEspectaculos.Columns.Add("Nombre", "Nombre");
            dgvEspectaculos.Columns.Add("Compañia", "Compañia");
            dgvEspectaculos.Columns.Add("Fecha y hora", "Fecha y hora");
            dgvEspectaculos.Columns.Add("Precio", "Precio");
            dgvEspectaculos.Columns.Add("Descripcion", "Descripcion");           
            llenarGrilla(new GetData().GetEspectaculos());
         
        }
        private void llenarGrilla(List<Espectaculo> espectaculos)
        {            
            dgvEspectaculos.Rows.Clear();
            foreach (var item1 in espectaculos)
            {
                if (item1.EstadoEspectaculo)
                {
                    item1.Compania = new GetData().GetByIdCompañia(item1.Companiaid);
                    dgvEspectaculos.Rows.Add(item1.NombreEspectaculo, item1.Compania.NombreCompania, item1.FechaYHora, item1.PrecioEspectaculo, item1.DescripcionEspectaculo);
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validacionesFormEspectaculos())
            {
                Espectaculo espectaculo = new Espectaculo();
                espectaculo.NombreEspectaculo = txtNombre.Text;
                espectaculo.EstadoEspectaculo = true;
                espectaculo.DescripcionEspectaculo = txtDescripcion.Text;
                espectaculo.PrecioEspectaculo = int.Parse(txtPrecio.Text);
                espectaculo.FechaYHora = dtpFecha.Value;
                espectaculo.Companiaid = new GetData().GetByNameCompañia(lbCompania.Text).Id;
                if(new AgregarEspectaculo().agregarEspectaculo(espectaculo))
                {
                    MessageBox.Show("Espectaculo agregado correctamente");
                    llenarGrilla(new GetData().GetEspectaculos());
                }
                else
                {
                    MessageBox.Show("No se guardo el espectaculo");

                }

            }
        }

        private bool validacionesFormEspectaculos()
        {
            bool condicion1 = txtNombre.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "" || dtpFecha.Text  == "" || lbCompania.Text == "";


            if (condicion1)
            {
                MessageBox.Show("Los items con '*' no pueden estar vacios. Error");
                return false;
            }
            try
            {
                long number = long.Parse(txtPrecio.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puso un numero en Precio. Error");
                return false;
            }

            return true;
        }

    }
}
