namespace Pedidos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pedidosDataSet1 = new Pedidos.PedidosDataSet();
            this.reporte1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte1TableAdapter1 = new Pedidos.PedidosDataSetTableAdapters.Reporte1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporte1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pedidos.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(789, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // pedidosDataSet1
            // 
            this.pedidosDataSet1.DataSetName = "PedidosDataSet";
            this.pedidosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte1BindingSource
            // 
            this.reporte1BindingSource.DataMember = "Reporte1";
            this.reporte1BindingSource.DataSource = this.pedidosDataSet1;
            // 
            // reporte1TableAdapter1
            // 
            this.reporte1TableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PedidosDataSet pedidosDataSet;
        private PedidosDataSetTableAdapters.Reporte1TableAdapter reporte1TableAdapter;
        private PedidosDataSet pedidosDataSet1;
        private System.Windows.Forms.BindingSource reporte1BindingSource;
        private PedidosDataSetTableAdapters.Reporte1TableAdapter reporte1TableAdapter1;
    }
}

