using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmEntregaCarnet : Form
    {
        public frmCarnet carnet = new frmCarnet();

        public frmEntregaCarnet()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();

                query = ("SELECT IDsocio, CONCAT(apellidoSocio, ' ', nombreSocio) FROM socio WHERE IDsocio = " + txtIDSocioEntregaCarnet.Text);

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;

                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    carnet.nroSocio = reader.GetInt32(0);
                    carnet.nombre = reader.GetString(1);

                    carnet.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Número de Socio inexistente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
