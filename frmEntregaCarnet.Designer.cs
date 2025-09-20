namespace ClubDeportivo
{
    partial class frmEntregaCarnet
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
            lblEntregaCarnet = new Label();
            txtIDSocioEntregaCarnet = new TextBox();
            btnEmitir = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblEntregaCarnet
            // 
            lblEntregaCarnet.AutoSize = true;
            lblEntregaCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEntregaCarnet.Location = new Point(37, 40);
            lblEntregaCarnet.Name = "lblEntregaCarnet";
            lblEntregaCarnet.Size = new Size(257, 28);
            lblEntregaCarnet.TabIndex = 0;
            lblEntregaCarnet.Text = "Ingrese el Número de Socio:";
            // 
            // txtIDSocioEntregaCarnet
            // 
            txtIDSocioEntregaCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDSocioEntregaCarnet.Location = new Point(58, 100);
            txtIDSocioEntregaCarnet.Name = "txtIDSocioEntregaCarnet";
            txtIDSocioEntregaCarnet.Size = new Size(343, 34);
            txtIDSocioEntregaCarnet.TabIndex = 1;
            // 
            // btnEmitir
            // 
            btnEmitir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmitir.Location = new Point(58, 172);
            btnEmitir.Name = "btnEmitir";
            btnEmitir.Size = new Size(161, 48);
            btnEmitir.TabIndex = 2;
            btnEmitir.Text = "Emitir Carnet";
            btnEmitir.UseVisualStyleBackColor = true;
            btnEmitir.Click += btnEmitir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(240, 172);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(161, 48);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmEntregaCarnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 248);
            Controls.Add(btnCancelar);
            Controls.Add(btnEmitir);
            Controls.Add(txtIDSocioEntregaCarnet);
            Controls.Add(lblEntregaCarnet);
            Name = "frmEntregaCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ENTREGA DE CARNET";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEntregaCarnet;
        private TextBox txtIDSocioEntregaCarnet;
        private Button btnEmitir;
        private Button btnCancelar;
    }
}