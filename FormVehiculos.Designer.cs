namespace Capas
{
    partial class FormVehiculos
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
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tbId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInsertar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tbCombustible = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tbAño = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbTipo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbModelo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbMarca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbKilometraje = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbCapacidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbTarifa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.tbCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(784, 448);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10);
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 56;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(488, 365);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = true;
            this.btnLimpiar.Size = new System.Drawing.Size(75, 36);
            this.btnLimpiar.TabIndex = 55;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(736, 350);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(21, 19);
            this.materialLabel10.TabIndex = 54;
            this.materialLabel10.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Depth = 0;
            this.tbId.Enabled = false;
            this.tbId.Hint = "";
            this.tbId.Location = new System.Drawing.Point(740, 375);
            this.tbId.MaxLength = 32767;
            this.tbId.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbId.Name = "tbId";
            this.tbId.PasswordChar = '\0';
            this.tbId.SelectedText = "";
            this.tbId.SelectionLength = 0;
            this.tbId.SelectionStart = 0;
            this.tbId.Size = new System.Drawing.Size(102, 23);
            this.tbId.TabIndex = 53;
            this.tbId.TabStop = false;
            this.tbId.UseSystemPasswordChar = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(305, 365);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(83, 36);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(158, 365);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.AutoSize = true;
            this.btnInsertar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnInsertar.Depth = 0;
            this.btnInsertar.Icon = null;
            this.btnInsertar.Location = new System.Drawing.Point(30, 365);
            this.btnInsertar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Primary = true;
            this.btnInsertar.Size = new System.Drawing.Size(85, 36);
            this.btnInsertar.TabIndex = 49;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(736, 293);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(48, 19);
            this.materialLabel8.TabIndex = 46;
            this.materialLabel8.Text = "Tarifa";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(604, 293);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(94, 19);
            this.materialLabel9.TabIndex = 45;
            this.materialLabel9.Text = "Combustible";
            // 
            // tbCombustible
            // 
            this.tbCombustible.Depth = 0;
            this.tbCombustible.Hint = "";
            this.tbCombustible.Location = new System.Drawing.Point(608, 318);
            this.tbCombustible.MaxLength = 32767;
            this.tbCombustible.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCombustible.Name = "tbCombustible";
            this.tbCombustible.PasswordChar = '\0';
            this.tbCombustible.SelectedText = "";
            this.tbCombustible.SelectionLength = 0;
            this.tbCombustible.SelectionStart = 0;
            this.tbCombustible.Size = new System.Drawing.Size(102, 23);
            this.tbCombustible.TabIndex = 44;
            this.tbCombustible.TabStop = false;
            this.tbCombustible.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(736, 238);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(79, 19);
            this.materialLabel6.TabIndex = 43;
            this.materialLabel6.Text = "Capacidad";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(604, 238);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(86, 19);
            this.materialLabel7.TabIndex = 42;
            this.materialLabel7.Text = "Kilometraje";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(736, 178);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(36, 19);
            this.materialLabel4.TabIndex = 41;
            this.materialLabel4.Text = "Año";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(604, 178);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(39, 19);
            this.materialLabel5.TabIndex = 40;
            this.materialLabel5.Text = "Tipo";
            // 
            // tbAño
            // 
            this.tbAño.Depth = 0;
            this.tbAño.Hint = "";
            this.tbAño.Location = new System.Drawing.Point(740, 203);
            this.tbAño.MaxLength = 32767;
            this.tbAño.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbAño.Name = "tbAño";
            this.tbAño.PasswordChar = '\0';
            this.tbAño.SelectedText = "";
            this.tbAño.SelectionLength = 0;
            this.tbAño.SelectionStart = 0;
            this.tbAño.Size = new System.Drawing.Size(102, 23);
            this.tbAño.TabIndex = 39;
            this.tbAño.TabStop = false;
            this.tbAño.UseSystemPasswordChar = false;
            this.tbAño.TextChanged += new System.EventHandler(this.tbAño_TextChanged);
            // 
            // tbTipo
            // 
            this.tbTipo.Depth = 0;
            this.tbTipo.Hint = "";
            this.tbTipo.Location = new System.Drawing.Point(608, 203);
            this.tbTipo.MaxLength = 32767;
            this.tbTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.PasswordChar = '\0';
            this.tbTipo.SelectedText = "";
            this.tbTipo.SelectionLength = 0;
            this.tbTipo.SelectionStart = 0;
            this.tbTipo.Size = new System.Drawing.Size(102, 23);
            this.tbTipo.TabIndex = 38;
            this.tbTipo.TabStop = false;
            this.tbTipo.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(736, 124);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 19);
            this.materialLabel3.TabIndex = 37;
            this.materialLabel3.Text = "Modelo";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(604, 124);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "Marca";
            // 
            // tbModelo
            // 
            this.tbModelo.Depth = 0;
            this.tbModelo.Hint = "";
            this.tbModelo.Location = new System.Drawing.Point(740, 149);
            this.tbModelo.MaxLength = 32767;
            this.tbModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.PasswordChar = '\0';
            this.tbModelo.SelectedText = "";
            this.tbModelo.SelectionLength = 0;
            this.tbModelo.SelectionStart = 0;
            this.tbModelo.Size = new System.Drawing.Size(102, 23);
            this.tbModelo.TabIndex = 35;
            this.tbModelo.TabStop = false;
            this.tbModelo.UseSystemPasswordChar = false;
            // 
            // tbMarca
            // 
            this.tbMarca.Depth = 0;
            this.tbMarca.Hint = "";
            this.tbMarca.Location = new System.Drawing.Point(608, 149);
            this.tbMarca.MaxLength = 32767;
            this.tbMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.PasswordChar = '\0';
            this.tbMarca.SelectedText = "";
            this.tbMarca.SelectionLength = 0;
            this.tbMarca.SelectionStart = 0;
            this.tbMarca.Size = new System.Drawing.Size(102, 23);
            this.tbMarca.TabIndex = 34;
            this.tbMarca.TabStop = false;
            this.tbMarca.UseSystemPasswordChar = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Depth = 0;
            this.tbBuscar.Hint = "";
            this.tbBuscar.Location = new System.Drawing.Point(158, 95);
            this.tbBuscar.MaxLength = 32767;
            this.tbBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.PasswordChar = '\0';
            this.tbBuscar.SelectedText = "";
            this.tbBuscar.SelectionLength = 0;
            this.tbBuscar.SelectionStart = 0;
            this.tbBuscar.Size = new System.Drawing.Size(405, 23);
            this.tbBuscar.TabIndex = 33;
            this.tbBuscar.TabStop = false;
            this.tbBuscar.UseSystemPasswordChar = false;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 19);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Buscar Vehiculo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 217);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // tbKilometraje
            // 
            this.tbKilometraje.Depth = 0;
            this.tbKilometraje.Hint = "";
            this.tbKilometraje.Location = new System.Drawing.Point(608, 260);
            this.tbKilometraje.MaxLength = 32767;
            this.tbKilometraje.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbKilometraje.Name = "tbKilometraje";
            this.tbKilometraje.PasswordChar = '\0';
            this.tbKilometraje.SelectedText = "";
            this.tbKilometraje.SelectionLength = 0;
            this.tbKilometraje.SelectionStart = 0;
            this.tbKilometraje.Size = new System.Drawing.Size(102, 23);
            this.tbKilometraje.TabIndex = 57;
            this.tbKilometraje.TabStop = false;
            this.tbKilometraje.UseSystemPasswordChar = false;
            this.tbKilometraje.TextChanged += new System.EventHandler(this.tbKilometraje_TextChanged);
            // 
            // tbCapacidad
            // 
            this.tbCapacidad.Depth = 0;
            this.tbCapacidad.Hint = "";
            this.tbCapacidad.Location = new System.Drawing.Point(740, 260);
            this.tbCapacidad.MaxLength = 32767;
            this.tbCapacidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCapacidad.Name = "tbCapacidad";
            this.tbCapacidad.PasswordChar = '\0';
            this.tbCapacidad.SelectedText = "";
            this.tbCapacidad.SelectionLength = 0;
            this.tbCapacidad.SelectionStart = 0;
            this.tbCapacidad.Size = new System.Drawing.Size(102, 23);
            this.tbCapacidad.TabIndex = 58;
            this.tbCapacidad.TabStop = false;
            this.tbCapacidad.UseSystemPasswordChar = false;
            // 
            // tbTarifa
            // 
            this.tbTarifa.Depth = 0;
            this.tbTarifa.Hint = "";
            this.tbTarifa.Location = new System.Drawing.Point(740, 318);
            this.tbTarifa.MaxLength = 32767;
            this.tbTarifa.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbTarifa.Name = "tbTarifa";
            this.tbTarifa.PasswordChar = '\0';
            this.tbTarifa.SelectedText = "";
            this.tbTarifa.SelectionLength = 0;
            this.tbTarifa.SelectionStart = 0;
            this.tbTarifa.Size = new System.Drawing.Size(102, 23);
            this.tbTarifa.TabIndex = 59;
            this.tbTarifa.TabStop = false;
            this.tbTarifa.UseSystemPasswordChar = false;
            this.tbTarifa.TextChanged += new System.EventHandler(this.tbTarifa_TextChanged);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(604, 353);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(68, 19);
            this.materialLabel11.TabIndex = 61;
            this.materialLabel11.Text = "Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Depth = 0;
            this.tbCantidad.Hint = "";
            this.tbCantidad.Location = new System.Drawing.Point(608, 378);
            this.tbCantidad.MaxLength = 32767;
            this.tbCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.PasswordChar = '\0';
            this.tbCantidad.SelectedText = "";
            this.tbCantidad.SelectionLength = 0;
            this.tbCantidad.SelectionStart = 0;
            this.tbCantidad.Size = new System.Drawing.Size(102, 23);
            this.tbCantidad.TabIndex = 60;
            this.tbCantidad.TabStop = false;
            this.tbCantidad.UseSystemPasswordChar = false;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            // 
            // FormVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 496);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbTarifa);
            this.Controls.Add(this.tbCapacidad);
            this.Controls.Add(this.tbKilometraje);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.tbCombustible);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormVehiculos";
            this.Text = "FormVehiculos";
            this.Load += new System.EventHandler(this.FormVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpiar;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbId;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnInsertar;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCombustible;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbAño;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbTipo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbModelo;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbMarca;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbKilometraje;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCapacidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbTarifa;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCantidad;
    }
}