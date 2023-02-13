
namespace ProyectoFinal.ViewLayer
{
    partial class ABMLUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGUsuarios = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pAgregadoUsuario = new System.Windows.Forms.Panel();
            this.pUsEliminar = new System.Windows.Forms.Panel();
            this.btnUsEliminarNo = new System.Windows.Forms.Button();
            this.btnUsEliminarOk = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbUsEliminarClave = new System.Windows.Forms.Label();
            this.lbUsEliminarId = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUsMenu = new System.Windows.Forms.Button();
            this.btnUsAtras = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbUsAgregagoClave = new System.Windows.Forms.Label();
            this.lbUsAgregagoId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnUsToMenu = new System.Windows.Forms.Button();
            this.tbBusqUsuario = new System.Windows.Forms.TextBox();
            this.btnBusqUsuario = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.pAgregadoUsuario.SuspendLayout();
            this.pUsEliminar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(21, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 355);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DGUsuarios
            // 
            this.DGUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsuarios.Location = new System.Drawing.Point(9, 26);
            this.DGUsuarios.MultiSelect = false;
            this.DGUsuarios.Name = "DGUsuarios";
            this.DGUsuarios.ReadOnly = true;
            this.DGUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGUsuarios.Size = new System.Drawing.Size(278, 309);
            this.DGUsuarios.TabIndex = 0;
            this.DGUsuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGUsuarios_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.tbTipoUsuario);
            this.panel2.Controls.Add(this.tbIdUsuario);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbEmail);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbClave);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbTelefono);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbDNI);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbNombreApellido);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbUsuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(372, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 303);
            this.panel2.TabIndex = 1;
            // 
            // tbTipoUsuario
            // 
            this.tbTipoUsuario.FormattingEnabled = true;
            this.tbTipoUsuario.Items.AddRange(new object[] {
            "admin",
            "empleado"});
            this.tbTipoUsuario.Location = new System.Drawing.Point(193, 104);
            this.tbTipoUsuario.Name = "tbTipoUsuario";
            this.tbTipoUsuario.Size = new System.Drawing.Size(142, 21);
            this.tbTipoUsuario.TabIndex = 15;
            this.tbTipoUsuario.Text = "Permisos";
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Location = new System.Drawing.Point(109, 0);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(142, 20);
            this.tbIdUsuario.TabIndex = 14;
            this.tbIdUsuario.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(54, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de Usuario*";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(193, 258);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(142, 20);
            this.tbEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(137, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mail";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(193, 67);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(142, 20);
            this.tbClave.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(45, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clave de Usuario*";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(193, 219);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(142, 20);
            this.tbTelefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(105, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(193, 181);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(142, 20);
            this.tbDNI.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(129, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "D.N.I*";
            // 
            // tbNombreApellido
            // 
            this.tbNombreApellido.Location = new System.Drawing.Point(193, 142);
            this.tbNombreApellido.Name = "tbNombreApellido";
            this.tbNombreApellido.Size = new System.Drawing.Size(142, 20);
            this.tbNombreApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(38, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre y Apellido*";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(193, 29);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(142, 20);
            this.tbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad de Usuario*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pAgregadoUsuario
            // 
            this.pAgregadoUsuario.Controls.Add(this.btnUsMenu);
            this.pAgregadoUsuario.Controls.Add(this.btnUsAtras);
            this.pAgregadoUsuario.Controls.Add(this.label8);
            this.pAgregadoUsuario.Controls.Add(this.panel4);
            this.pAgregadoUsuario.Controls.Add(this.panel5);
            this.pAgregadoUsuario.Controls.Add(this.pUsEliminar);
            this.pAgregadoUsuario.Location = new System.Drawing.Point(21, 90);
            this.pAgregadoUsuario.Name = "pAgregadoUsuario";
            this.pAgregadoUsuario.Size = new System.Drawing.Size(737, 412);
            this.pAgregadoUsuario.TabIndex = 6;
            this.pAgregadoUsuario.Visible = false;
            // 
            // pUsEliminar
            // 
            this.pUsEliminar.Controls.Add(this.btnUsEliminarNo);
            this.pUsEliminar.Controls.Add(this.btnUsEliminarOk);
            this.pUsEliminar.Controls.Add(this.panel8);
            this.pUsEliminar.Controls.Add(this.label11);
            this.pUsEliminar.Controls.Add(this.panel3);
            this.pUsEliminar.Location = new System.Drawing.Point(0, 0);
            this.pUsEliminar.Name = "pUsEliminar";
            this.pUsEliminar.Size = new System.Drawing.Size(746, 424);
            this.pUsEliminar.TabIndex = 5;
            this.pUsEliminar.Visible = false;
            // 
            // btnUsEliminarNo
            // 
            this.btnUsEliminarNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUsEliminarNo.Location = new System.Drawing.Point(373, 308);
            this.btnUsEliminarNo.Name = "btnUsEliminarNo";
            this.btnUsEliminarNo.Size = new System.Drawing.Size(129, 37);
            this.btnUsEliminarNo.TabIndex = 4;
            this.btnUsEliminarNo.Text = "Cancelar";
            this.btnUsEliminarNo.UseVisualStyleBackColor = true;
            this.btnUsEliminarNo.Click += new System.EventHandler(this.btnUsEliminarNo_Click);
            // 
            // btnUsEliminarOk
            // 
            this.btnUsEliminarOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUsEliminarOk.Location = new System.Drawing.Point(216, 308);
            this.btnUsEliminarOk.Name = "btnUsEliminarOk";
            this.btnUsEliminarOk.Size = new System.Drawing.Size(129, 37);
            this.btnUsEliminarOk.TabIndex = 3;
            this.btnUsEliminarOk.Text = "Confirmar";
            this.btnUsEliminarOk.UseVisualStyleBackColor = true;
            this.btnUsEliminarOk.Click += new System.EventHandler(this.btnUsEliminarOk_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel8.Controls.Add(this.lbUsEliminarClave);
            this.panel8.Controls.Add(this.lbUsEliminarId);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(335, 159);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(267, 125);
            this.panel8.TabIndex = 2;
            // 
            // lbUsEliminarClave
            // 
            this.lbUsEliminarClave.AutoSize = true;
            this.lbUsEliminarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbUsEliminarClave.Location = new System.Drawing.Point(121, 73);
            this.lbUsEliminarClave.Name = "lbUsEliminarClave";
            this.lbUsEliminarClave.Size = new System.Drawing.Size(85, 20);
            this.lbUsEliminarClave.TabIndex = 3;
            this.lbUsEliminarClave.Text = "tuCalle123";
            // 
            // lbUsEliminarId
            // 
            this.lbUsEliminarId.AutoSize = true;
            this.lbUsEliminarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbUsEliminarId.Location = new System.Drawing.Point(121, 25);
            this.lbUsEliminarId.Name = "lbUsEliminarId";
            this.lbUsEliminarId.Size = new System.Drawing.Size(103, 20);
            this.lbUsEliminarId.TabIndex = 2;
            this.lbUsEliminarId.Text = "Julio Petralca";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(34, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Clave :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(34, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label11.Location = new System.Drawing.Point(115, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(487, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "¿Esta seguro que desea eliminar al usuario?";
            // 
            // btnUsMenu
            // 
            this.btnUsMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUsMenu.Location = new System.Drawing.Point(443, 315);
            this.btnUsMenu.Name = "btnUsMenu";
            this.btnUsMenu.Size = new System.Drawing.Size(181, 34);
            this.btnUsMenu.TabIndex = 4;
            this.btnUsMenu.Text = "Menu Principal";
            this.btnUsMenu.UseVisualStyleBackColor = true;
            this.btnUsMenu.Click += new System.EventHandler(this.btnUsMenu_Click);
            // 
            // btnUsAtras
            // 
            this.btnUsAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUsAtras.Location = new System.Drawing.Point(646, 315);
            this.btnUsAtras.Name = "btnUsAtras";
            this.btnUsAtras.Size = new System.Drawing.Size(87, 34);
            this.btnUsAtras.TabIndex = 3;
            this.btnUsAtras.Text = "Atras";
            this.btnUsAtras.UseVisualStyleBackColor = true;
            this.btnUsAtras.Click += new System.EventHandler(this.btnUsAtras_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(131, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(429, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "USUARIO REGISTRADO CON EXITO!";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.lbUsAgregagoClave);
            this.panel5.Controls.Add(this.lbUsAgregagoId);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(305, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 153);
            this.panel5.TabIndex = 1;
            // 
            // lbUsAgregagoClave
            // 
            this.lbUsAgregagoClave.AutoSize = true;
            this.lbUsAgregagoClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbUsAgregagoClave.Location = new System.Drawing.Point(135, 95);
            this.lbUsAgregagoClave.Name = "lbUsAgregagoClave";
            this.lbUsAgregagoClave.Size = new System.Drawing.Size(139, 29);
            this.lbUsAgregagoClave.TabIndex = 3;
            this.lbUsAgregagoClave.Text = "PedroMe56";
            // 
            // lbUsAgregagoId
            // 
            this.lbUsAgregagoId.AutoSize = true;
            this.lbUsAgregagoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbUsAgregagoId.Location = new System.Drawing.Point(135, 31);
            this.lbUsAgregagoId.Name = "lbUsAgregagoId";
            this.lbUsAgregagoId.Size = new System.Drawing.Size(175, 29);
            this.lbUsAgregagoId.TabIndex = 2;
            this.lbUsAgregagoId.Text = "Roberto Carloz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label10.Location = new System.Drawing.Point(25, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Clave:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.Location = new System.Drawing.Point(27, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Usuario:";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarUsuario.Location = new System.Drawing.Point(601, 38);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(126, 30);
            this.btnAgregarUsuario.TabIndex = 2;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminarUsuario.Location = new System.Drawing.Point(601, 412);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(126, 30);
            this.btnEliminarUsuario.TabIndex = 4;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModificarUsuario.Location = new System.Drawing.Point(455, 412);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(126, 30);
            this.btnModificarUsuario.TabIndex = 5;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnUsToMenu
            // 
            this.btnUsToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUsToMenu.Location = new System.Drawing.Point(305, 456);
            this.btnUsToMenu.Name = "btnUsToMenu";
            this.btnUsToMenu.Size = new System.Drawing.Size(185, 44);
            this.btnUsToMenu.TabIndex = 7;
            this.btnUsToMenu.Text = "Ir al Menu Principal";
            this.btnUsToMenu.UseVisualStyleBackColor = true;
            this.btnUsToMenu.Click += new System.EventHandler(this.btnUsToMenu_Click);
            // 
            // tbBusqUsuario
            // 
            this.tbBusqUsuario.Location = new System.Drawing.Point(21, 48);
            this.tbBusqUsuario.Name = "tbBusqUsuario";
            this.tbBusqUsuario.Size = new System.Drawing.Size(142, 20);
            this.tbBusqUsuario.TabIndex = 15;
            // 
            // btnBusqUsuario
            // 
            this.btnBusqUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBusqUsuario.Location = new System.Drawing.Point(182, 41);
            this.btnBusqUsuario.Name = "btnBusqUsuario";
            this.btnBusqUsuario.Size = new System.Drawing.Size(163, 30);
            this.btnBusqUsuario.TabIndex = 16;
            this.btnBusqUsuario.Text = "Buscar por Usuario";
            this.btnBusqUsuario.UseVisualStyleBackColor = true;
            this.btnBusqUsuario.Click += new System.EventHandler(this.btnBusqUsuario_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ProyectoFinal.Properties.Resources.usuario;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(116, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 125);
            this.panel3.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::ProyectoFinal.Properties.Resources.x;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(124, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(69, 52);
            this.panel7.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ProyectoFinal.Properties.Resources.usuario;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(54, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 137);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::ProyectoFinal.Properties.Resources.kisspng_chroma_key_check_mark_tilde_symbol_green_tick_5ac32c3e1d4770_2128125115227402861199;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(148, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(71, 52);
            this.panel6.TabIndex = 1;
            // 
            // ABMLUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pAgregadoUsuario);
            this.Controls.Add(this.btnUsToMenu);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnBusqUsuario);
            this.Controls.Add(this.tbBusqUsuario);
            this.Name = "ABMLUsuarios";
            this.Text = "ABMLUsuarios";
            this.Load += new System.EventHandler(this.ABMLUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pAgregadoUsuario.ResumeLayout(false);
            this.pAgregadoUsuario.PerformLayout();
            this.pUsEliminar.ResumeLayout(false);
            this.pUsEliminar.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.TextBox tbIdUsuario;
        private System.Windows.Forms.Panel pAgregadoUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUsMenu;
        private System.Windows.Forms.Button btnUsAtras;
        private System.Windows.Forms.Label lbUsAgregagoClave;
        private System.Windows.Forms.Label lbUsAgregagoId;
        private System.Windows.Forms.Panel pUsEliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUsEliminarNo;
        private System.Windows.Forms.Button btnUsEliminarOk;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbUsEliminarClave;
        private System.Windows.Forms.Label lbUsEliminarId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUsToMenu;
        private System.Windows.Forms.TextBox tbBusqUsuario;
        private System.Windows.Forms.Button btnBusqUsuario;
        private System.Windows.Forms.ComboBox tbTipoUsuario;
    }
}