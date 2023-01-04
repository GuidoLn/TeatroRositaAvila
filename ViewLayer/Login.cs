using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.DataLayer;
using ProyectoFinal.ControlerLayer;
using ProyectoFinal.ViewLayer;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            resultado = new ContLogin().verificarCuenta(txtUsuario.Text, txtClave.Text);

            if (resultado == "admin")
            {
                MessageBox.Show("Admin logueado");
                new Admin().Show();
                this.Close();
            }
            else if (resultado == "empleado")  MessageBox.Show("Empleado logueado");
            else if (resultado == "cliente") MessageBox.Show("Cliente logueado");
            else MessageBox.Show("Usuario y/o contraseña incorrectos");
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_contOlvidada.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p_contOlvidada.Visible = true;
        }
    }
}
