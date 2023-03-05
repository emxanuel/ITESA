namespace uno
{
    partial class Form1
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
            this.calculartxt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menortxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mayortxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numerotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculartxt
            // 
            this.calculartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculartxt.Location = new System.Drawing.Point(42, 94);
            this.calculartxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculartxt.Name = "calculartxt";
            this.calculartxt.Size = new System.Drawing.Size(210, 31);
            this.calculartxt.TabIndex = 15;
            this.calculartxt.Text = "Calcular";
            this.calculartxt.UseVisualStyleBackColor = true;
            this.calculartxt.Click += new System.EventHandler(this.calculartxt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(290, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menortxt
            // 
            this.menortxt.Enabled = false;
            this.menortxt.Location = new System.Drawing.Point(365, 147);
            this.menortxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menortxt.Name = "menortxt";
            this.menortxt.Size = new System.Drawing.Size(136, 20);
            this.menortxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "El menor es:";
            // 
            // mayortxt
            // 
            this.mayortxt.Enabled = false;
            this.mayortxt.Location = new System.Drawing.Point(127, 150);
            this.mayortxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mayortxt.Name = "mayortxt";
            this.mayortxt.Size = new System.Drawing.Size(136, 20);
            this.mayortxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "El mayor es:";
            // 
            // numerotxt
            // 
            this.numerotxt.Location = new System.Drawing.Point(290, 33);
            this.numerotxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numerotxt.Multiline = true;
            this.numerotxt.Name = "numerotxt";
            this.numerotxt.Size = new System.Drawing.Size(211, 30);
            this.numerotxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese 3 numeros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 252);
            this.Controls.Add(this.calculartxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menortxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mayortxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numerotxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculartxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox menortxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mayortxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numerotxt;
        private System.Windows.Forms.Label label1;
    }
}

