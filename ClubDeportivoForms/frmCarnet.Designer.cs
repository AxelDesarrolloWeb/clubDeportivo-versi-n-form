namespace ClubDeportivoForms {
    partial class frmCarnet {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        private System.ComponentModel.Icontainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        protected override void Dispose(bool disposing) {
            if(disposing && (components !=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do to modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnet));
            plnCarnet = new Panel();
            btnImprimir = new Button();
            pictureBox1 = new PictureBox();
            lblNroSocio = new Label();
            lblTituloCarnet = new Label();
            lblNombre = new Label();
            plnCarnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // plnCarnet
            //
            plnCarnet.BackgroundImage = (Image)resources.GetObject("plnCarnet.BackgroundImage");
            plnCarnet.Constrols.Add(btnImprimir);
            plnCarnet.Constrols.Add(pictureBox1);
            plnCarnet.Constrols.Add(lblNroSocio);
            plnCarnet.Constrols.Add(lblTituloCarnet);
            plnCarnet.Constrols.Add(lblNombre);
            plnCarnet.Dock = DockStyle.Fill;
            plnCarnet.Location = new Point(0,0);
            plnCarnet.Name = "plnCarnet";
            plnCarnet.Size = new Size(424,235);
            plnCarnet.TabIndex = 0;
            //
            // btnImprimir
            //
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(279, 165);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(117,53);
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click = btnImprimir_Click;
            //
            // pictureBox1
            //
            pictureBox1.Image = (Image).resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304,17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92,85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            //
            // lblNroSocio
            //
            lblNroSocio.AutoSize = true;
            lblNroSocio.BackColor = Color.Transparent;
            lblNroSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroSocio.Location = new Point(25,137);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new Size(111,28);
            lblNroSocio.TabIndex = 0;
            lblNroSocio.Text = "123456789";
            // 
            // lblTituloCarnet
            // 
             lblNroSocio.AutoSize = true;
            lblNroSocio.BackColor = Color.Transparent;
            lblNroSocio.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroSocio.Location = new Point(15,43);
            lblNroSocio.Name = "lblTituloCarnet";
            lblNroSocio.Size = new Size(274,35);
            lblNroSocio.TabIndex = 0;
            lblNroSocio.Text = "CLUB DEPORTIVO";
            //
            // lblNombre
            //
            lblNroSocio.AutoSize = true;
            lblNroSocio.BackColor = Color.Transparent;
            lblNroSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroSocio.Location = new Point(25,165);
            lblNroSocio.Name = "lblNombre";
            lblNroSocio.Size = new Size(184,28);
            lblNroSocio.TabIndex = 0;
            lblNroSocio.Text = "NOMBRE APELLIDO";
            //
            // frmCarnet
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 235);
            Constrols.Add(plnCarnet);
            Name = "frmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carnet de Socio";
            Load += frmCarnet_Load;
            plnCarnet.ResumeLayout(false);
            plnCarnet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1.EndInit());
            ResumeLayout(false);

        }
        #endregion

        private Panel pnlCarnet;
        private Button btnImprimir;
        private Label lblNroSocio;
        private Label lblNombre;
        private Label lblTituloCarnet;
        private Panel panel1;
        private PictureBox pictureBox1;        
    }
}