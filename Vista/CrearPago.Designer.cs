namespace Vista
{
    partial class CrearPago
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
            lblMetodo = new Label();
            lblReserva = new Label();
            lblMonto = new Label();
            lblTitulo = new Label();
            cmbReservas = new ComboBox();
            cmbMetodo = new ComboBox();
            txtMonto = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblMetodo
            // 
            lblMetodo.Font = new Font("Segoe UI", 9F);
            lblMetodo.ForeColor = Color.BlueViolet;
            lblMetodo.Location = new Point(25, 226);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(150, 31);
            lblMetodo.TabIndex = 24;
            lblMetodo.Text = "Método de Pago: ";
            lblMetodo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblReserva
            // 
            lblReserva.Font = new Font("Segoe UI", 9F);
            lblReserva.ForeColor = Color.BlueViolet;
            lblReserva.Location = new Point(25, 120);
            lblReserva.Name = "lblReserva";
            lblReserva.Size = new Size(114, 31);
            lblReserva.TabIndex = 23;
            lblReserva.Text = "Reserva ID:";
            lblReserva.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMonto
            // 
            lblMonto.Font = new Font("Segoe UI", 9F);
            lblMonto.ForeColor = Color.BlueViolet;
            lblMonto.Location = new Point(25, 175);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(150, 31);
            lblMonto.TabIndex = 22;
            lblMonto.Text = "Monto a Pagar ($):";
            lblMonto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 9F);
            lblTitulo.ForeColor = Color.BlueViolet;
            lblTitulo.Location = new Point(25, 67);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(114, 31);
            lblTitulo.TabIndex = 21;
            lblTitulo.Text = "Nuevo Pago";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbReservas
            // 
            cmbReservas.FormattingEnabled = true;
            cmbReservas.Items.AddRange(new object[] { "Recepción", "Limpieza", "Administrador" });
            cmbReservas.Location = new Point(163, 120);
            cmbReservas.Margin = new Padding(3, 4, 3, 4);
            cmbReservas.Name = "cmbReservas";
            cmbReservas.Size = new Size(268, 28);
            cmbReservas.TabIndex = 25;
            // 
            // cmbMetodo
            // 
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Items.AddRange(new object[] { "Recepción", "Limpieza", "Administrador" });
            cmbMetodo.Location = new Point(163, 229);
            cmbMetodo.Margin = new Padding(3, 4, 3, 4);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(268, 28);
            cmbMetodo.TabIndex = 26;
            // 
            // txtNombres
            // 
            txtMonto.Location = new Point(163, 175);
            txtMonto.Margin = new Padding(3, 4, 3, 4);
            txtMonto.Name = "txtMonto"; 
            txtMonto.Size = new Size(268, 27);
            txtMonto.TabIndex = 27;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Indigo;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(163, 320);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(255, 75);
            btnRegistrar.TabIndex = 28;
            btnRegistrar.Text = "Registrar Pago";
            btnRegistrar.UseCompatibleTextRendering = true;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // CrearPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(txtMonto);
            Controls.Add(cmbMetodo);
            Controls.Add(cmbReservas);
            Controls.Add(lblMetodo);
            Controls.Add(lblReserva);
            Controls.Add(lblMonto);
            Controls.Add(lblTitulo);
            Name = "CrearPago";
            Text = "CrearPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMetodo;
        private Label lblReserva;
        private Label lblMonto;
        private Label lblTitulo;
        private ComboBox cmbReservas;
        private ComboBox cmbMetodo;
        private TextBox txtMonto;
        private Button btnRegistrar;
    }
}