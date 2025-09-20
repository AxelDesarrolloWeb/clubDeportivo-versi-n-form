using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmVencimientos : Form
    {
        public frmVencimientos()
        {
            InitializeComponent();
        }

        private void frmVencimientos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT s.IDsocio as 'Numero de Socio', CONCAT(s.nombreSocio, ' ', s.apellidoSocio) as Nombre, importeTotal as 'Total a Abonar' FROM socio s INNER JOIN pagos p ON s.IDsocio = p.IDsocio WHERE p.fechaVencimiento = CURRENT_DATE() ORDER BY s.IDsocio;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvVencimientos.Rows.Add();
                        dtgvVencimientos.Rows[renglon].Cells[0].Value = reader.GetInt32(0);
                        dtgvVencimientos.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvVencimientos.Rows[renglon].Cells[2].Value = reader.GetDecimal(2);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY VENCIMIENTOS EN EL DÍA DE LA FECHA", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
