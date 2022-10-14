namespace PayRollManagementSystemV1
{
    partial class AdministradorView
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
            System.Windows.Forms.DateTimePicker dtpEntrada;
            this.tabAdministrador = new System.Windows.Forms.TabControl();
            this.tabEmpleados = new System.Windows.Forms.TabPage();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbRolUsuario = new System.Windows.Forms.ComboBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarAdministradorView = new System.Windows.Forms.Button();
            this.btnCerrarSesionAdministrador = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditarEmpleado = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtprueba = new System.Windows.Forms.TextBox();
            dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.tabAdministrador.SuspendLayout();
            this.tabEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEntrada
            // 
            dtpEntrada.CustomFormat = "";
            dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpEntrada.ImeMode = System.Windows.Forms.ImeMode.Off;
            dtpEntrada.Location = new System.Drawing.Point(827, 26);
            dtpEntrada.Name = "dtpEntrada";
            dtpEntrada.Size = new System.Drawing.Size(110, 21);
            dtpEntrada.TabIndex = 15;
            dtpEntrada.ValueChanged += new System.EventHandler(this.dtpEntrada_ValueChanged);
            // 
            // tabAdministrador
            // 
            this.tabAdministrador.Controls.Add(this.tabEmpleados);
            this.tabAdministrador.Controls.Add(this.tabUsuarios);
            this.tabAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdministrador.Location = new System.Drawing.Point(12, 108);
            this.tabAdministrador.Name = "tabAdministrador";
            this.tabAdministrador.SelectedIndex = 0;
            this.tabAdministrador.Size = new System.Drawing.Size(1076, 480);
            this.tabAdministrador.TabIndex = 0;
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.Controls.Add(this.btnGuardarEmpleado);
            this.tabEmpleados.Controls.Add(this.label9);
            this.tabEmpleados.Controls.Add(dtpEntrada);
            this.tabEmpleados.Controls.Add(this.label8);
            this.tabEmpleados.Controls.Add(this.txtSalarioBruto);
            this.tabEmpleados.Controls.Add(this.label7);
            this.tabEmpleados.Controls.Add(this.txtEmail);
            this.tabEmpleados.Controls.Add(this.label6);
            this.tabEmpleados.Controls.Add(this.txtCedula);
            this.tabEmpleados.Controls.Add(this.label5);
            this.tabEmpleados.Controls.Add(this.txtTelefono);
            this.tabEmpleados.Controls.Add(this.txtCargo);
            this.tabEmpleados.Controls.Add(this.label4);
            this.tabEmpleados.Controls.Add(this.txtApellido);
            this.tabEmpleados.Controls.Add(this.txtNombre);
            this.tabEmpleados.Controls.Add(this.label3);
            this.tabEmpleados.Controls.Add(this.label2);
            this.tabEmpleados.Controls.Add(this.dgvEmpleados);
            this.tabEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabEmpleados.Location = new System.Drawing.Point(4, 24);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpleados.Size = new System.Drawing.Size(1068, 452);
            this.tabEmpleados.TabIndex = 0;
            this.tabEmpleados.Text = "Empleados";
            this.tabEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.BackgroundImage = global::PayRollManagementSystemV1.Properties.Resources.guardar_el_archivo;
            this.btnGuardarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnGuardarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(1015, 15);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(32, 32);
            this.btnGuardarEmpleado.TabIndex = 7;
            this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.Agregar_Empleado);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label9.Location = new System.Drawing.Point(824, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha de Entrada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label8.Location = new System.Drawing.Point(708, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salario Bruto";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtSalarioBruto.Location = new System.Drawing.Point(711, 23);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(110, 24);
            this.txtSalarioBruto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label7.Location = new System.Drawing.Point(592, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtEmail.Location = new System.Drawing.Point(595, 23);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(110, 24);
            this.txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label6.Location = new System.Drawing.Point(476, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtCedula.Location = new System.Drawing.Point(479, 23);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(110, 24);
            this.txtCedula.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label5.Location = new System.Drawing.Point(360, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtTelefono.Location = new System.Drawing.Point(363, 23);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(110, 24);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtCargo.Location = new System.Drawing.Point(247, 23);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(110, 24);
            this.txtCargo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label4.Location = new System.Drawing.Point(244, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cargo";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtApellido.Location = new System.Drawing.Point(128, 23);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(110, 24);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtNombre.Location = new System.Drawing.Point(9, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 24);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label3.Location = new System.Drawing.Point(125, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditarEmpleado});
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 90);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(1056, 341);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.tabUsuarios.Controls.Add(this.btnGuardarUsuario);
            this.tabUsuarios.Controls.Add(this.dvgUsuarios);
            this.tabUsuarios.Controls.Add(this.label13);
            this.tabUsuarios.Controls.Add(this.cbbRolUsuario);
            this.tabUsuarios.Controls.Add(this.txtIdEmpleado);
            this.tabUsuarios.Controls.Add(this.label12);
            this.tabUsuarios.Controls.Add(this.txtContrasena);
            this.tabUsuarios.Controls.Add(this.label11);
            this.tabUsuarios.Controls.Add(this.txtNombreUsuario);
            this.tabUsuarios.Controls.Add(this.label10);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 24);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(1068, 452);
            this.tabUsuarios.TabIndex = 1;
            this.tabUsuarios.Text = "Usuarios";
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.AllowUserToAddRows = false;
            this.dvgUsuarios.AllowUserToDeleteRows = false;
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditarUsuario});
            this.dvgUsuarios.Location = new System.Drawing.Point(22, 76);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.ReadOnly = true;
            this.dvgUsuarios.Size = new System.Drawing.Size(1021, 360);
            this.dvgUsuarios.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label13.Location = new System.Drawing.Point(291, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Rol Usuario";
            // 
            // cbbRolUsuario
            // 
            this.cbbRolUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.cbbRolUsuario.FormattingEnabled = true;
            this.cbbRolUsuario.Location = new System.Drawing.Point(294, 31);
            this.cbbRolUsuario.Name = "cbbRolUsuario";
            this.cbbRolUsuario.Size = new System.Drawing.Size(130, 23);
            this.cbbRolUsuario.TabIndex = 10;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtIdEmpleado.Location = new System.Drawing.Point(430, 30);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(130, 24);
            this.txtIdEmpleado.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label12.Location = new System.Drawing.Point(427, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Id Empleado";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtContrasena.Location = new System.Drawing.Point(158, 30);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(130, 24);
            this.txtContrasena.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label11.Location = new System.Drawing.Point(158, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Contraseña";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtNombreUsuario.Location = new System.Drawing.Point(22, 30);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(130, 24);
            this.txtNombreUsuario.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.label10.Location = new System.Drawing.Point(19, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nombre de Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMINISTRADOR";
            // 
            // btnCerrarAdministradorView
            // 
            this.btnCerrarAdministradorView.BackgroundImage = global::PayRollManagementSystemV1.Properties.Resources.BtnClose;
            this.btnCerrarAdministradorView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarAdministradorView.FlatAppearance.BorderSize = 0;
            this.btnCerrarAdministradorView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAdministradorView.Location = new System.Drawing.Point(1056, 9);
            this.btnCerrarAdministradorView.Name = "btnCerrarAdministradorView";
            this.btnCerrarAdministradorView.Size = new System.Drawing.Size(32, 32);
            this.btnCerrarAdministradorView.TabIndex = 5;
            this.btnCerrarAdministradorView.UseVisualStyleBackColor = true;
            this.btnCerrarAdministradorView.Click += new System.EventHandler(this.Cerrar_Ventana_AdministradorView);
            // 
            // btnCerrarSesionAdministrador
            // 
            this.btnCerrarSesionAdministrador.BackgroundImage = global::PayRollManagementSystemV1.Properties.Resources.logout;
            this.btnCerrarSesionAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarSesionAdministrador.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesionAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesionAdministrador.Location = new System.Drawing.Point(1018, 9);
            this.btnCerrarSesionAdministrador.Name = "btnCerrarSesionAdministrador";
            this.btnCerrarSesionAdministrador.Size = new System.Drawing.Size(32, 32);
            this.btnCerrarSesionAdministrador.TabIndex = 6;
            this.btnCerrarSesionAdministrador.UseVisualStyleBackColor = true;
            this.btnCerrarSesionAdministrador.Click += new System.EventHandler(this.Salis_Sesion_AdministradorView);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.BackgroundImage = global::PayRollManagementSystemV1.Properties.Resources.guardar_el_archivo;
            this.btnGuardarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarUsuario.FlatAppearance.BorderSize = 0;
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(1011, 10);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(32, 32);
            this.btnGuardarUsuario.TabIndex = 13;
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.Agregar_Usuario);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.HeaderText = "Editar";
            this.btnEditarUsuario.Image = global::PayRollManagementSystemV1.Properties.Resources.editar;
            this.btnEditarUsuario.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEditarUsuario.MinimumWidth = 10;
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.ReadOnly = true;
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.HeaderText = "Editar";
            this.btnEditarEmpleado.Image = global::PayRollManagementSystemV1.Properties.Resources.editar;
            this.btnEditarEmpleado.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEditarEmpleado.MinimumWidth = 10;
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-15, -15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // txtprueba
            // 
            this.txtprueba.Location = new System.Drawing.Point(226, 95);
            this.txtprueba.Name = "txtprueba";
            this.txtprueba.Size = new System.Drawing.Size(100, 20);
            this.txtprueba.TabIndex = 8;
            // 
            // AdministradorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.txtprueba);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCerrarSesionAdministrador);
            this.Controls.Add(this.btnCerrarAdministradorView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabAdministrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministradorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdministradorView";
            this.Load += new System.EventHandler(this.AdministradorView_Load);
            this.tabAdministrador.ResumeLayout(false);
            this.tabEmpleados.ResumeLayout(false);
            this.tabEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdministrador;
        private System.Windows.Forms.TabPage tabEmpleados;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarAdministradorView;
        private System.Windows.Forms.Button btnCerrarSesionAdministrador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbRolUsuario;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.DataGridViewImageColumn btnEditarUsuario;
        private System.Windows.Forms.DataGridViewImageColumn btnEditarEmpleado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtprueba;
    }
}