namespace ProyectoFinal.ViewLayer
{
    partial class AsientoGerente
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
            this.dgvAsientos = new System.Windows.Forms.DataGridView();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusquedaNombre = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.gbSC = new System.Windows.Forms.GroupBox();
            this.gbSA = new System.Windows.Forms.GroupBox();
            this.gbSD = new System.Windows.Forms.GroupBox();
            this.gbSB = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsientos
            // 
            this.dgvAsientos.AllowUserToAddRows = false;
            this.dgvAsientos.AllowUserToDeleteRows = false;
            this.dgvAsientos.AllowUserToOrderColumns = true;
            this.dgvAsientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsientos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsientos.Location = new System.Drawing.Point(12, 62);
            this.dgvAsientos.MultiSelect = false;
            this.dgvAsientos.Name = "dgvAsientos";
            this.dgvAsientos.ReadOnly = true;
            this.dgvAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsientos.Size = new System.Drawing.Size(1048, 150);
            this.dgvAsientos.TabIndex = 0;
            this.dgvAsientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsientos_CellContentClick);
            this.dgvAsientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellMouseClick);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBusqueda.Location = new System.Drawing.Point(31, 25);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(160, 20);
            this.lblBusqueda.TabIndex = 1;
            this.lblBusqueda.Text = "Buscar por funcion";
            // 
            // txtBusquedaNombre
            // 
            this.txtBusquedaNombre.Location = new System.Drawing.Point(197, 27);
            this.txtBusquedaNombre.Name = "txtBusquedaNombre";
            this.txtBusquedaNombre.Size = new System.Drawing.Size(163, 20);
            this.txtBusquedaNombre.TabIndex = 2;
            this.txtBusquedaNombre.WordWrap = false;
            this.txtBusquedaNombre.TextChanged += new System.EventHandler(this.txtBusquedaNombre_TextChanged);
            this.txtBusquedaNombre.Enter += new System.EventHandler(this.txtBusquedaNombre_Enter);
            this.txtBusquedaNombre.Leave += new System.EventHandler(this.txtBusquedaNombre_Leave);
            this.txtBusquedaNombre.MouseEnter += new System.EventHandler(this.txtBusquedaNombre_MouseEnter);
            this.txtBusquedaNombre.MouseLeave += new System.EventHandler(this.txtBusquedaNombre_MouseLeave);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAtras.Location = new System.Drawing.Point(920, 536);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(140, 37);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gbSC
            // 
            this.gbSC.Location = new System.Drawing.Point(218, 262);
            this.gbSC.Name = "gbSC";
            this.gbSC.Size = new System.Drawing.Size(669, 248);
            this.gbSC.TabIndex = 4;
            this.gbSC.TabStop = false;
            this.gbSC.Text = "Palco";
            this.gbSC.Paint += new System.Windows.Forms.PaintEventHandler(this.prepareToPaint);
            // 
            // gbSA
            // 
            this.gbSA.Location = new System.Drawing.Point(35, 262);
            this.gbSA.Name = "gbSA";
            this.gbSA.Size = new System.Drawing.Size(156, 248);
            this.gbSA.TabIndex = 4;
            this.gbSA.TabStop = false;
            this.gbSA.Text = "Platea Baja";
            this.gbSA.Paint += new System.Windows.Forms.PaintEventHandler(this.prepareToPaint);
            // 
            // gbSD
            // 
            this.gbSD.Location = new System.Drawing.Point(833, 252);
            this.gbSD.Name = "gbSD";
            this.gbSD.Size = new System.Drawing.Size(281, 258);
            this.gbSD.TabIndex = 4;
            this.gbSD.TabStop = false;
            this.gbSD.Text = "Palcos Altos";
            this.gbSD.Visible = false;
            this.gbSD.Paint += new System.Windows.Forms.PaintEventHandler(this.prepareToPaint);
            // 
            // gbSB
            // 
            this.gbSB.Location = new System.Drawing.Point(839, 252);
            this.gbSB.Name = "gbSB";
            this.gbSB.Size = new System.Drawing.Size(281, 124);
            this.gbSB.TabIndex = 4;
            this.gbSB.TabStop = false;
            this.gbSB.Text = "Gallinero";
            this.gbSB.Visible = false;
            this.gbSB.Paint += new System.Windows.Forms.PaintEventHandler(this.prepareToPaint);
            // 
            // AsientoGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 585);
            this.Controls.Add(this.gbSB);
            this.Controls.Add(this.gbSC);
            this.Controls.Add(this.gbSA);
            this.Controls.Add(this.gbSD);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtBusquedaNombre);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.dgvAsientos);
            this.Name = "AsientoGerente";
            this.Text = "AsientoGerente";
            this.Enter += new System.EventHandler(this.txtBusquedaNombre_Enter);
            this.Leave += new System.EventHandler(this.txtBusquedaNombre_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsientos;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusquedaNombre;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox gbSC;
        private System.Windows.Forms.GroupBox gbSA;
        private System.Windows.Forms.GroupBox gbSD;
        private System.Windows.Forms.GroupBox gbSB;
    }
}