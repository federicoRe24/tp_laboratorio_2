using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AccesoDatos
    {
        private static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static AccesoDatos()
        {
            connectionString = @"Data Source=DESKTOP-3KL5VD1\SQLEXPRESS;Initial Catalog=UTN_DB;Integrated Security=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static List<Afiliado> LeerAfiliados()
        {
            List<Afiliado> afiliados = new List<Afiliado>();

            try
            {
                connection.Open();

                command.CommandText = "SELECT P.*, A.IsActivo FROM Persona P INNER JOIN Afiliado A ON P.Id = A.IdPersona";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        afiliados.Add(new Afiliado(Convert.ToInt32(dataReader["Id"].ToString()), dataReader["Apellido"].ToString(), 
                            dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["DNI"]), dataReader["Email"].ToString(), 
                            Convert.ToInt32(dataReader["Telefono"].ToString()), (bool)dataReader["IsActivo"]));
                    }
                }

                return afiliados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EliminarAfiliado(int id)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"DELETE FROM Afiliado WHERE IDPersona = {id}";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                    EliminarPersona(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EliminarPersona(int id)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = $"DELETE FROM Persona WHERE ID = {id}";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void GuardarAfiliado(Afiliado afiliado)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                int idPersona = GuardarPersona(afiliado.Apellido, afiliado.Nombre, afiliado.DNI, afiliado.Email, afiliado.Telefeno);
                if (idPersona > 0)
                {
                    int isActivo = afiliado.IsActivo == true ? 1 : 0;

                    command.Parameters.Clear();
                    command.CommandText = $"INSERT INTO Afiliado VALUES ({idPersona}, {(isActivo)})";
                    command.Parameters.AddWithValue("@IdPersona", idPersona);
                    command.Parameters.AddWithValue("@IsActivo", afiliado.IsActivo);
                    command.ExecuteNonQuery();
                }             
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static int GuardarPersona(string apellido, string nombre, int dni, string email, int telefono)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = $"INSERT INTO Persona VALUES ('{apellido}', '{nombre}', {dni}, '{email}', {telefono})";
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Telefono", telefono);
                int rows = command.ExecuteNonQuery();
                int lastId = 0;

                if (rows > 0)
                {
                    command.CommandText = $"SELECT MAX(id) FROM Persona";
                    lastId = Convert.ToInt32(command.ExecuteScalar());
                }

                return lastId;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
