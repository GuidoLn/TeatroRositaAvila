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
        }
        private void cargarGrilla()
        {
            string[] datos = { "Usuario", "Fecha y hora", "Precio", "Asientos", "NumeroDeTicket", "Id" };
            new DataGridViewController().crearColumnas(dgvCompras, datos);
            llenarGrilla();
        }
        private void llenarGrilla()
        {
            new DataGridViewController().llenarGrillaComprasRealizadas(dgvCompras);
          
        }
    }
}
