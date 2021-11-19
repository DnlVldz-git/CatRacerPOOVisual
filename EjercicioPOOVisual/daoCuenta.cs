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
    class daoCuenta
    {
        public void insertCuentaToIdCuenta(int id, Double dinero)
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("insert into Cuenta values (@id ,@dineroInvertido, @dineroGanado, @dineroPerdido, @dineroTotal)",
                    conexion);
                comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                comando.Parameters.Add("@dineroInvertido", SqlDbType.Decimal).Value = dinero;
                comando.Parameters.Add("@dineroGanado", SqlDbType.Decimal).Value = 0;
                comando.Parameters.Add("@dineroPerdido", SqlDbType.Decimal).Value = 0;
                comando.Parameters.Add("@dineroTotal", SqlDbType.Decimal).Value = dinero;

                int valor = comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar cuenta");
            }
        }
        public void deleteCuentaWithId(int id_cuenta)
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("delete from cuenta where id_cuenta = " + id_cuenta,
                    conexion);                

                int valor = comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cuentas");
            }

        }

        public void updateCuenta(int id, Cuenta cuenta) {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("update Cuenta " +
                    "set dineroInvertido = @dineroInvertido, dineroGanado = @dineroGanado, dineroPerdido = @dineroPerdido, dineroTotal = @dineroTotal " +
                    "where id = " + id,
                    conexion);
                cuenta.calcularDineroTotal();

                comando.Parameters.Add("@dineroInvertido", SqlDbType.Decimal).Value = cuenta.DineroInvertido;
                comando.Parameters.Add("@dineroGanado", SqlDbType.Decimal).Value = cuenta.DineroGanado;
                comando.Parameters.Add("@dineroPerdido", SqlDbType.Decimal).Value = cuenta.DineroPerdido;                
                comando.Parameters.Add("@dineroTotal", SqlDbType.Decimal).Value = cuenta.GetDineroTotal();

                int valor = comando.ExecuteNonQuery();

                

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la cuenta");
            }
        }        
        
        public List<Cuenta> getAllCuentasWithId(int id)
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Cuenta where id_cuenta = " + id, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                List<Cuenta> cuentas = new List<Cuenta>();

                Console.WriteLine(""+1);

                while (lector.Read())
                {
                    int idC = Convert.ToInt32(lector["id"].ToString());
                    Double dineroInvertido = Convert.ToDouble(lector["dineroInvertido"]);
                    Double dineroGanado = Convert.ToDouble(lector["dineroGanado"]);
                    Double dineroPerdido = Convert.ToDouble(lector["dineroPerdido"]);

                    Cuenta cuenta = new Cuenta(dineroInvertido);
                    cuenta.Id = idC;
                    cuenta.DineroGanado = dineroGanado;
                    cuenta.DineroPerdido = dineroPerdido;
                    cuenta.calcularDineroTotal();

                    cuentas.Add(cuenta);
                }
                return cuentas;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        public Cuenta getCuentaWithId(int id)
        {
            string cadena = Properties.Settings.Default.CatRacerBDConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Cuenta where id = " + id, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                Cuenta cuenta = null;

                while (lector.Read())
                {
                    Double dineroInvertido = Convert.ToDouble(lector["dineroInvertido"]);
                    Double dineroGanado = Convert.ToDouble(lector["dineroGanado"]);
                    Double dineroPerdido = Convert.ToDouble(lector["dineroPerdido"]);

                    cuenta =  new Cuenta();
                    cuenta.DineroInvertido = dineroInvertido;
                    cuenta.DineroGanado = dineroGanado;
                    cuenta.DineroPerdido = dineroPerdido;
                    cuenta.calcularDineroTotal();
                }
                return cuenta;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
