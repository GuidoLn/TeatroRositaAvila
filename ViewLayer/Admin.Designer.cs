
namespace ProyectoFinal.ViewLayer
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_AdAUsuarios = new System.Windows.Forms.Button();
            this.bt_AdAAsientos = new System.Windows.Forms.Button();
            this.bt_AdEspectáculo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_AdALogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bievenido Gerente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(358, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 28, 0, 0, 0, 0);
            // 
            // bt_AdAUsuarios
            // 
            this.bt_AdAUsuarios.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_AdAUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bt_AdAUsuarios.Location = new System.Drawing.Point(56, 156);
            this.bt_AdAUsuarios.Name = "bt_AdAUsuarios";
            this.bt_AdAUsuarios.Size = new System.Drawing.Size(160, 45);
            this.bt_AdAUsuarios.TabIndex = 2;
            this.bt_AdAUsuarios.Text = "Usuarios";
            this.bt_AdAUsuarios.UseVisualStyleBackColor = false;
            this.bt_AdAUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_AdAAsientos
            // 
            this.bt_AdAAsientos.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_AdAAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bt_AdAAsientos.Location = new System.Drawing.Point(198, 237);
            this.bt_AdAAsientos.Name = "bt_AdAAsientos";
            this.bt_AdAAsientos.Size = new System.Drawing.Size(159, 45);
            this.bt_AdAAsientos.TabIndex = 4;
            this.bt_AdAAsientos.Text = "Asientos";
            this.bt_AdAAsientos.UseVisualStyleBackColor = false;
            this.bt_AdAAsientos.Click += new System.EventHandler(this.bt_AdAAsientos_Click);
            // 
            // bt_AdEspectáculo
            // 
            this.bt_AdEspectáculo.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_AdEspectáculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bt_AdEspectáculo.Location = new System.Drawing.Point(340, 156);
            this.bt_AdEspectáculo.Name = "bt_AdEspectáculo";
            this.bt_AdEspectáculo.Size = new System.Drawing.Size(201, 45);
            this.bt_AdEspectáculo.TabIndex = 5;
            this.bt_AdEspectáculo.Text = "Espectaculos";
            this.bt_AdEspectáculo.UseVisualStyleBackColor = false;
            this.bt_AdEspectáculo.Click += new System.EventHandler(this.bt_AdEspectáculo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.BackgroundImage = global::ProyectoFinal.Properties.Resources.seat;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(211, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 27);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BackgroundImage = global::ProyectoFinal.Properties.Resources.espectaculo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(355, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 27);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BackgroundImage = global::ProyectoFinal.Properties.Resources.usuario;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(67, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 27);
            this.panel1.TabIndex = 3;
            // 
            // bt_AdALogin
            // 
            this.bt_AdALogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_AdALogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bt_AdALogin.Location = new System.Drawing.Point(382, 360);
            this.bt_AdALogin.Name = "bt_AdALogin";
            this.bt_AdALogin.Size = new System.Drawing.Size(159, 37);
            this.bt_AdALogin.TabIndex = 6;
            this.bt_AdALogin.Text = "Cerrar Sesión";
            this.bt_AdALogin.UseVisualStyleBackColor = false;
            this.bt_AdALogin.Click += new System.EventHandler(this.bt_AdALogin_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.bt_AdALogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_AdEspectáculo);
            this.Controls.Add(this.bt_AdAAsientos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_AdAUsuarios);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_AdAUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_AdAAsientos;
        private System.Windows.Forms.Button bt_AdEspectáculo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_AdALogin;
    }
}