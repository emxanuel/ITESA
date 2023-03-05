namespace Pedidos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pedidosDataSet = new Pedidos.PedidosDataSet();
            this.reporte4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte4TableAdapter = new Pedidos.PedidosDataSetTableAdapters.Reporte4TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporte4BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pedidos.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(789, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // pedidosDataSet
            // 
            this.pedidosDataSet.DataSetName = "PedidosDataSet";
            this.pedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte4BindingSource
            // 
            this.reporte4BindingSource.DataMember = "Reporte4";
            this.reporte4BindingSource.DataSource = this.pedidosDataSet;
            // 
            // reporte4TableAdapter
            // 
            this.reporte4TableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PedidosDataSet pedidosDataSet;
        private System.Windows.Forms.BindingSource reporte4BindingSource;
        private PedidosDataSetTableAdapters.Reporte4TableAdapter reporte4TableAdapter;
    }
}