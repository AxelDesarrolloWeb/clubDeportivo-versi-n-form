namespace ClubDeportivo
{
    partial class frmCuotaDatos
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
            lblNroSocio = new Label();
            txtNroSocio = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNroSocio
            // 
            lblNroSocio.AutoSize = true;
            lblNroSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroSocio.Location = new Point(21, 34);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new Size(257, 28);
            lblNroSocio.TabIndex = 0;
            lblNroSocio.Text = "Ingrese el Número de Socio:";
            // 
            // txtNroSocio
            // 
            txtNroSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNroSocio.Location = new Point(25, 70);
            txtNroSocio.Name = "txtNroSocio";
            txtNroSocio.Size = new Size(319, 34);
            txtNroSocio.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(25, 131);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(149, 49);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(189, 131);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 49);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmCuotaDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 204);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNroSocio);
            Controls.Add(lblNroSocio);
            Name = "frmCuotaDatos";
            Text = "COBRAR CUOTA MENSUAL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNroSocio;
        private TextBox txtNroSocio;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}