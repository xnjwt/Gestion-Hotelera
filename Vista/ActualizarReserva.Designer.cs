namespace Vista
{
    partial class ActualizarReserva
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
            lblSalida = new Label();
            lblHabitacion = new Label();
            lblIngreso = new Label();
            lblCliente = new Label();
            dtpSalida = new DateTimePicker();
            dtpIngreso = new DateTimePicker();
            btnActualizar = new Button();
            cmbMetodo = new ComboBox();
            lblMetodo = new Label();
            txtMonto = new TextBox();
            lblMonto = new Label();
            txtCliente = new TextBox();
            txtHabitacion = new TextBox();
            SuspendLayout();
            // 
            // lblSalida
            // 
            lblSalida.Font = new Font("Segoe UI", 9F);
            lblSalida.ForeColor = Color.BlueViolet;
            lblSalida.Location = new Point(39, 136);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(100, 23);
            lblSalida.TabIndex = 20;
            lblSalida.Text = "Fecha Salida:";
            lblSalida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHabitacion
            // 
            lblHabitacion.Font = new Font("Segoe UI", 9F);
            lblHabitacion.ForeColor = Color.BlueViolet;
            lblHabitacion.Location = new Point(39, 78);
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(100, 23);
            lblHabitacion.TabIndex = 19;
            lblHabitacion.Text = "Habitación";
            lblHabitacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIngreso
            // 
            lblIngreso.Font = new Font("Segoe UI", 9F);
            lblIngreso.ForeColor = Color.BlueViolet;
            lblIngreso.Location = new Point(31, 109);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(100, 23);
            lblIngreso.TabIndex = 18;
            lblIngreso.Text = "Fecha Entrada:";
            lblIngreso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCliente
            // 
            lblCliente.Font = new Font("Segoe UI", 9F);
            lblCliente.ForeColor = Color.BlueViolet;
            lblCliente.Location = new Point(39, 49);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(100, 23);
            lblCliente.TabIndex = 17;
            lblCliente.Text = "Cliente:";
            lblCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpSalida
            // 
            dtpSalida.Format = DateTimePickerFormat.Short;
            dtpSalida.Location = new Point(144, 140);
            dtpSalida.Margin = new Padding(3, 2, 3, 2);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(235, 23);
            dtpSalida.TabIndex = 25;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Format = DateTimePickerFormat.Short;
            dtpIngreso.Location = new Point(144, 109);
            dtpIngreso.Margin = new Padding(3, 2, 3, 2);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(235, 23);
            dtpIngreso.TabIndex = 24;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(144, 270);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(223, 56);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "ActualizarReserva ";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // cmbMetodo
            // 
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Items.AddRange(new object[] { "Transferencia", "Efectivo ", "Cheque", "Tarjeta" });
            cmbMetodo.Location = new Point(144, 194);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(235, 23);
            cmbMetodo.TabIndex = 38;
            // 
            // lblMetodo
            // 
            lblMetodo.Font = new Font("Segoe UI", 9F);
            lblMetodo.ForeColor = Color.BlueViolet;
            lblMetodo.Location = new Point(23, 192);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(131, 23);
            lblMetodo.TabIndex = 37;
            lblMetodo.Text = "Método de Pago: ";
            lblMetodo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(144, 223);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(235, 23);
            txtMonto.TabIndex = 41;
            // 
            // lblMonto
            // 
            lblMonto.Font = new Font("Segoe UI", 9F);
            lblMonto.ForeColor = Color.BlueViolet;
            lblMonto.Location = new Point(23, 223);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(131, 23);
            lblMonto.TabIndex = 40;
            lblMonto.Text = "Monto a Pagar ($):";
            lblMonto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(144, 49);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(235, 23);
            txtCliente.TabIndex = 42;
            // 
            // txtHabitacion
            // 
            txtHabitacion.Location = new Point(144, 79);
            txtHabitacion.Name = "txtHabitacion";
            txtHabitacion.ReadOnly = true;
            txtHabitacion.Size = new Size(235, 23);
            txtHabitacion.TabIndex = 43;
            // 
            // ActualizarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 338);
            Controls.Add(txtHabitacion);
            Controls.Add(txtCliente);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(cmbMetodo);
            Controls.Add(lblMetodo);
            Controls.Add(dtpSalida);
            Controls.Add(dtpIngreso);
            Controls.Add(btnActualizar);
            Controls.Add(lblSalida);
            Controls.Add(lblHabitacion);
            Controls.Add(lblIngreso);
            Controls.Add(lblCliente);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ActualizarReserva";
            Text = "ActualizarReserva";
            Load += ActualizarReserva_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalida;
        private Label lblHabitacion;
        private Label lblIngreso;
        private Label lblCliente;
        private DateTimePicker dtpSalida;
        private DateTimePicker dtpIngreso;
        private Button btnActualizar;
        private ComboBox cmbMetodo;
        private Label lblMetodo;
        private TextBox txtMonto;
        private Label lblMonto;
        private TextBox txtCliente;
        private TextBox txtHabitacion;
    }
}