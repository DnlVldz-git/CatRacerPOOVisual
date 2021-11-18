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
    public partial class Menu3 : Form
    {
        public Menu3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Implementación imp = null;
                Usuario us = null;
                int ID = -1;
                if ((textBoxNombre.Text == "") || (textBoxID.Text == "") || (textBoxDinero.Text == "") || (textBoxEdad.Text == "") || (comboBoxSexo.SelectedItem == null))
                {
                    throw new Exception("Introduzca todos los datos");
                }
                else
                {
                    daoUsuario daoUs = new daoUsuario();
                    daoCuenta daoCu = new daoCuenta();
                    String textDin = this.textBoxDinero.Text;
                    double dinero = Double.Parse(textDin);
                    String textID = this.textBoxID.Text;
                    ID = Int32.Parse(textID);
                    String textEd = this.textBoxEdad.Text;
                    int edad = Int32.Parse(textEd);
                    String contra = Encriptar.GetMD5(textBoxPsw.Text);

                    us = new Usuario(ID, dinero, textBoxNombre.Text, this.comboBoxSexo.GetItemText(this.comboBoxSexo.SelectedItem), edad); ;
                    us.setContra(contra);
                    imp = Implementación.Instance;
                    if (imp.EstaUsuario(ID))
                    {
                        throw new Exception("ID existente, busque otro");
                    }
                    else
                    {
                        daoUs.insertUsuario(us);
                        daoCu.insertCuentaToIdCuenta(ID, dinero);
                        imp.addUsuario(us);
                        imp.setUsuarioActual(us);
                    }
                    Implementación.Instance.GuardarUsuarios();
                    panel1.Controls.Clear();
                    AbrirFormEnPanel(new FormJuego());

                    String text = this.textBoxDinero.Text;
                    int dinero2 = Int32.Parse(text);
                    if (dinero2 < 0)
                    {
                        throw new Exception("Cantidad de dinero inválida");

                    }
                }



            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message, "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDinero_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AbrirFormEnPanel(new Menu1());
        }
    }
}
