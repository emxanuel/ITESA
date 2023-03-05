namespace Pedidos
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pedidosDataSet1 = new Pedidos.PedidosDataSet();
            this.reporte3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte3TableAdapter1 = new Pedidos.PedidosDataSetTableAdapters.Reporte3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporte3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pedidos.Report3.rdlc";
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
            // reporte3BindingSource
            // 
            this.reporte3BindingSource.DataMember = "Reporte3";
            this.reporte3BindingSource.DataSource = this.pedidosDataSet1;
            // 
            // reporte3TableAdapter1
            // 
            this.reporte3TableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PedidosDataSet pedidosDataSet;
        private PedidosDataSetTableAdapters.Reporte3TableAdapter reporte3TableAdapter;
        private PedidosDataSet pedidosDataSet1;
        private System.Windows.Forms.BindingSource reporte3BindingSource;
        private PedidosDataSetTableAdapters.Reporte3TableAdapter reporte3TableAdapter1;
    }
}