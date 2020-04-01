using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace Quizz.AccesoDatos
{

    public class Coneccion
    {
        private string connectionString = @"Data Source=VALVERMA4\SQLEXPRESS;Initial Catalog=Quiz;User ID=Progra3;Password=123456";
        
        private SqlConnection cnn;

        public bool CreaConexion()
        {
            try
            {
                cnn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
            return true;
        }

        public void CerrarConexion()
        {
            try
            {
                cnn.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex);
            }
        }
        public SqlDataReader ConexionSQL(string sql)
        {

            SqlCommand cmd;


            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();
                if (resultado.HasRows)
                {
                    return resultado;
                }
                Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Coneccion.ConexionSQL Error: " + ex.Message);
            }
            // Closing the connection  
            return null;
        }

        public void Nonquery(string sql)
        {
            SqlConnection cnn;
            SqlCommand cmd;

            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Console.WriteLine("  NonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Coneccion.Nonquery Error: " + ex.Message);
            }
            // Closing the connection  
            finally
            {
                cnn.Close();
            }
        }


        public void nonQueryUsing(string query)
        {


            SqlCommand cmd;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    Console.WriteLine("  NonQuery in SqlCommand executed !!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Coneccion.Nonquery Error: " + ex.Message);
                }
            }


        }



        public SqlDataReader QueryUsing(string query)
        {


            SqlCommand cmd;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    cmd = new SqlCommand(query, connection);

                    SqlDataReader resultado = cmd.ExecuteReader();

                    cmd.Dispose();
                    if (resultado.HasRows)
                    {
                        return resultado;
                    }
                    Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Coneccion.ConexionSQL Error: " + ex.Message);
                }
            }
            return null;


        }





    }
}

