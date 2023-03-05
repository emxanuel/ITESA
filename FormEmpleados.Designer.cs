namespace Capas
{
    partial class FormEmpleados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tbSueldo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbCedula = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tbTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCon = new System.Windows.Forms.DateTimePicker();
            this.btnInsertar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tbId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(20, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Buscar Empleado";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Depth = 0;
            this.tbBuscar.Hint = "";
            this.tbBuscar.Location = new System.Drawing.Point(152, 93);
            this.tbBuscar.MaxLength = 32767;
            this.tbBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.PasswordChar = '\0';
            this.tbBuscar.SelectedText = "";
            this.tbBuscar.SelectionLength = 0;
            this.tbBuscar.SelectionStart = 0;
            this.tbBuscar.Size = new System.Drawing.Size(405, 23);
            this.tbBuscar.TabIndex = 4;
            this.tbBuscar.TabStop = false;
            this.tbBuscar.UseSystemPasswordChar = false;
            this.tbBuscar.TextChanged += new System.EventHandler(this.materialSingleLineTextField1_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Depth = 0;
            this.tbNombre.Hint = "";
            this.tbNombre.Location = new System.Drawing.Point(602, 147);
            this.tbNombre.MaxLength = 32767;
            this.tbNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PasswordChar = '\0';
            this.tbNombre.SelectedText = "";
            this.tbNombre.SelectionLength = 0;
            this.tbNombre.SelectionStart = 0;
            this.tbNombre.Size = new System.Drawing.Size(102, 23);
            this.tbNombre.TabIndex = 5;
            this.tbNombre.TabStop = false;
            this.tbNombre.UseSystemPasswordChar = false;
            // 
            // tbApellido
            // 
            this.tbApellido.Depth = 0;
            this.tbApellido.Hint = "";
            this.tbApellido.Location = new System.Drawing.Point(734, 147);
            this.tbApellido.MaxLength = 32767;
            this.tbApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.PasswordChar = '\0';
            this.tbApellido.SelectedText = "";
            this.tbApellido.SelectionLength = 0;
            this.tbApellido.SelectionStart = 0;
            this.tbApellido.Size = new System.Drawing.Size(102, 23);
            this.tbApellido.TabIndex = 6;
            this.tbApellido.TabStop = false;
            this.tbApellido.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(598, 122);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Nombre";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(730, 122);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(64, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Apellido";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(730, 176);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Sueldo";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(598, 176);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Cedula";
            // 
            // tbSueldo
            // 
            this.tbSueldo.Depth = 0;
            this.tbSueldo.Hint = "";
            this.tbSueldo.Location = new System.Drawing.Point(734, 201);
            this.tbSueldo.MaxLength = 32767;
            this.tbSueldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.PasswordChar = '\0';
            this.tbSueldo.SelectedText = "";
            this.tbSueldo.SelectionLength = 0;
            this.tbSueldo.SelectionStart = 0;
            this.tbSueldo.Size = new System.Drawing.Size(102, 23);
            this.tbSueldo.TabIndex = 10;
            this.tbSueldo.TabStop = false;
            this.tbSueldo.UseSystemPasswordChar = false;
            this.tbSueldo.TextChanged += new System.EventHandler(this.tbSueldo_TextChanged);
            // 
            // tbCedula
            // 
            this.tbCedula.Depth = 0;
            this.tbCedula.Hint = "";
            this.tbCedula.Location = new System.Drawing.Point(602, 201);
            this.tbCedula.MaxLength = 32767;
            this.tbCedula.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.PasswordChar = '\0';
            this.tbCedula.SelectedText = "";
            this.tbCedula.SelectionLength = 0;
            this.tbCedula.SelectionStart = 0;
            this.tbCedula.Size = new System.Drawing.Size(102, 23);
            this.tbCedula.TabIndex = 9;
            this.tbCedula.TabStop = false;
            this.tbCedula.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(730, 236);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 19);
            this.materialLabel6.TabIndex = 16;
            this.materialLabel6.Text = "F. Con";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(598, 236);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(52, 19);
            this.materialLabel7.TabIndex = 15;
            this.materialLabel7.Text = "F. Nac";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(730, 291);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(104, 19);
            this.materialLabel8.TabIndex = 20;
            this.materialLabel8.Text = "Departamento";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(598, 291);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(69, 19);
            this.materialLabel9.TabIndex = 19;
            this.materialLabel9.Text = "Telefono";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Depth = 0;
            this.tbTelefono.Hint = "";
            this.tbTelefono.Location = new System.Drawing.Point(602, 316);
            this.tbTelefono.MaxLength = 32767;
            this.tbTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.PasswordChar = '\0';
            this.tbTelefono.SelectedText = "";
            this.tbTelefono.SelectionLength = 0;
            this.tbTelefono.SelectionStart = 0;
            this.tbTelefono.Size = new System.Drawing.Size(102, 23);
            this.tbTelefono.TabIndex = 17;
            this.tbTelefono.TabStop = false;
            this.tbTelefono.UseSystemPasswordChar = false;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNac.Location = new System.Drawing.Point(602, 258);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaNac.TabIndex = 21;
            // 
            // dtpFechaCon
            // 
            this.dtpFechaCon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCon.Location = new System.Drawing.Point(732, 258);
            this.dtpFechaCon.Name = "dtpFechaCon";
            this.dtpFechaCon.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaCon.TabIndex = 22;
            // 
            // btnInsertar
            // 
            this.btnInsertar.AutoSize = true;
            this.btnInsertar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnInsertar.Depth = 0;
            this.btnInsertar.Icon = null;
            this.btnInsertar.Location = new System.Drawing.Point(24, 363);
            this.btnInsertar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Primary = true;
            this.btnInsertar.Size = new System.Drawing.Size(85, 36);
            this.btnInsertar.TabIndex = 23;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(152, 363);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(299, 363);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(83, 36);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxDepartamento.Location = new System.Drawing.Point(734, 318);
            this.comboBoxDepartamento.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(102, 21);
            this.comboBoxDepartamento.TabIndex = 26;
            this.comboBoxDepartamento.Text = "1";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(598, 351);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(21, 19);
            this.materialLabel10.TabIndex = 28;
            this.materialLabel10.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Depth = 0;
            this.tbId.Enabled = false;
            this.tbId.Hint = "";
            this.tbId.Location = new System.Drawing.Point(602, 376);
            this.tbId.MaxLength = 32767;
            this.tbId.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbId.Name = "tbId";
            this.tbId.PasswordChar = '\0';
            this.tbId.SelectedText = "";
            this.tbId.SelectionLength = 0;
            this.tbId.SelectionStart = 0;
            this.tbId.Size = new System.Drawing.Size(102, 23);
            this.tbId.TabIndex = 27;
            this.tbId.TabStop = false;
            this.tbId.UseSystemPasswordChar = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(482, 363);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = true;
            this.btnLimpiar.Size = new System.Drawing.Size(75, 36);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(778, 402);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.comboBoxDepartamento);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtpFechaCon);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.tbSueldo);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbApellido;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbSueldo;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCedula;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFechaCon;
        private MaterialSkin.Controls.MaterialRaisedButton btnInsertar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbId;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpiar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}