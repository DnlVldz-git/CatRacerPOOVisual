
namespace EjercicioPOOVisual
{
    partial class FormReporteUsuarioCuenta
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
            this.CatRacerBDDataSet2 = new EjercicioPOOVisual.CatRacerBDDataSet2();
            this.Get_Usuario_CuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Get_Usuario_CuentaTableAdapter = new EjercicioPOOVisual.CatRacerBDDataSet2TableAdapters.Get_Usuario_CuentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CatRacerBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Get_Usuario_CuentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Get_Usuario_CuentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EjercicioPOOVisual.Reportes.Reporte_Usuarios_Cuenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1080, 459);
            this.reportViewer1.TabIndex = 0;
            // 
            // CatRacerBDDataSet2
            // 
            this.CatRacerBDDataSet2.DataSetName = "CatRacerBDDataSet2";
            this.CatRacerBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Get_Usuario_CuentaBindingSource
            // 
            this.Get_Usuario_CuentaBindingSource.DataMember = "Get_Usuario_Cuenta";
            this.Get_Usuario_CuentaBindingSource.DataSource = this.CatRacerBDDataSet2;
            // 
            // Get_Usuario_CuentaTableAdapter
            // 
            this.Get_Usuario_CuentaTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteUsuarioCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 459);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteUsuarioCuenta";
            this.Text = "FormReporteUsuarioCuenta";
            this.Load += new System.EventHandler(this.FormReporteUsuarioCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatRacerBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Get_Usuario_CuentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Get_Usuario_CuentaBindingSource;
        private CatRacerBDDataSet2 CatRacerBDDataSet2;
        private CatRacerBDDataSet2TableAdapters.Get_Usuario_CuentaTableAdapter Get_Usuario_CuentaTableAdapter;
    }
}