namespace ProyectoFinal.ViewLayer
{
    partial class RealizarCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBusquedaNombre = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.dgvRealizarCompra = new System.Windows.Forms.DataGridView();
            this.gbSC = new System.Windows.Forms.GroupBox();
            this.gbSA = new System.Windows.Forms.GroupBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbCaja = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbllinea = new System.Windows.Forms.Label();
            this.lblValorCambio = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtValorRecibido = new System.Windows.Forms.TextBox();
            this.gbMetodopago = new System.Windows.Forms.ComboBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImporteRecibido = new System.Windows.Forms.Label();
            this.lblValorimporteTotal = new System.Windows.Forms.Label();
            this.lblImportetotal1 = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblValorimporte = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblMetodopago = new System.Windows.Forms.Label();
            this.lblCantidadAsientos = new System.Windows.Forms.Label();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.txtAsientosSeleccionados = new System.Windows.Forms.TextBox();
            this.txtCantidadAsientos = new System.Windows.Forms.TextBox();
            this.gbSeleccionAsientos = new System.Windows.Forms.GroupBox();
            this.btnSeleccionAsientos = new System.Windows.Forms.Button();
            this.lblInfoCantidadAsientos = new System.Windows.Forms.Label();
            this.lblInfoAsientosSelccionados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizarCompra)).BeginInit();
            this.gbCaja.SuspendLayout();
            this.gbSeleccionAsientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusquedaNombre
            // 
            this.txtBusquedaNombre.Location = new System.Drawing.Point(178, 11);
            this.txtBusquedaNombre.Name = "txtBusquedaNombre";
            this.txtBusquedaNombre.Size = new System.Drawing.Size(163, 20);
            this.txtBusquedaNombre.TabIndex = 4;
            this.txtBusquedaNombre.WordWrap = false;
            this.txtBusquedaNombre.TextChanged += new System.EventHandler(this.TxtBusquedaNombre_TextChanged);
            this.txtBusquedaNombre.Enter += new System.EventHandler(this.TxtBusquedaNombre_Enter);
            this.txtBusquedaNombre.Leave += new System.EventHandler(this.TxtBusquedaNombre_Leave);
            this.txtBusquedaNombre.MouseEnter += new System.EventHandler(this.TxtBusquedaNombre_MouseEnter);
            this.txtBusquedaNombre.MouseLeave += new System.EventHandler(this.TxtBusquedaNombre_MouseLeave);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBusqueda.Location = new System.Drawing.Point(12, 9);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(160, 20);
            this.lblBusqueda.TabIndex = 3;
            this.lblBusqueda.Text = "Buscar por funcion";
            // 
            // dgvRealizarCompra
            // 
            this.dgvRealizarCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRealizarCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRealizarCompra.Location = new System.Drawing.Point(16, 37);
            this.dgvRealizarCompra.Name = "dgvRealizarCompra";
            this.dgvRealizarCompra.ReadOnly = true;
            this.dgvRealizarCompra.RowHeadersWidth = 51;
            this.dgvRealizarCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRealizarCompra.Size = new System.Drawing.Size(678, 163);
            this.dgvRealizarCompra.TabIndex = 5;
            this.dgvRealizarCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCellMouseClick);
            this.dgvRealizarCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRealizarCompra_CellContentClick);
            // 
            // gbSC
            // 
            this.gbSC.Location = new System.Drawing.Point(199, 216);
            this.gbSC.Name = "gbSC";
            this.gbSC.Size = new System.Drawing.Size(495, 248);
            this.gbSC.TabIndex = 6;
            this.gbSC.TabStop = false;
            this.gbSC.Text = "Palco";
            this.gbSC.Paint += new System.Windows.Forms.PaintEventHandler(this.PrepareToPaint);
            // 
            // gbSA
            // 
            this.gbSA.Location = new System.Drawing.Point(16, 216);
            this.gbSA.Name = "gbSA";
            this.gbSA.Size = new System.Drawing.Size(156, 248);
            this.gbSA.TabIndex = 7;
            this.gbSA.TabStop = false;
            this.gbSA.Text = "Platea Baja";
            this.gbSA.Paint += new System.Windows.Forms.PaintEventHandler(this.PrepareToPaint);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnComprar.ForeColor = System.Drawing.Color.Black;
            this.btnComprar.Location = new System.Drawing.Point(1036, 500);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(1153, 500);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // gbCaja
            // 
            this.gbCaja.Controls.Add(this.label1);
            this.gbCaja.Controls.Add(this.lbllinea);
            this.gbCaja.Controls.Add(this.lblValorCambio);
            this.gbCaja.Controls.Add(this.lblCambio);
            this.gbCaja.Controls.Add(this.txtDescuento);
            this.gbCaja.Controls.Add(this.txtValorRecibido);
            this.gbCaja.Controls.Add(this.gbMetodopago);
            this.gbCaja.Controls.Add(this.lblValorTotal);
            this.gbCaja.Controls.Add(this.lblTotal);
            this.gbCaja.Controls.Add(this.lblImporteRecibido);
            this.gbCaja.Controls.Add(this.lblValorimporteTotal);
            this.gbCaja.Controls.Add(this.lblImportetotal1);
            this.gbCaja.Controls.Add(this.lblDescuento);
            this.gbCaja.Controls.Add(this.lblValorimporte);
            this.gbCaja.Controls.Add(this.lblSubtotal);
            this.gbCaja.Controls.Add(this.lblMetodopago);
            this.gbCaja.Location = new System.Drawing.Point(732, 226);
            this.gbCaja.Name = "gbCaja";
            this.gbCaja.Size = new System.Drawing.Size(520, 238);
            this.gbCaja.TabIndex = 10;
            this.gbCaja.TabStop = false;
            this.gbCaja.Text = "Caja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(302, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "---------------------------------------------------";
            // 
            // lbllinea
            // 
            this.lbllinea.AutoSize = true;
            this.lbllinea.ForeColor = System.Drawing.Color.Black;
            this.lbllinea.Location = new System.Drawing.Point(10, 53);
            this.lbllinea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllinea.Name = "lbllinea";
            this.lbllinea.Size = new System.Drawing.Size(391, 13);
            this.lbllinea.TabIndex = 6;
            this.lbllinea.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------";
            // 
            // lblValorCambio
            // 
            this.lblValorCambio.AutoSize = true;
            this.lblValorCambio.Location = new System.Drawing.Point(394, 177);
            this.lblValorCambio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorCambio.Name = "lblValorCambio";
            this.lblValorCambio.Size = new System.Drawing.Size(13, 13);
            this.lblValorCambio.TabIndex = 5;
            this.lblValorCambio.Text = "$";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(302, 177);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(45, 13);
            this.lblCambio.TabIndex = 4;
            this.lblCambio.Text = "Cambio:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDescuento.Location = new System.Drawing.Point(86, 128);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 3;
            this.txtDescuento.Text = "%";
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // txtValorRecibido
            // 
            this.txtValorRecibido.Location = new System.Drawing.Point(397, 86);
            this.txtValorRecibido.Name = "txtValorRecibido";
            this.txtValorRecibido.Size = new System.Drawing.Size(100, 20);
            this.txtValorRecibido.TabIndex = 2;
            this.txtValorRecibido.Text = "$";
            // 
            // gbMetodopago
            // 
            this.gbMetodopago.FormattingEnabled = true;
            this.gbMetodopago.Items.AddRange(new object[] {
            "Efectivo",
            "Debito",
            "Credito"});
            this.gbMetodopago.Location = new System.Drawing.Point(86, 30);
            this.gbMetodopago.Name = "gbMetodopago";
            this.gbMetodopago.Size = new System.Drawing.Size(121, 21);
            this.gbMetodopago.TabIndex = 1;
            this.gbMetodopago.Text = "Efectivo";
            this.gbMetodopago.SelectedIndexChanged += new System.EventHandler(this.gbMetodopago_SelectedIndexChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(394, 140);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(13, 13);
            this.lblValorTotal.TabIndex = 0;
            this.lblValorTotal.Text = "$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(302, 140);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // lblImporteRecibido
            // 
            this.lblImporteRecibido.AutoSize = true;
            this.lblImporteRecibido.Location = new System.Drawing.Point(302, 89);
            this.lblImporteRecibido.Name = "lblImporteRecibido";
            this.lblImporteRecibido.Size = new System.Drawing.Size(90, 13);
            this.lblImporteRecibido.TabIndex = 0;
            this.lblImporteRecibido.Text = "Importe Recibido:";
            // 
            // lblValorimporteTotal
            // 
            this.lblValorimporteTotal.AutoSize = true;
            this.lblValorimporteTotal.Location = new System.Drawing.Point(84, 177);
            this.lblValorimporteTotal.Name = "lblValorimporteTotal";
            this.lblValorimporteTotal.Size = new System.Drawing.Size(13, 13);
            this.lblValorimporteTotal.TabIndex = 0;
            this.lblValorimporteTotal.Text = "$";
            // 
            // lblImportetotal1
            // 
            this.lblImportetotal1.AutoSize = true;
            this.lblImportetotal1.Location = new System.Drawing.Point(6, 177);
            this.lblImportetotal1.Name = "lblImportetotal1";
            this.lblImportetotal1.Size = new System.Drawing.Size(72, 13);
            this.lblImportetotal1.TabIndex = 0;
            this.lblImportetotal1.Text = "Importe Total:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(6, 132);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 0;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblValorimporte
            // 
            this.lblValorimporte.AutoSize = true;
            this.lblValorimporte.Location = new System.Drawing.Point(99, 94);
            this.lblValorimporte.Name = "lblValorimporte";
            this.lblValorimporte.Size = new System.Drawing.Size(13, 13);
            this.lblValorimporte.TabIndex = 0;
            this.lblValorimporte.Text = "$";
            this.lblValorimporte.TextChanged += new System.EventHandler(this.lblValorimporte_TextChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(6, 94);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(87, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Importe Subtotal:";
            // 
            // lblMetodopago
            // 
            this.lblMetodopago.AutoSize = true;
            this.lblMetodopago.Location = new System.Drawing.Point(6, 32);
            this.lblMetodopago.Name = "lblMetodopago";
            this.lblMetodopago.Size = new System.Drawing.Size(79, 13);
            this.lblMetodopago.TabIndex = 0;
            this.lblMetodopago.Text = "Forma de Pago";
            this.lblMetodopago.Click += new System.EventHandler(this.LblMetodopago_Click);
            // 
            // lblCantidadAsientos
            // 
            this.lblCantidadAsientos.AutoSize = true;
            this.lblCantidadAsientos.Location = new System.Drawing.Point(17, 35);
            this.lblCantidadAsientos.Name = "lblCantidadAsientos";
            this.lblCantidadAsientos.Size = new System.Drawing.Size(156, 13);
            this.lblCantidadAsientos.TabIndex = 11;
            this.lblCantidadAsientos.Text = "Cuantos asientos va a comprar:";
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Location = new System.Drawing.Point(17, 89);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(87, 13);
            this.lblAsientos.TabIndex = 11;
            this.lblAsientos.Text = "Ingrese asientos:";
            // 
            // txtAsientosSeleccionados
            // 
            this.txtAsientosSeleccionados.Location = new System.Drawing.Point(179, 86);
            this.txtAsientosSeleccionados.Name = "txtAsientosSeleccionados";
            this.txtAsientosSeleccionados.Size = new System.Drawing.Size(100, 20);
            this.txtAsientosSeleccionados.TabIndex = 13;
            this.txtAsientosSeleccionados.TextChanged += new System.EventHandler(this.TxtAsientosSeleccionados_TextChanged);
            // 
            // txtCantidadAsientos
            // 
            this.txtCantidadAsientos.Location = new System.Drawing.Point(179, 35);
            this.txtCantidadAsientos.Name = "txtCantidadAsientos";
            this.txtCantidadAsientos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAsientos.TabIndex = 13;
            this.txtCantidadAsientos.Text = "1";
            this.txtCantidadAsientos.TextChanged += new System.EventHandler(this.TxtCantidadAsientos_TextChanged);
            // 
            // gbSeleccionAsientos
            // 
            this.gbSeleccionAsientos.Controls.Add(this.btnSeleccionAsientos);
            this.gbSeleccionAsientos.Controls.Add(this.lblInfoCantidadAsientos);
            this.gbSeleccionAsientos.Controls.Add(this.lblInfoAsientosSelccionados);
            this.gbSeleccionAsientos.Controls.Add(this.lblCantidadAsientos);
            this.gbSeleccionAsientos.Controls.Add(this.txtCantidadAsientos);
            this.gbSeleccionAsientos.Controls.Add(this.lblAsientos);
            this.gbSeleccionAsientos.Controls.Add(this.txtAsientosSeleccionados);
            this.gbSeleccionAsientos.Location = new System.Drawing.Point(732, 37);
            this.gbSeleccionAsientos.Name = "gbSeleccionAsientos";
            this.gbSeleccionAsientos.Size = new System.Drawing.Size(520, 183);
            this.gbSeleccionAsientos.TabIndex = 14;
            this.gbSeleccionAsientos.TabStop = false;
            this.gbSeleccionAsientos.Text = "Asientos";
            // 
            // btnSeleccionAsientos
            // 
            this.btnSeleccionAsientos.Location = new System.Drawing.Point(304, 84);
            this.btnSeleccionAsientos.Name = "btnSeleccionAsientos";
            this.btnSeleccionAsientos.Size = new System.Drawing.Size(144, 23);
            this.btnSeleccionAsientos.TabIndex = 16;
            this.btnSeleccionAsientos.Text = "Seleccionar Asientos";
            this.btnSeleccionAsientos.UseVisualStyleBackColor = true;
            this.btnSeleccionAsientos.Click += new System.EventHandler(this.BtnSeleccionAsientos_Click);
            // 
            // lblInfoCantidadAsientos
            // 
            this.lblInfoCantidadAsientos.AutoSize = true;
            this.lblInfoCantidadAsientos.Location = new System.Drawing.Point(285, 35);
            this.lblInfoCantidadAsientos.Name = "lblInfoCantidadAsientos";
            this.lblInfoCantidadAsientos.Size = new System.Drawing.Size(212, 13);
            this.lblInfoCantidadAsientos.TabIndex = 15;
            this.lblInfoCantidadAsientos.Text = "Ingrese la cantidad de asientos (del 1 al 10)";
            // 
            // lblInfoAsientosSelccionados
            // 
            this.lblInfoAsientosSelccionados.AutoSize = true;
            this.lblInfoAsientosSelccionados.Location = new System.Drawing.Point(18, 128);
            this.lblInfoAsientosSelccionados.Name = "lblInfoAsientosSelccionados";
            this.lblInfoAsientosSelccionados.Size = new System.Drawing.Size(16, 13);
            this.lblInfoAsientosSelccionados.TabIndex = 14;
            this.lblInfoAsientosSelccionados.Text = "   ";
            this.lblInfoAsientosSelccionados.Click += new System.EventHandler(this.lblInfoAsientosSelccionados_Click);
            // 
            // RealizarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 556);
            this.Controls.Add(this.gbSeleccionAsientos);
            this.Controls.Add(this.gbCaja);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.gbSC);
            this.Controls.Add(this.gbSA);
            this.Controls.Add(this.dgvRealizarCompra);
            this.Controls.Add(this.txtBusquedaNombre);
            this.Controls.Add(this.lblBusqueda);
            this.Name = "RealizarCompras";
            this.Text = "RealizarCompras";
            this.Load += new System.EventHandler(this.RealizarCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizarCompra)).EndInit();
            this.gbCaja.ResumeLayout(false);
            this.gbCaja.PerformLayout();
            this.gbSeleccionAsientos.ResumeLayout(false);
            this.gbSeleccionAsientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedaNombre;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridView dgvRealizarCompra;
        private System.Windows.Forms.GroupBox gbSC;
        private System.Windows.Forms.GroupBox gbSA;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbCaja;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtValorRecibido;
        private System.Windows.Forms.ComboBox gbMetodopago;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImporteRecibido;
        private System.Windows.Forms.Label lblValorimporteTotal;
        private System.Windows.Forms.Label lblImportetotal1;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblValorimporte;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblMetodopago;
        private System.Windows.Forms.Label lblValorCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbllinea;
        private System.Windows.Forms.Label lblCantidadAsientos;
        private System.Windows.Forms.Label lblAsientos;
        private System.Windows.Forms.TextBox txtAsientosSeleccionados;
        private System.Windows.Forms.TextBox txtCantidadAsientos;
        private System.Windows.Forms.GroupBox gbSeleccionAsientos;
        private System.Windows.Forms.Label lblInfoAsientosSelccionados;
        private System.Windows.Forms.Label lblInfoCantidadAsientos;
        private System.Windows.Forms.Button btnSeleccionAsientos;
    }
}