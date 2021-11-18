using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPOOVisual
{
    public partial class FormReportUsuario : Form
    {
        public FormReportUsuario()
        {
            InitializeComponent();
        }

        private void FormReportUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CatRacerBDDataSet.Usuario' table. You can move, or remove it, as needed.
            this.UsuarioTableAdapter.Fill(this.CatRacerBDDataSet.Usuario);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select id, nombre, contraseña, edad, sexo from Usuario", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();

                adaptador.Fill(ds, "Usuario");
                conexion.Close();
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);

                reportViewer1.Reset();
                reportViewer1.LocalReport.Dispose();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.ReportPath = Directory.GetCurrentDirectory() + "\\ReportUsuarios.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
