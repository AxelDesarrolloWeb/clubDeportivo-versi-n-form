namespace ClubDeportivo
{
    partial class frmComprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobante));
            panel1 = new Panel();
            lblComprobante = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblClubDeportivo = new Label();
            panel3 = new Panel();
            lblFechaReal = new Label();
            lblFecha = new Label();
            panel4 = new Panel();
            lblImporte = new Label();
            lblImporteReal = new Label();
            lblActividadReal = new Label();
            lblNumero = new Label();
            lblNombre = new Label();
            lblActividad = new Label();
            lblNumeroReal = new Label();
            lblNombreReal = new Label();
            btnImprimir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblComprobante);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 61);
            panel1.TabIndex = 0;
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblComprobante.Location = new Point(30, 12);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(323, 37);
            lblComprobante.TabIndex = 0;
            lblComprobante.Text = "COMPROBANTE DE PAGO";
            lblComprobante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblClubDeportivo);
            panel2.Location = new Point(12, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 61);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblClubDeportivo
            // 
            lblClubDeportivo.AutoSize = true;
            lblClubDeportivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClubDeportivo.Location = new Point(69, 17);
            lblClubDeportivo.Name = "lblClubDeportivo";
            lblClubDeportivo.Size = new Size(166, 28);
            lblClubDeportivo.TabIndex = 0;
            lblClubDeportivo.Text = "CLUB DEPORTIVO";
            lblClubDeportivo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblFechaReal);
            panel3.Controls.Add(lblFecha);
            panel3.Location = new Point(253, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(166, 61);
            panel3.TabIndex = 0;
            // 
            // lblFechaReal
            // 
            lblFechaReal.AutoSize = true;
            lblFechaReal.Location = new Point(62, 23);
            lblFechaReal.Name = "lblFechaReal";
            lblFechaReal.Size = new Size(85, 20);
            lblFechaReal.TabIndex = 1;
            lblFechaReal.Text = "12/34/5678";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(6, 23);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblImporte);
            panel4.Controls.Add(lblImporteReal);
            panel4.Controls.Add(lblActividadReal);
            panel4.Controls.Add(lblNumero);
            panel4.Controls.Add(lblNombre);
            panel4.Controls.Add(lblActividad);
            panel4.Controls.Add(lblNumeroReal);
            panel4.Controls.Add(lblNombreReal);
            panel4.Location = new Point(12, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(407, 244);
            panel4.TabIndex = 0;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(210, 211);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(143, 20);
            lblImporte.TabIndex = 1;
            lblImporte.Text = "Importe Abonado: $";
            // 
            // lblImporteReal
            // 
            lblImporteReal.AutoSize = true;
            lblImporteReal.Location = new Point(359, 211);
            lblImporteReal.Name = "lblImporteReal";
            lblImporteReal.Size = new Size(41, 20);
            lblImporteReal.TabIndex = 1;
            lblImporteReal.Text = "1000";
            // 
            // lblActividadReal
            // 
            lblActividadReal.AutoSize = true;
            lblActividadReal.Location = new Point(195, 78);
            lblActividadReal.Name = "lblActividadReal";
            lblActividadReal.Size = new Size(17, 20);
            lblActividadReal.TabIndex = 1;
            lblActividadReal.Text = "0";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(9, 46);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(84, 20);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número de";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(9, 78);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(173, 20);
            lblActividad.TabIndex = 1;
            lblActividad.Text = "Actividades Contratadas:";
            // 
            // lblNumeroReal
            // 
            lblNumeroReal.AutoSize = true;
            lblNumeroReal.Location = new Point(195, 46);
            lblNumeroReal.Name = "lblNumeroReal";
            lblNumeroReal.Size = new Size(81, 20);
            lblNumeroReal.TabIndex = 0;
            lblNumeroReal.Text = "123456789";
            // 
            // lblNombreReal
            // 
            lblNombreReal.AutoSize = true;
            lblNombreReal.Location = new Point(82, 12);
            lblNombreReal.Name = "lblNombreReal";
            lblNombreReal.Size = new Size(140, 20);
            lblNombreReal.TabIndex = 0;
            lblNombreReal.Text = "NOMBRE APELLIDO";
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(289, 396);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(130, 44);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmComprobante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 452);
            Controls.Add(btnImprimir);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "frmComprobante";
            Text = "Comprobante de Pago";
            Load += frmComprobante_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblComprobante;
        private Panel panel2;
        private Label lblClubDeportivo;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label lblFecha;
        private Label lblFechaReal;
        private Label lblActividad;
        private Label lblImporte;
        private Label lblNombreReal;
        private Label lblImporteReal;
        private Label lblActividadReal;
        private Button btnImprimir;
        private Label lblNombre;
        private Label lblNumero;
        private Label lblNumeroReal;
    }
}