using System;
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
    public partial class login : Form
    {
        private Boolean banderita = false;
        private daoUsuario daoUs;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string nombre = tbUsuario.Text;
                string password_e = Encriptar.GetMD5(tbPassword.Text.Trim());                

                SqlCommand comando = new SqlCommand("Select nombre, id from Usuario " +
                "where nombre = @nombre and contraseña = @password", conexion);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = password_e;

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    MessageBox.Show("Bienvenido " + lector["nombre"].ToString());
                    daoUs = new daoUsuario();
                    Implementación.Instance.setUsuarioActual(daoUs.getUsuarioAt(Convert.ToInt32(lector["id"].ToString())));
                    banderita = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
                conexion.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (banderita == false)
            {                
                Application.Exit();                
            }
        }
    }
}
