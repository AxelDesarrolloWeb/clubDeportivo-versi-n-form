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
    internal static class  Actividad {
        public static List<string> CargarActividades() {
            List<string> Actividades = new List<string>();
            MySqlConnection sqlCon = new MySqlConnection();

            try {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT nombreActividad FROM actividades;";
            }
        }
    }
}
