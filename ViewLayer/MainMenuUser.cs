using ProyectoFinal.ControlerLayer;
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
    public partial class MainMenuUser : Form
    {
        public MainMenuUser()
        {
            InitializeComponent();
            lblWelcome.Text = $"Bienvenido {ContLogin.GetInstance().UsuarioLogueado}";
        }

        private void btnEspectaculos_Click(object sender, EventArgs e)
        {
            EspectaculoGerente eg = new EspectaculoGerente();
            eg.Show();
            this.Close();
        }

        private void MainMenuUser_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ContLogin contLogin = ContLogin.GetInstance();
            contLogin.UsuarioLogueado = "Usuario";
            new Login().Show();
            this.Close();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            new RealizarCompras().Show();
            this.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            
        }
    }
}
