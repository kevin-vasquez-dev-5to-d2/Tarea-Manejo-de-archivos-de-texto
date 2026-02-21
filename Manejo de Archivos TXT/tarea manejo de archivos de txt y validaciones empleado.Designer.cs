namespace TareaManejodeArchivos_de_txt_y_validaciones
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            
            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 20);
            this.lblTitulo.TabIndex = 99;
            this.lblTitulo.Text = "Gestión de Empleados";
            
            // lblID
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblID.Location = new System.Drawing.Point(20, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 100;
            this.lblID.Text = "ID:";
            
            // txtID
            this.txtID.Location = new System.Drawing.Point(120, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 23);
            this.txtID.TabIndex = 0;
            
            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.Location = new System.Drawing.Point(20, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 101;
            this.lblNombre.Text = "Nombre:";
            
            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(120, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 23);
            this.txtNombre.TabIndex = 1;
            
            // lblApellidos
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblApellidos.Location = new System.Drawing.Point(20, 110);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(57, 15);
            this.lblApellidos.TabIndex = 102;
            this.lblApellidos.Text = "Apellidos:";
            
            // txtApellidos
            this.txtApellidos.Location = new System.Drawing.Point(120, 107);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(150, 23);
            this.txtApellidos.TabIndex = 2;
            
            // lblDireccion
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDireccion.Location = new System.Drawing.Point(20, 140);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 103;
            this.lblDireccion.Text = "Dirección:";
            
            // txtDireccion
            this.txtDireccion.Location = new System.Drawing.Point(120, 137);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(150, 23);
            this.txtDireccion.TabIndex = 3;
            
            // lblTelefono
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTelefono.Location = new System.Drawing.Point(20, 170);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(57, 15);
            this.lblTelefono.TabIndex = 104;
            this.lblTelefono.Text = "Teléfono:";
            
            // txtTelefono
            this.txtTelefono.Location = new System.Drawing.Point(120, 167);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(150, 23);
            this.txtTelefono.TabIndex = 4;
            
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.Location = new System.Drawing.Point(20, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 105;
            this.lblEmail.Text = "Email:";
            
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(120, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 23);
            this.txtEmail.TabIndex = 5;
            
            // lblSalario
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSalario.Location = new System.Drawing.Point(20, 230);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(47, 15);
            this.lblSalario.TabIndex = 106;
            this.lblSalario.Text = "Salario:";
            
            // txtSalario
            this.txtSalario.Location = new System.Drawing.Point(120, 227);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(150, 23);
            this.txtSalario.TabIndex = 6;
            
            // lblCargo
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCargo.Location = new System.Drawing.Point(20, 260);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(43, 15);
            this.lblCargo.TabIndex = 107;
            this.lblCargo.Text = "Cargo:";
            
            // cbCargo
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbCargo.Items.AddRange(new object[] {
            "Gerente",
            "Analista",
            "Contador",
            "Vendedor",
            "Soporte",
            "Recursos Humanos",
            "Otro"});
            this.cbCargo.Location = new System.Drawing.Point(120, 257);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(150, 23);
            this.cbCargo.TabIndex = 7;
            
            // lblGenero
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGenero.Location = new System.Drawing.Point(20, 290);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(47, 15);
            this.lblGenero.TabIndex = 108;
            this.lblGenero.Text = "Género:";
            
            // cbGenero
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbGenero.Location = new System.Drawing.Point(120, 287);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(150, 23);
            this.cbGenero.TabIndex = 8;
            
            // lblFechaIngreso
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaIngreso.Location = new System.Drawing.Point(20, 320);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(91, 15);
            this.lblFechaIngreso.TabIndex = 109;
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            
            // dtpFechaIngreso
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(120, 317);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(150, 23);
            this.dtpFechaIngreso.TabIndex = 9;
            
            // btnGuardar
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(120, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            
            // lblDatos
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDatos.ForeColor = System.Drawing.Color.Black;
            this.lblDatos.Location = new System.Drawing.Point(450, 10);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(300, 20);
            this.lblDatos.TabIndex = 110;
            this.lblDatos.Text = "Empleados Registrados";
            
            // dgvEmpleados
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(300, 50);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(900, 350);
            this.dgvEmpleados.TabIndex = 111;
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = true;
            this.dgvEmpleados.ReadOnly = false;
            
            // Form1
            this.ClientSize = new System.Drawing.Size(1220, 420);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.Text = "Sistema de Gestión de Empleados";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}
