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
    class daoUsuario
    {
        private daoCuenta daoCu;

        public void insertUsuario(Usuario usuario)
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into Usuario values(@id ,@nombre, @contra, @tipo, @cantidadApuesta, @sexo, @edad)",
                    conexion);
                comando.Parameters.Add("@id", SqlDbType.Int).Value = usuario.GetId();
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.getNombre();
                comando.Parameters.Add("@contra", SqlDbType.VarChar).Value = usuario.getContra();
                comando.Parameters.Add("@tipo", SqlDbType.VarChar).Value = usuario.getTipo();
                comando.Parameters.Add("@cantidadApuesta", SqlDbType.Decimal).Value = usuario.getCantidad();
                comando.Parameters.Add("@sexo", SqlDbType.VarChar).Value = usuario.getSexo();
                comando.Parameters.Add("@edad", SqlDbType.Int).Value = usuario.getEdad();

                int valor = comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getAll()
        {
            daoCu = new daoCuenta();
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Usuario", conexion);
                SqlDataReader lector = comando.ExecuteReader();

                List<Usuario> usuarios = new List<Usuario>();

                while (lector.Read())
                {
                    int id = Convert.ToInt32(lector["Id"]);
                    Double dinero = Convert.ToDouble(lector["cantidadApuesta"]);
                    String nombre = lector["nombre"].ToString();
                    String sexo = lector["sexo"].ToString();
                    String contra = lector["contraseña"].ToString();
                    int edad = Convert.ToInt32(lector["edad"]);

                    Usuario us = new Usuario(id, dinero, nombre, sexo, edad);
                    us.SetCuentas(daoCu.getAllCuentasWithId(id));
                    us.setContra(contra);
                    usuarios.Add(us);
                }
                Implementación.Instance.setUsuarios(usuarios);
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Usuario> getAllList()
        {
            daoCu = new daoCuenta();
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Usuario", conexion);
                SqlDataReader lector = comando.ExecuteReader();

                List<Usuario> usuarios = new List<Usuario>();

                while (lector.Read())
                {
                    int id = Convert.ToInt32(lector["Id"]);
                    Double dinero = Convert.ToDouble(lector["cantidadApuesta"]);
                    String nombre = lector["nombre"].ToString();
                    String sexo = lector["sexo"].ToString();
                    String contra = lector["contraseña"].ToString();
                    int edad = Convert.ToInt32(lector["edad"]);

                    Usuario us = new Usuario(id, dinero, nombre, sexo, edad);
                    us.SetCuentas(daoCu.getAllCuentasWithId(id));
                    us.setContra(contra);
                    usuarios.Add(us);
                }
                return usuarios;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Usuario getUsuarioAt(int id)
        {
            daoCu = new daoCuenta();
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
            Usuario us = null;
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Usuario where id = " + id, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Double dinero = Convert.ToDouble(lector["cantidadApuesta"]);
                    String nombre = lector["nombre"].ToString();
                    String sexo = lector["sexo"].ToString();
                    String contra = lector["contraseña"].ToString();
                    int edad = Convert.ToInt32(lector["edad"]);

                    us = new Usuario(id, dinero, nombre, sexo, edad);
                    us.SetCuentas(daoCu.getAllCuentasWithId(id));
                    us.setContra(contra);
                }

                return us;
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar usuario");
                return null;
            }
        }

        public void updateUsuario(int id, Usuario usuario)
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("update Usuario " +
                    "set nombre= @nombre, contraseña= @contra, sexo= @sexo, edad = @edad " +
                    "where id = " + id,
                    conexion);

                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.getNombre();
                comando.Parameters.Add("@contra", SqlDbType.VarChar).Value = usuario.getContra();
                comando.Parameters.Add("@sexo", SqlDbType.VarChar).Value = usuario.getSexo();
                comando.Parameters.Add("@edad", SqlDbType.Int).Value = usuario.getEdad();

                int valor = comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteUsuario(int id)
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();

                daoCu = new daoCuenta();
                daoCu.deleteCuentaWithId(id);

                SqlCommand comando = new SqlCommand("delete from usuario where id = " + id,
                    conexion);

                int valor = comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario");
            }
        }
        
        public Boolean EstaUsuario(int id)
        {
            foreach (Usuario item in getAllList())
            {
                if (id == item.GetId())
                {                    
                    return true;
                }
            }
            return false;

        }                      
    }
}
