using Microsoft.Reporting.WinForms;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPOOVisual
{
    public partial class FormControl : Form
    {
        daoUsuario daoUs;
        daoCuenta daoCu;
        static String dir = Directory.GetCurrentDirectory();
        String serializationFile = Path.Combine(dir, "usuarios.bin");
        public CatRacerBDDataSet dataSet;
        public SqlDataAdapter tableAdapter;
        public FormControl()
        {
            InitializeComponent();
            MostrarAlAbrirBD();
            obtenerUsuarios();
        }
        

        public void MostrarAlAbrirBD()
        {            
            daoUs = new daoUsuario();
            try
            {                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MostrarAlAbrir()
        {            
            try
            {
                using (Stream stream = File.Open(serializationFile, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    Implementación imp = Implementación.Instance;
                    imp.setUsuarios((List<Usuario>)bformatter.Deserialize(stream));
                }                

                foreach (Usuario us in Implementación.Instance.GetUsuarios())
                {
                    ListViewItem filita = new ListViewItem(us.GetId().ToString());
                    filita.SubItems.Add(us.getNombre().ToString());
                    filita.SubItems.Add(us.getSexo());
                    filita.SubItems.Add(us.getEdad().ToString());
                    filita.SubItems.Add(us.getContra().ToString());
                    gridView1.Rows.Add(filita);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo vacio");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> uses = new List<Usuario>();
            DataGridViewRow row = null;
            foreach (DataGridViewRow lv in gridView1.SelectedRows)
            {
                String id_ = lv.Cells[0].Value.ToString();
                daoUsuario daoUs = new daoUsuario();
                List<Usuario> usuarios = daoUs.getAllList();
                
                row = lv;
                foreach (Usuario us in usuarios)
                {
                    if (us.GetId().ToString().Equals(id_))
                    {
                        uses.Add(us);
                    }
                }
            }
            daoUs = new daoUsuario();
            daoCu = new daoCuenta();
            
            foreach (Usuario usss in uses)
            {
                if (usss.GetId() == Implementación.Instance.GetUsuarioActual().GetId())
                {
                    MessageBox.Show("No puede eliminar su propia cuenta");
                }
                else
                {
                    daoCu.deleteCuentaWithId(usss.GetId());
                    daoUs.deleteUsuario(usss.GetId());                    
                    this.tableAdapter.Update(dataSet.Usuario);
                    gridView1.Rows.Remove(row);
                }                
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
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AbrirFormEnPanel(new Menu1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedIndex != -1 && Convert.ToInt32( textBox3.Text) >= 18)
                {
                    DataRow fila = dataSet.Usuario.NewRow();                    
                    String nombre = textBox1.Text;
                    String contra = Encriptar.GetMD5(textBox2.Text);                    
                    String tipo = "pendiente";
                    String sexo = comboBox1.SelectedItem.ToString();
                    int edad = Convert.ToInt32(textBox3.Text);

                    daoUsuario daoUs = new daoUsuario();

                    Usuario us = new Usuario(0, 0.0, nombre, sexo, edad);
                    us.setContra(contra);
                    us.DefinirTipo(0);

                    daoUs.insertUsuario(us);

                    dataSet.Clear();
                    this.obtenerUsuarios();

                    MessageBox.Show("Éxito al registrar");                    
                    LimpiarCampos();
                }
                else if (Convert.ToInt32(textBox3.Text) <18 || Convert.ToInt32(textBox3.Text) <=-1)
                {
                    MessageBox.Show("Edad inválida");
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /* Acción anterior
            panel1.Controls.Clear();
            AbrirFormEnPanel(new FormRegistrar());
            */
        }

        public void LimpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (gridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow lv in gridView1.SelectedRows)
                {
                    String id_ = lv.Cells[0].Value.ToString();
                    daoUsuario daoUs = new daoUsuario();
                    List<Usuario> usuarios = daoUs.getAllList();
                    foreach (Usuario us in usuarios)
                    {
                        if (us.GetId().ToString().Equals(id_))
                        {                            
                            daoCuenta daoCu = new daoCuenta();
                            daoCu.insertCuentaToIdCuenta(us.GetId(), 0);
                            gridView1.ClearSelection();                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = "C:\\";
                openFileDialog1.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SLDocument sl = new SLDocument(openFileDialog1.FileName);
                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        try
                        {
                            int id = sl.GetCellValueAsInt32(iRow, 1);
                            string nombre = sl.GetCellValueAsString(iRow, 2);
                            string sexo = sl.GetCellValueAsString(iRow, 3);
                            int edad = sl.GetCellValueAsInt32(iRow, 4);
                            Usuario us = new Usuario(id, 0, nombre, sexo, edad);

                            List<Cuenta> cuentas = new List<Cuenta>();
                            for (int i = 2; i < 14; i++)
                            {
                                double dineroInvertido = sl.GetCellValueAsDouble(i, 5);
                                double dineroPerdido = sl.GetCellValueAsDouble(i, 6);
                                double dineroGanado = sl.GetCellValueAsDouble(i, 7);
                                Cuenta cuenta = new Cuenta(dineroInvertido);
                                cuenta.DineroPerdido = dineroPerdido;
                                cuenta.DineroGanado = dineroGanado;
                                cuenta.calcularDineroTotal();
                                cuentas.Add(cuenta);
                            }
                            us.SetCuentas(cuentas);
                            Implementación.Instance.addUsuario(us);
                            iRow++;
                        }                        
                        catch (Exception exe)
                        {
                            MessageBox.Show(exe.Message);
                        }
                    }
                    Implementación.Instance.GuardarUsuarios();
                    MostrarAlAbrir();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Introduzca una opción de reporte");
            }
            else if (comboBox2.SelectedIndex == 0)
            {                
                FormReportUsuario frmRprt = new FormReportUsuario();
                frmRprt.ShowDialog();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                FormReportCuentas frmRprt = new FormReportCuentas();
                frmRprt.ShowDialog();
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                FormReporteUsuarioCuenta frmRprt = new FormReporteUsuarioCuenta();
                frmRprt.ShowDialog();
            }            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow lv in gridView1.SelectedRows)
                {
                    String id_ = lv.Cells[0].Value.ToString();
                    
                    if (listView2.SelectedItems.Count != 0)
                    {
                        foreach (ListViewItem lv2 in listView2.SelectedItems)
                        {
                            try
                            {                            
                                if (textBox4.Text != "" || Convert.ToInt32(textBox4.Text) >= 1)
                                {
                                
                                    daoCuenta daoCu = new daoCuenta();
                                    Cuenta cuenta = daoCu.getCuentaWithId(Convert.ToInt32(lv2.Text));
                                    cuenta.invertirDinero(Convert.ToInt32(textBox4.Text));                                
                                    daoCu.updateCuenta(Convert.ToInt32(lv2.Text), cuenta);
                                    MessageBox.Show("Cuenta actualizada");
                                    gridView1.ClearSelection();
                                }
                                else if (Convert.ToInt32(textBox4.Text) <= 0)
                                {
                                    MessageBox.Show("Introduzca una cantidad válida");
                                }
                                else
                                {
                                    MessageBox.Show("Introduzca una cantidad en el campo de dinero");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Introduzca una cantidad en el campo de dinero");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una cuenta");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }

        private void FormControl_Load(object sender, EventArgs e)
        {            
            button2.Image = Image.FromFile(dir+ "//img//salir.gif");
            btnC1.Image = Image.FromFile(dir + "//img//eliminar.gif");
            button3.Image = Image.FromFile(dir + "//img//registrar.gif");
            button5.Image = Image.FromFile(dir + "//img//fondos.gif");
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void obtenerUsuarios()
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Usuario", conexion);
                tableAdapter = new SqlDataAdapter(comando);
                dataSet = new CatRacerBDDataSet();

                tableAdapter.Fill(dataSet);


                gridView1.DataSource = dataSet.Tables[3];                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_CurrentCellChanged_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow lv in gridView1.SelectedRows)
            {
                listView2.Items.Clear();
                String id_ = lv.Cells[0].Value.ToString();
                daoUsuario daoUs = new daoUsuario();
                List<Usuario> usuarios = daoUs.getAllList();
                foreach (Usuario us in usuarios)
                {
                    if (us.GetId().ToString().Equals(id_))
                    {
                        textBox1.Text = us.getNombre();
                        textBox2.Text = us.getContra();
                        textBox3.Text = us.Edad.ToString();
                        if (us.Sexo == "Femenino")
                        {
                            comboBox1.SelectedIndex = 0;
                        }
                        else if (us.Sexo == "Masculino")
                        {
                            comboBox1.SelectedIndex = 1;
                        }
                        else
                        {
                            comboBox1.SelectedIndex = 2;
                        }
                        daoCuenta daoCu = new daoCuenta();
                        List<Cuenta> cuentas = daoCu.getAllCuentasWithId(Convert.ToInt32(id_));
                        foreach (Cuenta cuen in cuentas)
                        {
                            cuen.calcularDineroTotal();
                            ListViewItem filita2 = new ListViewItem(cuen.Id.ToString());
                            filita2.SubItems.Add(cuen.DineroInvertido.ToString());
                            filita2.SubItems.Add(cuen.DineroGanado.ToString());
                            filita2.SubItems.Add(cuen.DineroPerdido.ToString());
                            filita2.SubItems.Add(cuen.GetDineroTotal().ToString());
                            listView2.Items.Add(filita2);
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try {                
                if (gridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No hay nada que actualizar");
                    return;
                }                
                int a = Convert.ToInt32(textBox3.Text);
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedIndex != -1)
                {
                    String id_ = null;
                    foreach (DataGridViewRow lv in gridView1.SelectedRows)
                    {
                        id_ = lv.Cells[0].Value.ToString();
                    }

                    daoUsuario daoUs = new daoUsuario();

                    int id = Convert.ToInt32(id_);
                    
                    String nom = textBox1.Text;

                    
                    

                    
                    Double cant = 0;
                    String tipo = "pendiente";
                    String sexo = comboBox1.SelectedItem.ToString();
                    int edad = Convert.ToInt32(textBox3.Text);

                    Usuario us = new Usuario(0, 0.0, nom, sexo, edad);

                    MessageBox.Show(textBox2.Text.Length.ToString());

                    if (textBox2.Text.Length != 32)
                    {
                        String contra = Encriptar.GetMD5(textBox2.Text);
                        us.setContra(contra);
                    }
                    else
                    {
                        us.setContra("a_");
                    }
                    

                    daoUs.updateUsuario(id, us);
                    dataSet.Clear();
                    this.obtenerUsuarios();

                    MessageBox.Show("Usuario Actualizado");
                    LimpiarCampos();
                }
                else if (gridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No hay usuario seleccionado");
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            gridView1.ClearSelection();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
