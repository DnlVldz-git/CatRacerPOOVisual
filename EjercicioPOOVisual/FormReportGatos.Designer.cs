
namespace EjercicioPOOVisual
{
    partial class FormReportGatos
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
            this.CatRacerBDDataSet = new EjercicioPOOVisual.CatRacerBDDataSet();
            this.GatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GatosTableAdapter = new EjercicioPOOVisual.CatRacerBDDataSetTableAdapters.GatosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CatRacerBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GatosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EjercicioPOOVisual.Reportes.ReportGatos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1099, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // CatRacerBDDataSet
            // 
            this.CatRacerBDDataSet.DataSetName = "CatRacerBDDataSet";
            this.CatRacerBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GatosBindingSource
            // 
            this.GatosBindingSource.DataMember = "Gatos";
            this.GatosBindingSource.DataSource = this.CatRacerBDDataSet;
            // 
            // GatosTableAdapter
            // 
            this.GatosTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportGatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportGatos";
            this.Text = "FormReportGatos";
            this.Load += new System.EventHandler(this.FormReportGatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatRacerBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GatosBindingSource;
        private CatRacerBDDataSet CatRacerBDDataSet;
        private CatRacerBDDataSetTableAdapters.GatosTableAdapter GatosTableAdapter;
    }
}