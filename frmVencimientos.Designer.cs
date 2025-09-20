namespace ClubDeportivo
{
    partial class frmVencimientos
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
            lblVencimientos = new Label();
            dtgvVencimientos = new DataGridView();
            IDsocio = new DataGridViewTextBoxColumn();
            nombreSocio = new DataGridViewTextBoxColumn();
            importeTotal = new DataGridViewTextBoxColumn();
            conexionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dtgvVencimientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblVencimientos
            // 
            lblVencimientos.AutoSize = true;
            lblVencimientos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVencimientos.Location = new Point(22, 24);
            lblVencimientos.Name = "lblVencimientos";
            lblVencimientos.Size = new Size(587, 28);
            lblVencimientos.TabIndex = 0;
            lblVencimientos.Text = "En el día de la fecha se vencen las cuotas de los siguentes usuarios:";
            // 
            // dtgvVencimientos
            // 
            dtgvVencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVencimientos.Columns.AddRange(new DataGridViewColumn[] { IDsocio, nombreSocio, importeTotal });
            dtgvVencimientos.Location = new Point(99, 94);
            dtgvVencimientos.Name = "dtgvVencimientos";
            dtgvVencimientos.RowHeadersWidth = 51;
            dtgvVencimientos.RowTemplate.Height = 29;
            dtgvVencimientos.Size = new Size(429, 223);
            dtgvVencimientos.TabIndex = 1;
            // 
            // IDsocio
            // 
            IDsocio.HeaderText = "Numero de Socio";
            IDsocio.MinimumWidth = 6;
            IDsocio.Name = "IDsocio";
            IDsocio.Width = 125;
            // 
            // nombreSocio
            // 
            nombreSocio.HeaderText = "Nombre";
            nombreSocio.MinimumWidth = 6;
            nombreSocio.Name = "nombreSocio";
            nombreSocio.Width = 125;
            // 
            // importeTotal
            // 
            importeTotal.HeaderText = "Importe a Abonar";
            importeTotal.MinimumWidth = 6;
            importeTotal.Name = "importeTotal";
            importeTotal.Width = 125;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // frmVencimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 382);
            Controls.Add(dtgvVencimientos);
            Controls.Add(lblVencimientos);
            Name = "frmVencimientos";
            Text = "VENCIMIENTOS DEL DIA";
            Load += frmVencimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvVencimientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVencimientos;
        private DataGridView dtgvVencimientos;
        private BindingSource conexionBindingSource;
        private DataGridViewTextBoxColumn IDsocio;
        private DataGridViewTextBoxColumn nombreSocio;
        private DataGridViewTextBoxColumn importeTotal;
    }
}