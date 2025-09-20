using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class frmInscripcionActividad : Form
    {
        public frmInscripcionActividad()
        {
            InitializeComponent();
            CargarComboBox();
        }

        public string condicionUsuario;

        private void frmInscripcionActividad_Load(object sender, EventArgs e)
        {
            if (condicionUsuario != "Socio")
            {
                btnAceptar.Text = "Realizar Pago";
            }
            lblNumero.Text += (" " + condicionUsuario + ":");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void CargarComboBox()
        {
            List<string> actividades = Datos.Actividad.CargarActividades();
            cboActividades.DataSource = actividades;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int numero;
            bool esNumero = int.TryParse(txtNumero.Text, out numero);
            string actividadElegida = cboActividades.Text;
            int cupoDisponible = Datos.Actividad.RevisarCupo(actividadElegida);

            if (esNumero)
            {
                if (cupoDisponible > 0)
                {
                    if (condicionUsuario == "Socio")
                    {
                        if (Datos.Socio.SocioExiste(numero)) { 
                            bool puedeInscribirse = (Datos.Socio.ActividadesRealizadas(numero)<3);
                            if (puedeInscribirse)
                            {
                                Datos.Socio.SumarActividad(numero);
                                Datos.Actividad.RestarCupo(actividadElegida);
                                MessageBox.Show("Se ha inscripto correctamente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Límite de Actividades Alcanzado", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No existe el socio ingresado", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Datos.Actividad.RestarCupo(actividadElegida);
                        frmComprobante comprobante = new frmComprobante();

                        MySqlConnection sqlCon = new MySqlConnection();

                        try
                        {
                            string query;

                            sqlCon = Conexion.getInstancia().CrearConexion();

                            query = ("SELECT CONCAT(nombreNS, ' ', apellidoNS), documentoNS FROM nosocio WHERE documentoNS =" + numero);

                            MySqlCommand comando = new MySqlCommand(query, sqlCon);
                            comando.CommandType = CommandType.Text;

                            sqlCon.Open();
                            MySqlDataReader reader;

                            reader = comando.ExecuteReader();

                            if (reader.HasRows)
                            {

                                reader.Read();

                                comprobante.nombre = reader.GetString(0);
                                comprobante.numero = reader.GetInt32(1);

                                comprobante.condicion = "NoSocio";
                                comprobante.actividad = actividadElegida;

                                comprobante.importe = Datos.Actividad.BuscarPrecio(actividadElegida);

                                comprobante.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("No existe un usuario con el Documento Ingresado", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else
                {
                    MessageBox.Show("No hay cupo para la actividad seleccionada", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El valor ingresado no es válido", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
