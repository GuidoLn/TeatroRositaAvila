namespace ProyectoFinal.ViewLayer
{
    partial class MainMenuUser
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnEspectaculos = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWelcome.Location = new System.Drawing.Point(32, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(229, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenido Usuario ";
            // 
            // btnEntradas
            // 
            this.btnEntradas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEntradas.Location = new System.Drawing.Point(147, 96);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(213, 45);
            this.btnEntradas.TabIndex = 3;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.UseVisualStyleBackColor = false;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnEspectaculos
            // 
            this.btnEspectaculos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEspectaculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEspectaculos.Location = new System.Drawing.Point(147, 180);
            this.btnEspectaculos.Name = "btnEspectaculos";
            this.btnEspectaculos.Size = new System.Drawing.Size(213, 45);
            this.btnEspectaculos.TabIndex = 3;
            this.btnEspectaculos.Text = "Espectaculos";
            this.btnEspectaculos.UseVisualStyleBackColor = false;
            this.btnEspectaculos.Click += new System.EventHandler(this.btnEspectaculos_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCompras.Location = new System.Drawing.Point(147, 265);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(213, 45);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras Realizadas";
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(333, 373);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 45);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Cerrar Sesion";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainMenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 430);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnEspectaculos);
            this.Controls.Add(this.btnEntradas);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainMenuUser";
            this.Text = "MainMenuUser";
            this.Load += new System.EventHandler(this.MainMenuUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnEspectaculos;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnLogout;
    }
}