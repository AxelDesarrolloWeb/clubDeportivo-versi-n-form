using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            radCondicionSocio.Checked = false;
            radCondicionNS.Checked = false;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string respuesta;

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDocumento.Text == "" || (!radCondicionSocio.Checked && !radCondicionNS.Checked))
            {
                MessageBox.Show("Debe completar los datos requeridos (*)", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radCondicionSocio.Checked)
            {
                E_Socio socio = new E_Socio();

                socio.NombreS = txtNombre.Text;
                socio.ApellidoS = txtApellido.Text;
                socio.DocS = Convert.ToInt32(txtDocumento.Text);

                Datos.Socio socios = new Datos.Socio();

                respuesta = socios.Nuevo_Socio(socio);

                bool esNumero = int.TryParse(respuesta, out int codigo);

                if (esNumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("SOCIO YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Se almacenó con exito con el Nro de Socio " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        Datos.Pagos.CrearFactura(int.Parse(respuesta));
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtDocumento.Text = "";
                        radCondicionSocio.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("NO SE PUDO REALIZAR EL INGRESO. ERROR DE CONEXIÓN CON LA BASE DE DATOS");
                }
            }
            else if (radCondicionNS.Checked)
            {
                E_NoSocio noSocio = new E_NoSocio();

                noSocio.NombreNoS = txtNombre.Text;
                noSocio.ApellidoNoS = txtApellido.Text;
                noSocio.DocNoS = Convert.ToInt32(txtDocumento.Text);

                Datos.NoSocio noSocios = new Datos.NoSocio();

                respuesta = noSocios.Nuevo_NoSocio(noSocio);

                bool esNumero = int.TryParse(respuesta, out int codigo);

                if (esNumero)
                {
                    if (codigo != 0)
                    {
                        MessageBox.Show("NO SOCIO YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se almacenó con éxito", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtDocumento.Text = "";
                        radCondicionNS.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("NO SE PUDO REALIZAR EL INGRESO. ERROR DE CONEXIÓN CON LA BASE DE DATOS");
                }
            }
        }
    }
}
