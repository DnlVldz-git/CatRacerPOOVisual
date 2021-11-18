using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPOOVisual
{
    public partial class FormReporteUsuarioCuenta : Form
    {
        public FormReporteUsuarioCuenta()
        {
            InitializeComponent();
        }

        private void FormReporteUsuarioCuenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CatRacerBDDataSet2.Get_Usuario_Cuenta' table. You can move, or remove it, as needed.
            this.Get_Usuario_CuentaTableAdapter.Fill(this.CatRacerBDDataSet2.Get_Usuario_Cuenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
