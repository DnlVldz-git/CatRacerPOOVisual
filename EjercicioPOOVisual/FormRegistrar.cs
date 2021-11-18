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
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Implementación imp = null;
                Usuario us = null;
                int ID = -1;
                if ((textBoxNombre.Text == "") || (textBoxEdad.Text == "") || (comboBoxSexo.SelectedItem == null))
                {
                    throw new Exception("Introduzca todos los datos");
                }
                else
                {
                    daoUsuario daoUs = new daoUsuario();
                    daoCuenta daoCu = new daoCuenta();                                                            
                    String textEd = this.textBoxEdad.Text;
                    int edad = Int32.Parse(textEd);
                    String contra = Encriptar.GetMD5(textBoxPsw.Text);                    

                    us = new Usuario(ID, 0.0, textBoxNombre.Text, this.comboBoxSexo.GetItemText(this.comboBoxSexo.SelectedItem), edad); ;                    

                    us.setContra(contra);
                    imp = Implementación.Instance;
                    if (imp.EstaUsuario(ID))
                    {
                        throw new Exception("ID existente, busque otro");
                    }
                    else
                    {
                        daoUs.insertUsuario(us);                        
                        imp.addUsuario(us);                        
                    }
                    Implementación.Instance.GuardarUsuarios();
                    panel1.Controls.Clear();
                    AbrirFormEnPanel(new FormControl());                                        
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AbrirFormEnPanel(new FormControl());
        }
    }
}
