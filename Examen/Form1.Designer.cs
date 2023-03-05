namespace Examen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">True si los recursos administrados se deben eliminar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por Windows Form Designer

        /// <summary>
        /// Se requiere el método para la compatibilidad con Designer: no modifique
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.examenDataSet2 = new Examen.ExamenDataSet();
            this.generarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generarFacturaTableAdapter2 = new Examen.ExamenDataSetTableAdapters.GenerarFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generarFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.generarFacturaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Examen.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(784, 520);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // examenDataSet2
            // 
            this.examenDataSet2.DataSetName = "ExamenDataSet";
            this.examenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generarFacturaBindingSource
            // 
            this.generarFacturaBindingSource.DataMember = "GenerarFactura";
            this.generarFacturaBindingSource.DataSource = this.examenDataSet2;
            // 
            // generarFacturaTableAdapter2
            // 
            this.generarFacturaTableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 520);
            this.Controls.Add(this.reportViewer2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generarFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private ExamenDataSet examenDataSet1;
        private ExamenDataSetTableAdapters.GenerarFacturaTableAdapter generarFacturaTableAdapter1;
        private ExamenDataSet examenDataSet;
        private ExamenDataSetTableAdapters.GenerarFacturaTableAdapter generarFacturaTableAdapter;
        private System.Windows.Forms.BindingSource generarFacturaBindingSource;
        private ExamenDataSet examenDataSet2;
        private ExamenDataSetTableAdapters.GenerarFacturaTableAdapter generarFacturaTableAdapter2;
    }
}

