namespace pryInfracciones
{
    partial class frmSistemaDeInfracciones
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
            grpDatosActa = new GroupBox();
            btnRegistrar = new Button();
            txtMonto = new TextBox();
            lblMonto = new Label();
            cmbInfraccion = new ComboBox();
            lblTipoDeInfraccion = new Label();
            txtDominio = new TextBox();
            lblDominio = new Label();
            txtNroActa = new TextBox();
            lblNroActa = new Label();
            dgvInfracciones = new DataGridView();
            colNroActa = new DataGridViewTextBoxColumn();
            colDominio = new DataGridViewTextBoxColumn();
            colInfraccion = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            grpDatosActa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfracciones).BeginInit();
            SuspendLayout();
            // 
            // grpDatosActa
            // 
            grpDatosActa.Controls.Add(btnRegistrar);
            grpDatosActa.Controls.Add(txtMonto);
            grpDatosActa.Controls.Add(lblMonto);
            grpDatosActa.Controls.Add(cmbInfraccion);
            grpDatosActa.Controls.Add(lblTipoDeInfraccion);
            grpDatosActa.Controls.Add(txtDominio);
            grpDatosActa.Controls.Add(lblDominio);
            grpDatosActa.Controls.Add(txtNroActa);
            grpDatosActa.Controls.Add(lblNroActa);
            grpDatosActa.Location = new Point(12, 12);
            grpDatosActa.Name = "grpDatosActa";
            grpDatosActa.Size = new Size(353, 218);
            grpDatosActa.TabIndex = 0;
            grpDatosActa.TabStop = false;
            grpDatosActa.Text = "Ingreso de Infracciones";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(285, 171);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(62, 41);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar ";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(77, 146);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 8;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(6, 149);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(60, 15);
            lblMonto.TabIndex = 6;
            lblMonto.Text = "Monto ($)";
            // 
            // cmbInfraccion
            // 
            cmbInfraccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInfraccion.FormattingEnabled = true;
            cmbInfraccion.Items.AddRange(new object[] { "Exceso de velocidad", "Mal estacionado", "Semáforo en rojo" });
            cmbInfraccion.Location = new Point(118, 109);
            cmbInfraccion.Name = "cmbInfraccion";
            cmbInfraccion.Size = new Size(121, 23);
            cmbInfraccion.TabIndex = 5;
            // 
            // lblTipoDeInfraccion
            // 
            lblTipoDeInfraccion.AutoSize = true;
            lblTipoDeInfraccion.Location = new Point(6, 112);
            lblTipoDeInfraccion.Name = "lblTipoDeInfraccion";
            lblTipoDeInfraccion.Size = new Size(106, 15);
            lblTipoDeInfraccion.TabIndex = 4;
            lblTipoDeInfraccion.Text = "Tipo De Infraccion:";
            // 
            // txtDominio
            // 
            txtDominio.Location = new Point(110, 71);
            txtDominio.MaxLength = 7;
            txtDominio.Name = "txtDominio";
            txtDominio.Size = new Size(100, 23);
            txtDominio.TabIndex = 3;
            // 
            // lblDominio
            // 
            lblDominio.AutoSize = true;
            lblDominio.Location = new Point(6, 74);
            lblDominio.Name = "lblDominio";
            lblDominio.Size = new Size(98, 15);
            lblDominio.TabIndex = 2;
            lblDominio.Text = "Dominio/Patente";
            // 
            // txtNroActa
            // 
            txtNroActa.Location = new Point(77, 32);
            txtNroActa.MaxLength = 6;
            txtNroActa.Name = "txtNroActa";
            txtNroActa.Size = new Size(100, 23);
            txtNroActa.TabIndex = 1;
            // 
            // lblNroActa
            // 
            lblNroActa.AutoSize = true;
            lblNroActa.Location = new Point(6, 35);
            lblNroActa.Name = "lblNroActa";
            lblNroActa.Size = new Size(65, 15);
            lblNroActa.TabIndex = 0;
            lblNroActa.Text = "N° De Acta";
            // 
            // dgvInfracciones
            // 
            dgvInfracciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfracciones.Columns.AddRange(new DataGridViewColumn[] { colNroActa, colDominio, colInfraccion, colMonto });
            dgvInfracciones.Location = new Point(12, 236);
            dgvInfracciones.Name = "dgvInfracciones";
            dgvInfracciones.Size = new Size(353, 202);
            dgvInfracciones.TabIndex = 1;
            // 
            // colNroActa
            // 
            colNroActa.HeaderText = "N° Acta";
            colNroActa.Name = "colNroActa";
            // 
            // colDominio
            // 
            colDominio.HeaderText = "Dominio";
            colDominio.Name = "colDominio";
            // 
            // colInfraccion
            // 
            colInfraccion.HeaderText = "Infracción";
            colInfraccion.Name = "colInfraccion";
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Monto ($)";
            colMonto.Name = "colMonto";
            // 
            // frmSistemaDeInfracciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(dgvInfracciones);
            Controls.Add(grpDatosActa);
            Name = "frmSistemaDeInfracciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Control de Infracciones de Tránsito";
            grpDatosActa.ResumeLayout(false);
            grpDatosActa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfracciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosActa;
        private Label lblNroActa;
        private ComboBox cmbInfraccion;
        private Label lblTipoDeInfraccion;
        private TextBox txtDominio;
        private Label lblDominio;
        private TextBox txtNroActa;
        private Button btnRegistrar;
        private TextBox txtMonto;
        private Label lblMonto;
        private DataGridView dgvInfracciones;
        private DataGridViewTextBoxColumn colNroActa;
        private DataGridViewTextBoxColumn colDominio;
        private DataGridViewTextBoxColumn colInfraccion;
        private DataGridViewTextBoxColumn colMonto;
    }
}