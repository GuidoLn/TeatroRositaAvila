using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.ViewLayer;
using System.Globalization;
using ProyectoFinal.ViewLayer;
using ProyectoFinal.ControlerLayer;

namespace ProyectoFinal.ViewLayer
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ABMLUsuarios().Show();
            this.Close();
        }

        private void bt_AdALogin_Click(object sender, EventArgs e)
        {
            ContLogin contLogin = ContLogin.GetInstance();
            contLogin.UsuarioLogueado = "Usuario";
            new Login().Show();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            dateTimePicker1.Value = localDate;
        }

        private void bt_AdEspectáculo_Click(object sender, EventArgs e)
        {
            EspectaculoGerente eg = new EspectaculoGerente();
            eg.Show();
            this.Close();
        }

        private void bt_AdAAsientos_Click(object sender, EventArgs e)
        {
            new AsientoGerente().Show();
            this.Close();
        }
    }
}
