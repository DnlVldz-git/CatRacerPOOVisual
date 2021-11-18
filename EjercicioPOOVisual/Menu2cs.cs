using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPOOVisual
{
    public partial class Menu2cs : Form
    {
        static String dir = Directory.GetCurrentDirectory();
        String serializationFile = Path.Combine(dir, "usuarios.bin");
        public Menu2cs()
        {
            InitializeComponent();
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Implementación imp = Implementación.Instance;
                imp.setUsuarios((List<Usuario>)bformatter.Deserialize(stream));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AbrirFormEnPanel(Object Formhijo)
        {
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String text = "";
            try
            {
                Implementación imp = Implementación.Instance;
                text = this.textBox1.Text;
                int ID = Int32.Parse(text);
                if (imp.EstaUsuario(ID))
                {
                    panel2.Controls.Clear();
                    AbrirFormEnPanel(new FormJuego());
                }
                else {
                    MessageBox.Show("ID no encontrado", "Entrada no válida",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                }
                
                

            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce ID válido", "Entrada no válida",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AbrirFormEnPanel(new Menu1());
        }
    }
}
