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
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Collections;

namespace ProyectoFinal.ViewLayer
{
    public partial class EspectaculoGerente : Form
    {
        public EspectaculoGerente()
        {
            InitializeComponent();
            cargarGrilla();
            cargarListBox();
            btnModificar.Enabled = false;
            dtpFecha.CustomFormat = "dd/MM/yy hh:mm";
            btnEliminar.Enabled = false;
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
            string[] datos = { "Nombre", "Compañia", "Fecha y hora", "Precio", "Descripcion", "Id" };                 
            new DataGridViewController().crearColumnas(dgvEspectaculos,datos);           
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
                    dgvEspectaculos.Rows.Add(item1.NombreEspectaculo, item1.Compania.NombreCompania, item1.FechaYHora, item1.PrecioEspectaculo, item1.DescripcionEspectaculo, item1.Id);
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ContLogin contLogin = ContLogin.GetInstance();
            if (contLogin.verificarCuenta(contLogin.UsuarioLogueado).ToLower() == "admin")
            {
                new Admin().Show();
                this.Close();
            }
            else if(contLogin.verificarCuenta(contLogin.UsuarioLogueado).ToLower() == "empleado")
            {
                new MainMenuUser().Show();
                this.Close();
            }
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
                if (new AgregarEspectaculo().agregarEspectaculo(espectaculo))
                {
                    MessageBox.Show("Espectaculo agregado correctamente");
                    llenarGrilla(new GetData().GetEspectaculos());
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se guardo el espectaculo");
                }

            }
        }
        private void limpiarTextBox()
        {
            txtNombre.Text = "";            
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            txtID.Text = "";
            dtpFecha.Value = DateTime.Now;
        }
        private void controlTextBox(bool control)
        {
            if (control)
            {
                txtNombre.Enabled = true;
                lbCompania.Enabled = true;
                dtpFecha.Enabled = true;
                txtPrecio.Enabled = true;
                txtDescripcion.Enabled = true;
                txtID.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
                lbCompania.Enabled = false;
                dtpFecha.Enabled = false;
                txtPrecio.Enabled = false;
                txtDescripcion.Enabled = false;
                txtID.Enabled = false;
            }
        }
        private bool validacionesFormEspectaculos()
        {
            bool condicion1 = txtNombre.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "" || dtpFecha.Text == "" || lbCompania.Text == "";


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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            controlTextBox(true);
            btnAgregar.Enabled = false;
            btnModificar.Visible = false;
            btnGuardar.Visible = true;
            btnEliminar.Enabled = false;

        }


        private void dgvEspectaculos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            if (row == dgvEspectaculos.RowCount - 1) row = e.RowIndex - 1;
            txtNombre.Text = dgvEspectaculos.Rows[row].Cells[0].Value.ToString();
            lbCompania.Text = dgvEspectaculos.Rows[row].Cells[1].Value.ToString();
            dtpFecha.Value = DateTime.Parse(dgvEspectaculos.Rows[row].Cells[2].Value.ToString());
            txtPrecio.Text = dgvEspectaculos.Rows[row].Cells[3].Value.ToString();
            txtDescripcion.Text = dgvEspectaculos.Rows[row].Cells[4].Value.ToString();
            txtID.Text = dgvEspectaculos.Rows[row].Cells["ID"].Value.ToString();
            controlTextBox(false);
            btnModificar.Enabled = true;
            btnAgregar.Visible = false;
            btnLimpiar.Visible = true;
            btnEliminar.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
                DialogResult dialogResult = MessageBox.Show("¿Quiere eliminar este espectaculo?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Espectaculo espectaculo = new Espectaculo();
                    espectaculo.Id = long.Parse(txtID.Text);
                    espectaculo.EstadoEspectaculo = false;
                    espectaculo.NombreEspectaculo = txtNombre.Text;
                    espectaculo.DescripcionEspectaculo = txtDescripcion.Text;
                    espectaculo.PrecioEspectaculo = int.Parse(txtPrecio.Text);
                    espectaculo.FechaYHora = dtpFecha.Value;
                    espectaculo.Companiaid = new GetData().GetByNameCompañia(lbCompania.Text).Id;
                    if (new ModificarEspectaculo().modificarEspectaculo(espectaculo))
                    {
                        MessageBox.Show("Espectaculo eliminado correctamente");
                        llenarGrilla(new GetData().GetEspectaculos());
                        btnAgregar.Enabled = true;
                        btnModificar.Visible = true;
                        btnModificar.Enabled = false;
                        btnGuardar.Visible = false;
                        btnEliminar.Enabled = false;
                }
                    else
                    {
                        MessageBox.Show("No se elimino el espectaculo");
                    }

                }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validacionesFormEspectaculos())
            {
                DialogResult dialogResult = MessageBox.Show("¿Quiere modificar este espectaculo?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    Espectaculo espectaculo = new Espectaculo();
                    espectaculo.Id = long.Parse(txtID.Text);
                    espectaculo.EstadoEspectaculo = true;
                    espectaculo.NombreEspectaculo = txtNombre.Text;                    
                    espectaculo.DescripcionEspectaculo = txtDescripcion.Text;
                    espectaculo.PrecioEspectaculo = int.Parse(txtPrecio.Text);
                    espectaculo.FechaYHora = dtpFecha.Value;
                    espectaculo.Companiaid = new GetData().GetByNameCompañia(lbCompania.Text).Id;
                    if (new ModificarEspectaculo().modificarEspectaculo(espectaculo))
                    {
                        MessageBox.Show("Espectaculo modificado correctamente");
                        llenarGrilla(new GetData().GetEspectaculos());
                        btnAgregar.Enabled = true;
                        btnModificar.Visible = true;
                        btnModificar.Enabled = false;
                        btnGuardar.Visible = false;
                        btnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se modifico el espectaculo");
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
