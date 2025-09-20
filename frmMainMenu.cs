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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Close();
        }

        private void btnVencimientos_Click(object sender, EventArgs e)
        {
            frmVencimientos vencimientos = new frmVencimientos();
            vencimientos.Show();
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            frmEntregaCarnet entregaCarnet = new frmEntregaCarnet();
            entregaCarnet.Show();
            this.Close();
        }

        private void btnCuota_Click(object sender, EventArgs e)
        {
            frmCuotaDatos cuotaDatos = new frmCuotaDatos();
            cuotaDatos.Show();
            this.Close();
        }

        private void btnInscribirActividad_Click(object sender, EventArgs e)
        {
            frmInscripcionActividad inscripcion = new frmInscripcionActividad();

            DialogResult socioClub = MessageBox.Show("¿El usuario es socio del Club?", "Inscribir Actividad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (socioClub == DialogResult.Yes)
            {
                inscripcion.condicionUsuario = "Socio";
            }
            else
            {
                inscripcion.condicionUsuario = "Documento";
            }

            inscripcion.Show();
            this.Close();
        }
    }
}
