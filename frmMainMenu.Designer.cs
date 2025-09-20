namespace ClubDeportivo
{
    partial class frmMainMenu
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
            btnRegistro = new Button();
            lblMain = new Label();
            btnVencimientos = new Button();
            btnCarnet = new Button();
            btnCuota = new Button();
            btnInscribirActividad = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.Location = new Point(52, 103);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(312, 99);
            btnRegistro.TabIndex = 1;
            btnRegistro.Text = "Registrar Nuevo Socio / No Socio";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMain.Location = new Point(175, 35);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(428, 38);
            lblMain.TabIndex = 1;
            lblMain.Text = "¿Qué acción desea realizar hoy?";
            // 
            // btnVencimientos
            // 
            btnVencimientos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVencimientos.Location = new Point(402, 103);
            btnVencimientos.Name = "btnVencimientos";
            btnVencimientos.Size = new Size(312, 99);
            btnVencimientos.TabIndex = 2;
            btnVencimientos.Text = "Vencimientos del Día";
            btnVencimientos.UseVisualStyleBackColor = true;
            btnVencimientos.Click += btnVencimientos_Click;
            // 
            // btnCarnet
            // 
            btnCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarnet.Location = new Point(52, 219);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(312, 99);
            btnCarnet.TabIndex = 3;
            btnCarnet.Text = "Entrega de Carnet";
            btnCarnet.UseVisualStyleBackColor = true;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // btnCuota
            // 
            btnCuota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuota.Location = new Point(402, 219);
            btnCuota.Name = "btnCuota";
            btnCuota.Size = new Size(312, 99);
            btnCuota.TabIndex = 4;
            btnCuota.Text = "Cobrar Cuota";
            btnCuota.UseVisualStyleBackColor = true;
            btnCuota.Click += btnCuota_Click;
            // 
            // btnInscribirActividad
            // 
            btnInscribirActividad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscribirActividad.Location = new Point(52, 338);
            btnInscribirActividad.Name = "btnInscribirActividad";
            btnInscribirActividad.Size = new Size(312, 99);
            btnInscribirActividad.TabIndex = 5;
            btnInscribirActividad.Text = "Inscribir en Actividad";
            btnInscribirActividad.UseVisualStyleBackColor = true;
            btnInscribirActividad.Click += btnInscribirActividad_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(402, 338);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(312, 99);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(lblMain);
            Controls.Add(btnLogout);
            Controls.Add(btnCuota);
            Controls.Add(btnVencimientos);
            Controls.Add(btnInscribirActividad);
            Controls.Add(btnCarnet);
            Controls.Add(btnRegistro);
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU PRINCIPAL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistro;
        private Label lblMain;
        private Button btnVencimientos;
        private Button btnCarnet;
        private Button btnCuota;
        private Button btnInscribirActividad;
        private Button btnLogout;
    }
}