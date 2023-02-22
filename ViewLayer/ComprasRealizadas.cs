﻿using ProyectoFinal.ControlerLayer;
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
            }

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
            string[] datos = { "Usuario", "Fecha y hora", "Precio", "Asientos", "NumeroDeTicket", "Id" };
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
            new MainMenuUser().Show();
            this.Close();
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

        }
    }
}
