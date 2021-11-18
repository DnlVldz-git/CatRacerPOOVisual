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
    public partial class FormGatos : Form
    {
        private daoGatos daoG;
        public FormGatos()
        {
            InitializeComponent();
            MostrarAlAbrirBD();
        }

        public void MostrarAlAbrirBD()
        {
            listView1.Items.Clear();
            daoG = new daoGatos();

            try
            {
                List<Gatos> gatos = daoG.getAll();

                foreach (Gatos gato in gatos)
                {
                    ListViewItem filita = new ListViewItem(gato.Id.ToString());
                    filita.SubItems.Add(gato.Nombre.ToString());                    
                    listView1.Items.Add(filita);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar gatos");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AbrirFormEnPanel(new Menu1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AbrirFormEnPanel(new AgregarGato());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un gato");
            }
            else
            {
                List<Gatos> gatos = daoG.getAll();

                foreach (ListViewItem lv in listView1.SelectedItems)
                {
                    String id_ = lv.Text;
                    foreach (Gatos gato in gatos)
                    {
                        if (gato.Id == (Convert.ToInt32(id_)))
                        {
                            daoG.deleteGato(gato.Id);
                        }    
                    }
                }
                MostrarAlAbrirBD();
            }     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReportGatos rprtGatos = new FormReportGatos();
            rprtGatos.ShowDialog();
        }
    }
}
