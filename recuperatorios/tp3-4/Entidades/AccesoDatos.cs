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
            connectionString = @"Data Source=DESKTOP-3KL5VD1\SQLEXPRESS;Initial Catalog=TP_4;Integrated Security=True;";
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

        public static int GuardarAfiliado(Afiliado afiliado)
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
                    return command.ExecuteNonQuery();
                }
                else return 0;
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

        public static List<Profesional> LeerProfesionales()
        {
            List<Profesional> profesionales = new List<Profesional>();

            try
            {
                connection.Open();

                command.CommandText = "SELECT P.*, Pr.Especialidad FROM Persona P INNER JOIN Profesional Pr ON P.Id = Pr.IdPersona";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        profesionales.Add(new Profesional(Convert.ToInt32(dataReader["Id"].ToString()), dataReader["Apellido"].ToString(),
                            dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["DNI"]), dataReader["Email"].ToString(),
                            Convert.ToInt32(dataReader["Telefono"].ToString()), (EEspecialidad)Convert.ToInt32(dataReader["Especialidad"])));
                    }
                }

                return profesionales;
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

        public static List<Atencion> LeerAtenciones()
        {
            List<Atencion> atenciones = new List<Atencion>();

            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM Atencion";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        atenciones.Add(new Atencion(Convert.ToInt32(dataReader["IdAfiliado"].ToString()), Convert.ToInt32(dataReader["idProfesional"]),
                            (DateTime)dataReader["fecha"]));
                    }
                }

                return atenciones;
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

        public static void GuardarAtencion(string idAfiliado, string idProfesional, DateTime fecha)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"INSERT INTO Atencion VALUES (@IdAfiliado, @IdProfesional, @Fecha)";
                command.Parameters.AddWithValue("@IdAfiliado", idAfiliado);
                command.Parameters.AddWithValue("@IdProfesional", idProfesional);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.ExecuteNonQuery();            
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

        public static void EliminarAtencion(int idAfiliado, int idProfesional, DateTime fecha)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"DELETE FROM Atencion WHERE IdAfiliado = @IdAfiliado AND IdProfesional = @IdProfesional and Fecha = @Fecha";
                command.Parameters.AddWithValue("@IdAfiliado", idAfiliado);
                command.Parameters.AddWithValue("@IdProfesional", idProfesional);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.ExecuteNonQuery();
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
    }
}
