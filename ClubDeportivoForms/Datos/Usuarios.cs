using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.MySqlClient;
using System.Data;

namespace ClubDeportivoForms.Datos {
    internal class Usuarios {
        public DataTable Log_User(string L_User, string P_User) {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
        
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("User", MySqlDbType.VarChar).Value = L_User;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_User;
            
                sqlCon.Open();

                resultado = comando.ExecuteReader();

                tabla.Load(resultado);

                return tabla;
            
            }

            catch {
                throw;
            }
            finally 
            {
                if(sqlCon.State == ConnectionState.Open) {
                    sqlCon.Close();
                }
            }
        }
    }
}
