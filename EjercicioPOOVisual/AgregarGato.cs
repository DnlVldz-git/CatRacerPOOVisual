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
    public partial class AgregarGato : Form
    {
        private daoGatos daoG;
        public AgregarGato()
        {
            InitializeComponent();
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
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Introduzca un nombre");
            }
            else
            {
                try
                {
                    daoG = new daoGatos();
                    daoG.insertarGato(textBox1.Text);
                    panel1.Controls.Clear();
                    AbrirFormEnPanel(new FormGatos());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar gato, intente de nuevo");
                }
            }
        }
    }
}
