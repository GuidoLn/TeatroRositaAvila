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
            cargarGrilla();
            if (ContLogin.GetInstance().verificarCuenta() == "empleado")
            {
                btnEliminar.Visible = false;
                lblUsuariosResponsablesCR.Visible = false;
                txtUsuarioResponsableCR.Visible = false;
                gbComprasRealizadas.Visible = false;
            }
            btnEliminar.Enabled = false;
            txtBusqueda.Text = "NumeroDeTicket";
            txtBusqueda.ForeColor = Color.Gray;
            cargarGrilla();
        }


        private void txtBusquedaNombre_MouseEnter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "NumeroDeTicket")
            {
                txtBusqueda.Text = string.Empty;
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaNombre_MouseLeave(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "" && !txtBusqueda.Focused)
            {
                txtBusqueda.Text = "NumeroDeTicket";
                txtBusqueda.ForeColor = Color.Gray;
            }
        }
        private void txtBusquedaNombre_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "NumeroDeTicket")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaNombre_Leave(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                txtBusqueda.Text = "NumeroDeTicket";
                txtBusqueda.ForeColor = Color.Gray;
            }
        }
        private void cargarGrilla()
        {
            string[] datos = { "Espectaculo", "Fecha y hora", "Precio", "Asientos", "NumeroDeTicket", "Usuario" };
            new DataGridViewController().crearColumnas(dgvCompras, datos);
            llenarGrilla();
        }
        private void llenarGrilla()
        {
            if (ContLogin.GetInstance().verificarCuenta() == "admin")
                new DataGridViewController().llenarGrillaComprasRealizadas(dgvCompras);
            if (ContLogin.GetInstance().verificarCuenta() == "empleado")
                new DataGridViewController().llenarGrillaComprasRealizadasEmpleado(dgvCompras);



        }

        private void btnAtrasCR_Click(object sender, EventArgs e)
        {
            if(ContLogin.GetInstance().verificarCuenta() == "empleado")
            {
                new MainMenuUser().Show();
                this.Close();
            }
            if(ContLogin.GetInstance().verificarCuenta() == "admin")
            {
                new Admin().Show();
                this.Close();
            }
            
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            new PropsTexBox().txtBusquedaNombre_TextChanged(sender, e, txtBusqueda, dgvCompras, "NumeroDeTicket");
        }

        private void ComprasRealizadas_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Quiere eliminar esta compra?", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                long idEliminar = long.Parse(txtNTicketCR.Text);
                if (new CompraController().eliminarCompras(idEliminar))
                {
                    MessageBox.Show("Compra eliminada con exito");
                    llenarGrilla();
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al eliminar la compra");
                }
            }
           
        }

        private void dgvCompras_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            if (row == dgvCompras.RowCount - 1) row = e.RowIndex - 1;           
            txtUsuarioResponsableCR.Text = dgvCompras.Rows[row].Cells[5].Value.ToString();
            txtFYHCR.Text = dgvCompras.Rows[row].Cells[1].Value.ToString();
            TXTImporteCR.Text = dgvCompras.Rows[row].Cells[2].Value.ToString();
            txtAsientosCR.Text = dgvCompras.Rows[row].Cells[3].Value.ToString();
            txtNTicketCR.Text = dgvCompras.Rows[row].Cells[4].Value.ToString();
            btnEliminar.Enabled = true;

        }
                
    }
}
