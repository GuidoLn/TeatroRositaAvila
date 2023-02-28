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
    public partial class ABMLCompania : Form
    {
        public ABMLCompania()
        {
            InitializeComponent();
            cargarGrilla();            
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }      
        private void cargarGrilla()
        {
            string[] datos = { "Nombre", "Descripcion", "Mail", "Telefono", "Id" };
            new DataGridViewController().crearColumnas(dgvCompania, datos);
            llenarGrilla(new CompaniaController().GetCompanias());

        }
        private void llenarGrilla(List<Compania> companias)
        {
            dgvCompania.Rows.Clear();
            foreach (var item1 in companias)
            {
                if ((bool)item1.EstadoCompania)
                {
                    dgvCompania.Rows.Add(item1.NombreCompania, item1.DescripcionCompania, item1.EmailCompania, item1.TelefonoCompania, item1.Id);
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
                Compania compania = new Compania();
                compania.NombreCompania = txtCompania.Text;
                compania.EmailCompania = txtMail.Text;
                compania.DescripcionCompania = txtDescripcion.Text;
                compania.TelefonoCompania = txtTelefono.Text;
                compania.EstadoCompania = true;
                if (new CompaniaController().agregarCompania(compania))
                {
                    MessageBox.Show("Compania agregada correctamente");
                    llenarGrilla(new CompaniaController().GetCompanias());
                    limpiarTextBox();
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se guardo la compania ");
                }

            }
        }
        private void limpiarTextBox()
        {
            txtCompania.Text = "";
            txtMail.Text = "";
            txtDescripcion.Text = "";
            txtTelefono.Text = "";
            txtId.Text = "";
        }
        private void controlTextBox(bool control)
        {
            if (control)
            {
                txtCompania.Enabled = true;
                txtMail.Enabled = true;
                txtDescripcion.Enabled = true;
                txtTelefono.Enabled = true;
                txtId.Enabled = true;
            }
            else
            {
                txtCompania.Enabled = false;
                txtMail.Enabled = false;
                txtDescripcion.Enabled = false;
                txtTelefono.Enabled = false;
                txtId.Enabled = false;
            }
        }
        private bool validacionesFormEspectaculos()
        {
            bool condicion1 = txtCompania.Text == "" || txtDescripcion.Text == "" || txtMail.Text == "" || txtTelefono.Text == "";


            if (condicion1)
            {
                MessageBox.Show("Los items con '*' no pueden estar vacios. Error");
                return false;
            }

            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            controlTextBox(true);
            btnAgregar.Enabled = false;
            btnModificar.Visible = false;
            btnGuardar.Visible = true;
            btnEliminar.Enabled = false;
        }


        private void dgvCompania_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            if (row == dgvCompania.RowCount - 1) row = e.RowIndex - 1;
            txtCompania.Text = dgvCompania.Rows[row].Cells[0].Value.ToString();
            txtDescripcion.Text = dgvCompania.Rows[row].Cells[1].Value.ToString();
            txtMail.Text = dgvCompania.Rows[row].Cells[2].Value.ToString();
            txtTelefono.Text = dgvCompania.Rows[row].Cells[3].Value.ToString();
            txtId.Text = dgvCompania.Rows[row].Cells["ID"].Value.ToString();
            controlTextBox(false);
            btnModificar.Enabled = true;
            btnAgregar.Visible = false;
            btnLimpiar.Visible = true;
            btnEliminar.Enabled = true;
            btnGuardar.Visible = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿Quiere eliminar esta compania?", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Compania compania = new Compania();
                compania.Id = long.Parse(txtId.Text);
                compania.EstadoCompania = false;
                compania.NombreCompania = txtCompania.Text;
                compania.DescripcionCompania = txtDescripcion.Text;
                compania.EmailCompania = txtMail.Text;
                compania.TelefonoCompania = txtTelefono.Text;
                if (new CompaniaController().modificarCompania(compania))
                {
                    MessageBox.Show("Compañia eliminada correctamente");
                    llenarGrilla(new CompaniaController().GetCompanias());
                    btnAgregar.Enabled = true;
                    btnModificar.Visible = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Visible = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se elimino la compañia");
                }

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validacionesFormEspectaculos())
            {
                DialogResult dialogResult = MessageBox.Show("¿Quiere modificar esta compañia?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Compania compania = new Compania();
                    compania.Id = long.Parse(txtId.Text);
                    compania.EstadoCompania = true;
                    compania.NombreCompania = txtCompania.Text;
                    compania.DescripcionCompania = txtDescripcion.Text;
                    compania.EmailCompania = txtMail.Text;
                    compania.TelefonoCompania = txtTelefono.Text;
                    if (new CompaniaController().modificarCompania(compania))
                    {
                        MessageBox.Show("Compañia modificada correctamente");
                        llenarGrilla(new CompaniaController().GetCompanias());
                        limpiarTextBox();
                        btnAgregar.Enabled = true;
                        btnModificar.Visible = true;
                        btnModificar.Enabled = false;
                        btnGuardar.Visible = false;
                        btnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se modifico la compañia");
                    }

                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
            controlTextBox(true);
            btnAgregar.Visible = true;
            btnAgregar.Enabled = true;
            btnLimpiar.Visible = false;
            btnModificar.Visible = true;
            btnModificar.Enabled = false;
            btnGuardar.Visible = false;
            btnEliminar.Enabled = false;
        }
    }
}

