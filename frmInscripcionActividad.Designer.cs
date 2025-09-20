namespace ClubDeportivo
{
    partial class frmInscripcionActividad
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
            components = new System.ComponentModel.Container();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblActividad = new Label();
            cboActividades = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            conexionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(35, 32);
            lblNumero.Margin = new Padding(4, 0, 4, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(199, 28);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Ingrese el Número de";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(35, 64);
            txtNumero.Margin = new Padding(4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(357, 34);
            txtNumero.TabIndex = 1;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(35, 119);
            lblActividad.Margin = new Padding(4, 0, 4, 0);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(295, 28);
            lblActividad.TabIndex = 2;
            lblActividad.Text = "Seleccione la Actividad a realizar";
            // 
            // cboActividades
            // 
            cboActividades.FormattingEnabled = true;
            cboActividades.Location = new Point(35, 151);
            cboActividades.Margin = new Padding(4);
            cboActividades.Name = "cboActividades";
            cboActividades.Size = new Size(357, 36);
            cboActividades.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(35, 226);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(173, 41);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(219, 226);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(173, 41);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // frmInscripcionActividad
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 304);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cboActividades);
            Controls.Add(lblActividad);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmInscripcionActividad";
            Text = "Inscribir en Actividad";
            Load += frmInscripcionActividad_Load;
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblActividad;
        private ComboBox cboActividades;
        private Button btnAceptar;
        private Button btnCancelar;
        private BindingSource conexionBindingSource;
    }
}