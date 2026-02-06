namespace Vista
{
    partial class ActualizarPago
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
            btnActualizar = new Button();
            txtMonto = new TextBox();
            cmbMetodo = new ComboBox();
            cmbReservas = new ComboBox();
            lblMetodo = new Label();
            lblReserva = new Label();
            lblMonto = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(235, 323);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(255, 75);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar Pago";
            btnActualizar.UseCompatibleTextRendering = true;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(244, 178);
            txtMonto.Margin = new Padding(3, 4, 3, 4);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(268, 27);
            txtMonto.TabIndex = 35;
            // 
            // cmbMetodo
            // 
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Items.AddRange(new object[] { "Transferencia", "Efectivo ", "Cheque", "Tarjeta" });
            cmbMetodo.Location = new Point(244, 232);
            cmbMetodo.Margin = new Padding(3, 4, 3, 4);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(268, 28);
            cmbMetodo.TabIndex = 34;
            // 
            // cmbReservas
            // 
            cmbReservas.FormattingEnabled = true;
            cmbReservas.Items.AddRange(new object[] { "Recepción", "Limpieza", "Administrador" });
            cmbReservas.Location = new Point(244, 123);
            cmbReservas.Margin = new Padding(3, 4, 3, 4);
            cmbReservas.Name = "cmbReservas";
            cmbReservas.Size = new Size(268, 28);
            cmbReservas.TabIndex = 33;
            // 
            // lblMetodo
            // 
            lblMetodo.Font = new Font("Segoe UI", 9F);
            lblMetodo.ForeColor = Color.BlueViolet;
            lblMetodo.Location = new Point(106, 229);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(150, 31);
            lblMetodo.TabIndex = 32;
            lblMetodo.Text = "Método de Pago: ";
            lblMetodo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblReserva
            // 
            lblReserva.Font = new Font("Segoe UI", 9F);
            lblReserva.ForeColor = Color.BlueViolet;
            lblReserva.Location = new Point(106, 123);
            lblReserva.Name = "lblReserva";
            lblReserva.Size = new Size(114, 31);
            lblReserva.TabIndex = 31;
            lblReserva.Text = "Reserva ID:";
            lblReserva.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMonto
            // 
            lblMonto.Font = new Font("Segoe UI", 9F);
            lblMonto.ForeColor = Color.BlueViolet;
            lblMonto.Location = new Point(106, 178);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(150, 31);
            lblMonto.TabIndex = 30;
            lblMonto.Text = "Monto a Pagar ($):";
            lblMonto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 9F);
            lblTitulo.ForeColor = Color.BlueViolet;
            lblTitulo.Location = new Point(106, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 31);
            lblTitulo.TabIndex = 29;
            lblTitulo.Text = "Actualizar  Pago";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ActualizarPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 450);
            Controls.Add(btnActualizar);
            Controls.Add(txtMonto);
            Controls.Add(cmbMetodo);
            Controls.Add(cmbReservas);
            Controls.Add(lblMetodo);
            Controls.Add(lblReserva);
            Controls.Add(lblMonto);
            Controls.Add(lblTitulo);
            Name = "ActualizarPago";
            Text = "ActualizarPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private TextBox txtMonto;
        private ComboBox cmbMetodo;
        private ComboBox cmbReservas;
        private Label lblMetodo;
        private Label lblReserva;
        private Label lblMonto;
        private Label lblTitulo;
    }
}