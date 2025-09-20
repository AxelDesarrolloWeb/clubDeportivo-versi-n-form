using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
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
    public partial class frmCuotaDatos : Form
    {
        public frmComprobante comprobante = new frmComprobante();

        public frmCuotaDatos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            comprobante.condicion = "Socio";

            int IDsocio;
            bool esNumero = int.TryParse(txtNroSocio.Text, out IDsocio);

            if (esNumero)
            {
                try
                {
                    string query;

                    sqlCon = Conexion.getInstancia().CrearConexion();

                    query = ("SELECT s.IDsocio, CONCAT(nombreSocio, ' ', apellidoSocio), cantidadActividades, importeTotal, estado FROM pagos p INNER JOIN socio s ON p.IDsocio = s.IDsocio WHERE p.IDsocio =" + IDsocio + " ORDER BY fechaVencimiento DESC LIMIT 1");

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.CommandType = CommandType.Text;
                    sqlCon.Open();
                    MySqlDataReader reader;

                    reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {

                        reader.Read();

                        if (reader.GetInt32(4) == 0)
                        {
                            comprobante.numero = reader.GetInt32(0);
                            comprobante.nombre = reader.GetString(1);
                            comprobante.cantActiv = reader.GetInt32(2);
                            comprobante.importe = reader.GetDouble(3);

                            comprobante.Show();
                            this.Hide();

                            Datos.Pagos.PagarCuota(IDsocio);
                        }
                        else
                        {
                            MessageBox.Show("El Socio Ingresado No tiene Cuotas Pendientes de Pago", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            else
            {
                MessageBox.Show("Ingrese sólo números", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
