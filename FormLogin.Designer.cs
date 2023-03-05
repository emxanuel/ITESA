namespace Capas
{
    partial class FormLogin
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
            this.tbUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbContrasena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Depth = 0;
            this.tbUsuario.Hint = "";
            this.tbUsuario.Location = new System.Drawing.Point(210, 141);
            this.tbUsuario.MaxLength = 32767;
            this.tbUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PasswordChar = '\0';
            this.tbUsuario.SelectedText = "";
            this.tbUsuario.SelectionLength = 0;
            this.tbUsuario.SelectionStart = 0;
            this.tbUsuario.Size = new System.Drawing.Size(150, 23);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.TabStop = false;
            this.tbUsuario.UseSystemPasswordChar = false;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Depth = 0;
            this.tbContrasena.Hint = "";
            this.tbContrasena.Location = new System.Drawing.Point(210, 192);
            this.tbContrasena.MaxLength = 32767;
            this.tbContrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '*';
            this.tbContrasena.SelectedText = "";
            this.tbContrasena.SelectionLength = 0;
            this.tbContrasena.SelectionStart = 0;
            this.tbContrasena.Size = new System.Drawing.Size(150, 23);
            this.tbContrasena.TabIndex = 3;
            this.tbContrasena.TabStop = false;
            this.tbContrasena.UseSystemPasswordChar = false;
            this.tbContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContrasena_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // btnAcceder
            // 
            this.btnAcceder.AutoSize = true;
            this.btnAcceder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAcceder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAcceder.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAcceder.Location = new System.Drawing.Point(158, 242);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(3);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Padding = new System.Windows.Forms.Padding(5);
            this.btnAcceder.Size = new System.Drawing.Size(107, 35);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 338);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Acceder al sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnAcceder;
    }
}