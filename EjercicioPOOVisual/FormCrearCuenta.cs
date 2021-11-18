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
    public partial class FormCrearCuenta : Form
    {
        Usuario us;
        public FormCrearCuenta()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(Object Formhijo)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.None;


            panel1.Controls.Add(fh);
            fh.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    /*
                    Implementación.Instance.GetUsuarioTemp().AddCuenta(Double.Parse(textBox1.Text));
                    Implementación imp = Implementación.Instance;
                    imp.GuardarUsuarios();
                    */
                    daoCuenta daoCu = new daoCuenta();
                    int id = Implementación.Instance.GetUsuarioTemp().GetId();
                    Double dinero = Double.Parse(textBox1.Text);
                    daoCu.insertCuentaToIdCuenta(id, dinero);

                    panel1.Controls.Clear();
                    AbrirFormEnPanel(new FormControl());
                }
                else
                {
                    throw new Exception("Rellene el campo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AbrirFormEnPanel(new FormControl());
        }
    }
}
