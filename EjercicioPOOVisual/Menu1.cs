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
    public partial class Menu1 : Form
    {
        
        public Menu1()
        {
            InitializeComponent();
            GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormEnPanel(Object Formhijo)
        {
            GC.Collect();
            if (this.panel3.Controls.Count > 0)
            {
                this.panel3.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.None;
            
            this.panel3.Controls.Add(fh);
            fh.Show();
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            panel3.Controls.Clear();
            AbrirFormEnPanel(new FormJuego());
            Implementación imp = Implementación.Instance;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GC.Collect();
            panel3.Controls.Clear();
            AbrirFormEnPanel(new FormGatos());            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            Implementación imp = Implementación.Instance;
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, imp.GetUsuarios());
            }

            MessageBox.Show("Se ha creado y guardado el objeto Estudiante");*/

            panel3.Controls.Clear();
            FormControl menuControl = new FormControl();            
            AbrirFormEnPanel(menuControl);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            form1 FormInicio = new form1();
            AbrirFormEnPanel(FormInicio);
        }
    }
}
