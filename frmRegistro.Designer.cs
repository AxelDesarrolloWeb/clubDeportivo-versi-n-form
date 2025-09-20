namespace ClubDeportivo
{
    partial class frmRegistro
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
            lblRegistro = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDocumento = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            lblCondicion = new Label();
            radCondicionSocio = new RadioButton();
            radCondicionNS = new RadioButton();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistro.Location = new Point(37, 29);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(350, 32);
            lblRegistro.TabIndex = 0;
            lblRegistro.Text = "Por favor complete los datos:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(37, 104);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(109, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre(*):";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(37, 159);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(110, 28);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido(*):";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumento.Location = new Point(37, 212);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(205, 28);
            lblDocumento.TabIndex = 1;
            lblDocumento.Text = "Nro de Documento(*):";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(153, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(380, 34);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(153, 156);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(380, 34);
            txtApellido.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(248, 209);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(285, 34);
            txtDocumento.TabIndex = 3;
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondicion.Location = new Point(37, 266);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(125, 28);
            lblCondicion.TabIndex = 1;
            lblCondicion.Text = "Condición(*):";
            // 
            // radCondicionSocio
            // 
            radCondicionSocio.AutoSize = true;
            radCondicionSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radCondicionSocio.Location = new Point(244, 262);
            radCondicionSocio.Name = "radCondicionSocio";
            radCondicionSocio.Size = new Size(91, 32);
            radCondicionSocio.TabIndex = 4;
            radCondicionSocio.TabStop = true;
            radCondicionSocio.Text = "SOCIO";
            radCondicionSocio.UseVisualStyleBackColor = true;
            // 
            // radCondicionNS
            // 
            radCondicionNS.AutoSize = true;
            radCondicionNS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radCondicionNS.Location = new Point(384, 262);
            radCondicionNS.Name = "radCondicionNS";
            radCondicionNS.Size = new Size(126, 32);
            radCondicionNS.TabIndex = 4;
            radCondicionNS.TabStop = true;
            radCondicionNS.Text = "NO SOCIO";
            radCondicionNS.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(37, 315);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(143, 54);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(215, 315);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(143, 54);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(390, 315);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 54);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 401);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(radCondicionNS);
            Controls.Add(radCondicionSocio);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblCondicion);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblRegistro);
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private Label lblCondicion;
        private RadioButton radCondicionSocio;
        private RadioButton radCondicionNS;
        private Button btnAceptar;
        private Button btnLimpiar;
        private Button btnCancelar;
    }
}