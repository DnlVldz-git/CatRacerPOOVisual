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
    public partial class FormReportGatos : Form
    {
        public FormReportGatos()
        {
            InitializeComponent();
        }

        private void FormReportGatos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CatRacerBDDataSet.Gatos' table. You can move, or remove it, as needed.
            this.GatosTableAdapter.Fill(this.CatRacerBDDataSet.Gatos);

            this.reportViewer1.RefreshReport();            
        }
    }
}
