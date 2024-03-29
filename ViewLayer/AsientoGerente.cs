﻿using ProyectoFinal.ControlerLayer;
using ProyectoFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ProyectoFinal.ViewLayer
{
    public partial class AsientoGerente : Form
    {
        public AsientoGerente()
        {
            InitializeComponent();

            txtBusquedaNombre.Text = "Nombre";
            txtBusquedaNombre.ForeColor = Color.Gray;           
            cargarGrilla();
        }


        private void txtBusquedaNombre_MouseEnter(object sender, EventArgs e)
        {
            if (txtBusquedaNombre.Text == "Nombre")
            {
                txtBusquedaNombre.Text = string.Empty;
                txtBusquedaNombre.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaNombre_MouseLeave(object sender, EventArgs e)
        {
            if (txtBusquedaNombre.Text == "" && !txtBusquedaNombre.Focused)
            {
                txtBusquedaNombre.Text = "Nombre";
                txtBusquedaNombre.ForeColor = Color.Gray;
            }
        }
        private void txtBusquedaNombre_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaNombre.Text == "Nombre")
            {
                txtBusquedaNombre.Text = "";
                txtBusquedaNombre.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaNombre_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaNombre.Text == "")
            {
                txtBusquedaNombre.Text = "Nombre";
                txtBusquedaNombre.ForeColor = Color.Gray;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Close();
        }
        private void cargarGrilla()
        {
            string[] datos = { "Nombre", "Compañia", "Fecha y hora", "Precio", "Descripcion", "Id", "Sector" };
            new DataGridViewController().crearColumnas(dgvAsientos, datos);
            llenarGrilla(new EspectaculoController().GetEspectaculos());

        }
        private void llenarGrilla(List<Espectaculo> espectaculos)
        {
            dgvAsientos.Rows.Clear();
            foreach (var item1 in espectaculos)
            {
                if (item1.EstadoEspectaculo)
                {
                    item1.Compania = new CompaniaController().GetByIdCompañia(item1.Companiaid);
                    dgvAsientos.Rows.Add(item1.NombreEspectaculo, item1.Compania.NombreCompania, item1.FechaYHora, item1.PrecioEspectaculo, item1.DescripcionEspectaculo, item1.Id);
                }
            }
        }
        private void txtBusquedaNombre_TextChanged(object sender, EventArgs e)
        {
            new PropsTexBox().txtBusquedaNombre_TextChanged(sender, e, txtBusquedaNombre, dgvAsientos, "Nombre");
        } 
        private void dgvCellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            gbSA.Invalidate();            
            gbSC.Invalidate();            
        }
     
        private void prepareToPaint(object sender, PaintEventArgs e)
        {    
            Control control = sender as Control;
            string sectorName = control.Text;
            int currentRow = dgvAsientos.CurrentCell.RowIndex;
            long espectaculoId = long.Parse(dgvAsientos.Rows[currentRow].Cells["Id"].Value.ToString());
            long sectorId = new SectorController().GetByNameSectorId(control.Text);
            List<LocalidadAsiento> asientos = new Diccionario().GetAsientosDiccionarioByEspectaculoAndSector(sectorName,espectaculoId);                      
            DrawOnGroupBox(control, e, asientos);            
        }
        private void DrawOnGroupBox(Control groupBox, PaintEventArgs e, List<LocalidadAsiento> asientos)
        {
            try
            {
                Graphics g = e.Graphics;
                int count = asientos.Count;
                // Calcular el tamaño de cada rectángulo
                double areaGroupBox = Math.Ceiling((double)(groupBox.ClientSize.Width * groupBox.ClientSize.Height));
                areaGroupBox = Math.Ceiling(areaGroupBox - (areaGroupBox * 0.05));
                int areaSquare = (int)Math.Ceiling((double)areaGroupBox / asientos.Count);
                int side = (int)Math.Sqrt(areaSquare);
                int space = (side / 4);
                side = side - space;
                int rowIndex = 12;
                int columnIndex = space;
                foreach (var asiento in asientos)
                {
                    if (columnIndex + side <= groupBox.Width - side )
                    {
                        
                        if (asiento.EstadoAsiento)
                        {                            
                            g.FillRectangle(Brushes.Green, columnIndex, rowIndex, side, side);
                            g.DrawString(asiento.NumeroAsiento.ToString(), new Font("Arial", 8), Brushes.White, new PointF(columnIndex + (side / 4), rowIndex + (side / 4)));
                            columnIndex = columnIndex + side + space;                                                   
                        }
                        else
                        {                           
                            g.FillRectangle(Brushes.Red, columnIndex, rowIndex, side, side);
                            g.DrawString(asiento.NumeroAsiento.ToString(), new Font("Arial", 8), Brushes.White, new PointF(columnIndex + (side / 4), rowIndex + (side / 4)));
                            columnIndex = columnIndex + side + space;                          
                        }              
                    }
                    else if (rowIndex + side <= groupBox.Height)
                    {                        
                        if (asiento.EstadoAsiento)
                        {
                            g.FillRectangle(Brushes.Green, columnIndex, rowIndex, side, side);
                            g.DrawString(asiento.NumeroAsiento.ToString(), new Font("Arial", 8), Brushes.White, new PointF(columnIndex + (side / 4), rowIndex + (side / 4)));
                            columnIndex = columnIndex + side + space;
                            columnIndex = space;
                            rowIndex = rowIndex + side + space;                       
                        }
                        else
                        {
                            g.FillRectangle(Brushes.Red, columnIndex, rowIndex, side, side);
                            g.DrawString(asiento.NumeroAsiento.ToString(), new Font("Arial", 8), Brushes.White, new PointF(columnIndex + (side / 4), rowIndex + (side / 4)));
                            columnIndex = columnIndex + side + space;
                            columnIndex = space;
                            rowIndex = rowIndex + side + space;                        
                        }
                    }

                }
            }
            catch (DivideByZeroException error)
            {
                MessageBox.Show($"Error: {error}");
            }
        }

        private void dgvAsientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
