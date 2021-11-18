using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPOOVisual
{
    public partial class FormJuego : Form
    {
        public FormJuego()
        {
            InitializeComponent();
            Implementación imp = Implementación.Instance;
            fillComboBx();
            GC.Collect();
        }

        public void fillComboBx()
        {
            GC.Collect();
            daoCuenta daoCu = new daoCuenta();
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;

            SqlConnection conexion = new SqlConnection(cadena);
            ArrayList lista = new ArrayList();

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("Select id, dineroTotal from cuenta " +
                    "where id_cuenta = " +
                    "" + Implementación.Instance.GetUsuarioActual().GetId(), conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable table = new DataTable("dinero");
                adapter.Fill(table);

                comboBox1.DataSource = table;
                comboBox1.ValueMember = "id";
                comboBox1.DisplayMember = "id";

                conexion.Close();                
                cambiarDinero();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error al obtener sus cuentas");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelDinero_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormEnPanel(Object Formhijo)
        {
            GC.Collect();
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

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            if (comboBox1.SelectedIndex != -1)
            {
                try
                {
                    Implementación imp = Implementación.Instance;
                    String textDin = this.textBox1.Text;
                    double dinero = Double.Parse(textDin);                    
                    imp.setNumCuenta(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                    daoCuenta daoCu = new daoCuenta();
                    Cuenta cuenta = daoCu.getCuentaWithId(Convert.ToInt32(comboBox1.SelectedValue));
                    if ((dinero < 0) || (cuenta.GetDineroTotal() < dinero))
                    {
                        MessageBox.Show("Número inválido", "Entrada no válida",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                    }
                    else
                    {
                        imp.GetUsuarioActual().setCantidad(dinero);
                        panel1.Controls.Clear();
                        AbrirFormEnPanel(new FormJuego2());
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Entrada inválida", "Entrada no válida",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning); 
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cuenta", "Warning",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning); ;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AbrirFormEnPanel(new Menu1());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambiarDinero();
        }

        public void cambiarDinero()
        {
            try
            {
                string cadena = Properties.Settings.Default.CatRacerBDConnectionString;

                SqlConnection conexion = new SqlConnection(cadena);
                daoCuenta daoC = new daoCuenta();

                List<Cuenta> cuentas = daoC.getAllCuentasWithId(Implementación.Instance.GetUsuarioActual().GetId());

                foreach (Cuenta cuen in cuentas)
                {
                    if (cuen.Id == Convert.ToInt32(comboBox1.SelectedValue))
                    {
                        labelDinero.Text = cuen.GetDineroTotal().ToString();
                    }
                }
            }
            catch (Exception)
            {                
            }
        }
    }
}
