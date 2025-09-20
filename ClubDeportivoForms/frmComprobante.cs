using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmComprobante : Form
    {
        public frmComprobante()
        {
            InitializeComponent();
        }

        public string condicion;

        public int numero;
        public string nombre;
        public string actividad;
        public int cantActiv;
        public double importe;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirComprobante);
            pd.Print();

            btnImprimir.Visible = true;

            MessageBox.Show("Operación Exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void ImprimirComprobante(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void frmComprobante_Load(object sender, EventArgs e)
        {
            if (condicion == "Socio")
            {
                lblActividad.Text = "Actividades Contratadas";
                lblNumero.Text += " Socio:";
                lblActividadReal.Text = Convert.ToString(cantActiv);
            }
            else
            {
                lblActividad.Text = "Actividad Realizada:";
                lblNumero.Text += " Documento:";
                lblActividadReal.Text = actividad;
            }

            lblFechaReal.Text = DateTime.UtcNow.ToShortDateString();
            lblNombreReal.Text = nombre;
            lblNumeroReal.Text = Convert.ToString(numero);
            lblImporteReal.Text = Convert.ToString(importe);

        }
    }
}
