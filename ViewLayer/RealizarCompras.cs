using ProyectoFinal.ControlerLayer;
using ProyectoFinal.DataLayer;
using ProyectoFinal.ViewLayer;
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
    public partial class RealizarCompras : Form
    {
        private List<string> asientosSeleccionados = new List<string>();

        public List<string> AsientosSeleccionados { get => asientosSeleccionados; set => asientosSeleccionados = value; }

        public RealizarCompras()
        {
            InitializeComponent();
            txtBusquedaNombre.Text = "Nombre";
            txtBusquedaNombre.ForeColor = Color.Gray;
            CargarGrilla();
        }

        private void TxtBusquedaNombre_MouseEnter(object sender, EventArgs e)
        {
            if (txtBusquedaNombre.Text == "Nombre")
            {
                txtBusquedaNombre.Text = string.Empty;
                txtBusquedaNombre.ForeColor = Color.Black;
            }
        }

        private void TxtBusquedaNombre_MouseLeave(object sender, EventArgs e)
        {
            if (txtBusquedaNombre.Text == "" && !txtBusquedaNombre.Focused)
            {
                txtBusquedaNombre.Text = "Nombre";
                txtBusquedaNombre.ForeColor = Color.Gray;
            }
        }
        private void TxtBusquedaNombre_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaNombre.Text == "Nombre")
            {
                txtBusquedaNombre.Text = "";
                txtBusquedaNombre.ForeColor = Color.Black;
            }
        }

        private void TxtBusquedaNombre_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaNombre.Text == "")
            {
                txtBusquedaNombre.Text = "Nombre";
                txtBusquedaNombre.ForeColor = Color.Gray;
            }
        }

        private void CargarGrilla()
        {
            string[] datos = { "Nombre", "Precio", "Id" };
            dgvRealizarCompra.Columns.Clear();
            dgvRealizarCompra.Rows.Clear();
            foreach (string items in datos)
            {
                dgvRealizarCompra.Columns.Add(items, items);
                if (items == "Id")
                {
                    dgvRealizarCompra.Columns["Id"].Visible = false;
                }
            }
            LlenarGrilla(new GetData().GetEspectaculos());
        }




        private void DgvRealizarCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LlenarGrilla(List<Espectaculo> espectaculos)
        {
            dgvRealizarCompra.Rows.Clear();
            foreach (var item1 in espectaculos)
            {

                if (item1.EstadoEspectaculo)
                {
                    item1.Compania = new GetData().GetByIdCompañia(item1.Companiaid);
                    dgvRealizarCompra.Rows.Add(item1.NombreEspectaculo, item1.PrecioEspectaculo, item1.Id);
                }

            }
        }
        private void PrepareToPaint(object sender, PaintEventArgs e)
        {
            Control control = sender as Control;
            string sectorName = control.Text;
            int currentRow = dgvRealizarCompra.CurrentCell.RowIndex;
            long espectaculoId = long.Parse(dgvRealizarCompra.Rows[currentRow].Cells["Id"].Value.ToString());
            long sectorId = new GetData().GetByNameSectorId(control.Text);
            List<LocalidadAsiento> asientos = new Diccionario().GetAsientosDiccionarioByEspectaculoAndSector(sectorName, espectaculoId);
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
                    if (columnIndex + side <= groupBox.Width)
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

        private void DgvCellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (fila <= dgvRealizarCompra.RowCount - 2)
            {
                gbSA.Invalidate();
                gbSC.Invalidate();
            }
        }

        private void LblMetodopago_Click(object sender, EventArgs e)
        {
          
        }

        private void TxtBusquedaNombre_TextChanged(object sender, EventArgs e)
        {
            new PropsTexBox().txtBusquedaNombre_TextChanged(sender, e, txtBusquedaNombre, dgvRealizarCompra, "Nombre");
        }

        private void DgvRealizarCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int autoConvertToInt(string valor)
        {
            int descuento;
            double descuentoAux;
            if (valor == "")
            {
                descuento = 0;
            }
            else
            {
                descuentoAux = Math.Round(double.Parse(valor));
                descuento = int.Parse(descuentoAux.ToString());
            }
            return descuento;
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            CompraController compraC = new CompraController();
            LocalidadEspectaculo le = new LocalidadEspectaculo();
            Compra compra = new Compra();
            DialogResult result = MessageBox.Show("¿Está seguro de que desea realizar la compra?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            bool comrpasOK = true;
            long espectaculoId = long.Parse(dgvRealizarCompra.CurrentRow.Cells["Id"].Value.ToString());
            int descuento = autoConvertToInt(txtDescuento.Text.Replace("%", ""));
            if (result == DialogResult.Yes)
            {
                if (asientosSeleccionados.Count != 0)
                {
                    foreach (var item in asientosSeleccionados)
                    {
                        le.Sectorid = new GetData().GetSectorByAsiento(item).Id;
                        le.Espectaculoid = espectaculoId;
                        le.LocalidadAsientoid = new GetData().GetlocalidadAsientoByAsiento(int.Parse(item)).Id;
                        le.Precio = int.Parse(lblValorimporteTotal.Text.Replace("$",""));
                        le.Id = le.crearLocalidadEspectaculo(le);
                        compra.Unidades = 1;
                        compra.MetodoDePago = gbMetodopago.Text;
                        compra.Descuento = descuento;
                        compra.LocalidadEspectaculoid = le.Id;
                        compra.Espectaculoid = le.Espectaculoid;
                        compra.FechaHora = DateTime.Now;
                        compra.Cuentaid = ContLogin.GetInstance().UsuarioLogueadoid;
                        if (!compraC.realizarCompra(compra))
                        {
                            comrpasOK = false;
                        }
                        
                    }
                    if (comrpasOK)
                    {
                        MessageBox.Show("Compra realizada con exito");
                        Diccionario.GetInstance().actualizarDiccionario(asientosSeleccionados, espectaculoId);
                        asientosSeleccionados.Clear();
                        gbSA.Invalidate();
                        gbSC.Invalidate();
                    }              

                }
            }           
        }

        private void TxtCantidadAsientos_TextChanged(object sender, EventArgs e)
        {
            int aux;
            try
            {
                aux = int.Parse(txtCantidadAsientos.Text);
                if (aux < 1 || aux > 10)
                {
                    lblInfoCantidadAsientos.ForeColor = Color.Red;
                    lblInfoCantidadAsientos.Text = "Por favor ingrese un numero\ncomprendido entre 1 y 10";
                }
                else
                {
                    lblInfoCantidadAsientos.ForeColor = Color.Black;
                    lblInfoCantidadAsientos.Text = "Ingrese la cantidad de asientos (del 1 al 10)";
                }

            }
            catch (System.FormatException error)
            {
                lblInfoCantidadAsientos.ForeColor = Color.Red;
                lblInfoCantidadAsientos.Text = "Por favor ingrese un numero";
            }

        }

        private void TxtAsientosSeleccionados_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionAsientos_Click(object sender, EventArgs e)
        {
            float precio = 0;
            asientosSeleccionados.Clear();
            long espectaculoID = long.Parse(dgvRealizarCompra.CurrentRow.Cells["Id"].Value.ToString());
            bool asientosOK = true;
            List<string> asientosDisponibles = Diccionario.GetInstance().getAsientosDisponibles(espectaculoID);
            foreach (var item in txtAsientosSeleccionados.Text.Split(new char[] { ' ', ',', '.', '/', '-' }, StringSplitOptions.RemoveEmptyEntries))
            {
                AsientosSeleccionados.Add(item);
            }
            if (int.Parse(txtCantidadAsientos.Text) == AsientosSeleccionados.Count)
            {
                foreach (var asientoSeleccionado in AsientosSeleccionados)
                {
                    if (!asientosDisponibles.Contains(asientoSeleccionado))
                    {
                        lblInfoAsientosSelccionados.ForeColor = Color.Red;
                        lblInfoAsientosSelccionados.Text = "Uno o mas asientos seleccionados\nno estan disponibles";
                        asientosOK = false;
                        break;
                    }
                }
                if (asientosOK)
                {
                    string seleccionFinal = "";
                    foreach (var item in asientosSeleccionados)
                    {
                        seleccionFinal = seleccionFinal + " " + item.ToString();
                    }
                    lblInfoAsientosSelccionados.ForeColor = Color.Green;
                    lblInfoAsientosSelccionados.Text = $"Asientos{seleccionFinal} seleccionados";
                    precio = new GetData().calcularPrecio(asientosSeleccionados, espectaculoID);
                    lblValorimporte.Text = $"${precio}";
                }

            }
            else
            {
                lblInfoAsientosSelccionados.ForeColor = Color.Red;
                lblInfoAsientosSelccionados.Text = "La cantidad de asientos seleccionados\nno coincide";
            }
        }
        private void calcularPrecio()
        {
            if (gbMetodopago.Text == "Credito")
            {
                int subTotal = autoConvertToInt(lblValorimporte.Text.ToString().Replace("$", ""));
                double total = (subTotal + (subTotal * 0.1));
                double descuento;
                try
                {
                    descuento = (double.Parse(txtDescuento.Text.Replace("%", ""))) / 100;
                    total = (total - (total * descuento));
                    total = Math.Round(total);
                    lblValorimporteTotal.Text = $"${total}";
                    lblValorTotal.Text = $"${total}";

                }
                catch (System.FormatException e)
                {
                    total = Math.Round(total);
                    txtDescuento.Text = "%";
                    lblValorimporteTotal.Text = $"${total}";
                    lblValorTotal.Text = $"${total}";

                }

            }
            else
            {                
                int subTotal = autoConvertToInt(lblValorimporte.Text.ToString().Replace("$", ""));
                double total = subTotal;
                try
                {
                    double descuento = (double.Parse(txtDescuento.Text.Replace("%", "")))/100;                    
                    total = (total - (total * descuento));
                    total = Math.Round(total);
                    lblValorimporteTotal.Text = $"${total}";
                    lblValorTotal.Text = $"${total}";

                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("toy en cat ch");
                    total = Math.Round(total);
                    txtDescuento.Text = "%";
                    lblValorimporteTotal.Text = $"${total}";
                    lblValorTotal.Text = $"${total}";
                }

            }
        }

        private void gbMetodopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularPrecio();
        }

        private void lblValorimporte_TextChanged(object sender, EventArgs e)
        {
            calcularPrecio();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            calcularPrecio();
        }

        private void lblInfoAsientosSelccionados_Click(object sender, EventArgs e)
        {

        }

        private void RealizarCompras_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new MainMenuUser().Show();
            this.Close();
        }
    }
}
