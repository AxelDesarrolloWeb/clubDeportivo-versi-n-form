using ClubDeportivoForms.Entidades;
using K4os.Compression.LZ4.Streams.Frames;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoForms.Datos {
    internal static class Actividad {
        public static List<string> CargarActividades() {
            List<string> Actividades = new List<string>();
            MySqlConnection sqlCon = new MySqlConnection();

            try {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT nombreActividad FROM actividades;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;

                reader = comando.ExecuteReader();

                if( reader.HasRows) {
                    while (reader.Read()) {
                        Actividades.Add(reader["nombreActividad"].ToString());
                    }
                } catch( Exception ex) {
                    MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } finally {
                    if(sqlCon.State == ConnectionState.Open) 
                    {
                        sqlCon.Close();
                    }
                }

                return Actividades;

                
            }

            public static int RevisarCupo(string actividad) {
                MySqlConnection sqlCon = new MySqlConnection();
                int cupo = 0;

                try {
                    string query;
                    sqlCon = Connection.getInstancia().CrearConexion();
                    query = ("SELECT cupoDisponible FROM actividades WHERE nombreActividad = '" + actividad + "'");

                    MySqlComand comando = new MySqlCommand(query, sqlCon);
                    comando.CommandType = CommandType.Text;
                    sqlCon.Open();

                    MySqlDataReader reader;

                    reader = comando.ExecuteReader();

                    if (reader.HasRows) {
                        reader.Read();
                        cupo = reader.GetInt32(0);
                    }


                } catch  (Exception ex) {
                    MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxButtons.Error);

                } finally {
                    if(sqlCon.State == ConnectionState.Open) {
                        sqlCon.Close();
                    }

                }

                return cupo;
                
            }

            public static void RestarCupo(string actividad) {
                MySqlConnection sqlCon = new MySqlConnection();

                try {
                    sqlCon = Conexion.getInstancia().CrearConexion();
                    MySqlCommand comando = new MySqlCommand("restarCupo", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("actividad", MySqlDbType.Varchar).Value = actividad;

                    sqlCon.Open();
                    comando.ExecuteNonQuery();

                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, "MENSAJE DEL CATCH");

                } finally {
                    if(sqlCon.State == ConnectionState.Open) {
                        sqlCon.Close();
                    }
                }
            }

            public static double BuscarPrecio(string actividad) {
                MySqlConnection sqlCon = new MySqlConnection();
                double precio = 0;

                try {
                    string query;

                    sqlCon = Conexion.getInstancia().CrearConexion();

                    query = ("SELECT precioDiario FROM actividades WHERE nombreActividad =" + "'" + actividad + "'");

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.CommandType = CommandType.Text;

                    sqlCon.Open();
                    MySqlDataReader reader;

                    reader = comando.ExecuteReader();

                    reader.Read();

                    precio = reader.GetDouble(0);

                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, "MENSAJE DEL CATCH...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } finally {
                    if(sqlCon.State == ConnectionState.Open) {
                        sqlCon.Close();
                    }
                }

                return precio;
            }
        }
    }
}
