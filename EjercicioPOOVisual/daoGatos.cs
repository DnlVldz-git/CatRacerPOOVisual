using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPOOVisual
{
    class daoGatos
    {

        public void insertarGato(string nombre)
        {
            List<Gatos> gatos = getAll();
            foreach (Gatos gato in gatos)
            {
                if (gato.Nombre == nombre)
                {                    
                    throw new Exception("Error nombre existente");
                }
            }
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into gatos values(@nombre)",
                    conexion);
                
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                
                int valor = comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar gato");
            }
        }

        public List<Gatos> getAll()
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            List<Gatos> gatos = new List<Gatos>();

            try
            {

                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from gatos", conexion);
                SqlDataReader lector = comando.ExecuteReader();

                List<Usuario> usuarios = new List<Usuario>();

                while (lector.Read())
                {
                    int id = Convert.ToInt32(lector["Id"]);                    
                    String nombre= lector["nombre"].ToString();

                    Gatos gato = new Gatos(id, nombre);

                    gatos.Add(gato);
                }
                Implementación.Instance.setUsuarios(usuarios);
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar los gatos");
            }
            return gatos;
        }

        public void deleteGato(int id)
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("delete from gatos where id = " + id,
                    conexion);

                int valor = comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar gato");
            }
        }

    }
}
