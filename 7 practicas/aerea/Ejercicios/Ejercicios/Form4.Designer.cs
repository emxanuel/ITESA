namespace Ejercicios
{
    partial class Form4
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
            this.avionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miembrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dtgtablas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablas)).BeginInit();
            this.SuspendLayout();
            // 
            // avionesToolStripMenuItem
            // 
            this.avionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avionesToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.avionesToolStripMenuItem.Name = "avionesToolStripMenuItem";
            this.avionesToolStripMenuItem.Size = new System.Drawing.Size(107, 34);
            this.avionesToolStripMenuItem.Text = "Aviones ";
            this.avionesToolStripMenuItem.Click += new System.EventHandler(this.avionesToolStripMenuItem_Click);
            // 
            // pilotosToolStripMenuItem
            // 
            this.pilotosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotosToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.pilotosToolStripMenuItem.Name = "pilotosToolStripMenuItem";
            this.pilotosToolStripMenuItem.Size = new System.Drawing.Size(89, 34);
            this.pilotosToolStripMenuItem.Text = "Pilotos";
            this.pilotosToolStripMenuItem.Click += new System.EventHandler(this.pilotosToolStripMenuItem_Click);
            // 
            // miembrosToolStripMenuItem
            // 
            this.miembrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miembrosToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.miembrosToolStripMenuItem.Name = "miembrosToolStripMenuItem";
            this.miembrosToolStripMenuItem.Size = new System.Drawing.Size(124, 34);
            this.miembrosToolStripMenuItem.Text = "Miembros";
            this.miembrosToolStripMenuItem.Click += new System.EventHandler(this.miembrosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avionesToolStripMenuItem,
            this.pilotosToolStripMenuItem,
            this.miembrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dtgtablas
            // 
            this.dtgtablas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            this.dtgtablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtablas.Location = new System.Drawing.Point(89, 158);
            this.dtgtablas.Name = "dtgtablas";
            this.dtgtablas.RowHeadersWidth = 51;
            this.dtgtablas.Size = new System.Drawing.Size(741, 165);
            this.dtgtablas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(291, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Compañia Aerea ";
            // 
            // Form4
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(938, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgtablas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Aviones;
        private System.Windows.Forms.TabPage Pilotos;
        private System.Windows.Forms.TabPage Empleados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripMenuItem avionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miembrosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dtgtablas;
        private System.Windows.Forms.Label label1;
    }
}