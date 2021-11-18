using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EjercicioPOOVisual
{
    public partial class form1 : Form
    {
        private Boolean bandera = false;
        public form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormEnPanel(Object Formhijo)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            fh.Show();
        }        

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void form1_Load(object sender, EventArgs e)
        {
            
            login logi = new login();
            logi.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            panel1.Controls.Clear();
            AbrirFormEnPanel(new Menu1());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            bandera = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
