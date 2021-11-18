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
    public partial class FormReportCuentas : Form
    {
        public FormReportCuentas()
        {
            InitializeComponent();
        }

        private void FormReportCuentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CatRacerBDDataSet.Cuenta' table. You can move, or remove it, as needed.
            this.CuentaTableAdapter.Fill(this.CatRacerBDDataSet.Cuenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
