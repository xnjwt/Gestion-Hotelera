namespace Vista
{
    partial class btnRegistrarReserva
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
            btnRegistrar = new Button();
            lblCliente = new Label();
            lblIngreso = new Label();
            lblHabitacion = new Label();
            lblSalida = new Label();
            cmbClientes = new ComboBox();
            cmbHabitaciones = new ComboBox();
            dtpIngreso = new DateTimePicker();
            dtpSalida = new DateTimePicker();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Indigo;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(144, 294);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(255, 75);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Crear Reserva ";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblCliente
            // 
            lblCliente.Font = new Font("Segoe UI", 9F);
            lblCliente.ForeColor = Color.BlueViolet;
            lblCliente.Location = new Point(46, 61);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(114, 31);
            lblCliente.TabIndex = 13;
            lblCliente.Text = "Cliente:";
            lblCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIngreso
            // 
            lblIngreso.Font = new Font("Segoe UI", 9F);
            lblIngreso.ForeColor = Color.BlueViolet;
            lblIngreso.Location = new Point(46, 139);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(114, 31);
            lblIngreso.TabIndex = 14;
            lblIngreso.Text = "Fecha Entrada:";
            lblIngreso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHabitacion
            // 
            lblHabitacion.Font = new Font("Segoe UI", 9F);
            lblHabitacion.ForeColor = Color.BlueViolet;
            lblHabitacion.Location = new Point(46, 97);
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(114, 31);
            lblHabitacion.TabIndex = 15;
            lblHabitacion.Text = "Habitación";
            lblHabitacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSalida
            // 
            lblSalida.Font = new Font("Segoe UI", 9F);
            lblSalida.ForeColor = Color.BlueViolet;
            lblSalida.Location = new Point(46, 190);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(114, 31);
            lblSalida.TabIndex = 16;
            lblSalida.Text = "Fecha Salida:";
            lblSalida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Items.AddRange(new object[] { "Recepción", "Limpieza", "Administrador" });
            cmbClientes.Location = new Point(166, 64);
            cmbClientes.Margin = new Padding(3, 4, 3, 4);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(268, 28);
            cmbClientes.TabIndex = 17;
            // 
            // cmbHabitaciones
            // 
            cmbHabitaciones.FormattingEnabled = true;
            cmbHabitaciones.Items.AddRange(new object[] { "Recepción", "Limpieza", "Administrador" });
            cmbHabitaciones.Location = new Point(166, 100);
            cmbHabitaciones.Margin = new Padding(3, 4, 3, 4);
            cmbHabitaciones.Name = "cmbHabitaciones";
            cmbHabitaciones.Size = new Size(268, 28);
            cmbHabitaciones.TabIndex = 18;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Format = DateTimePickerFormat.Short;
            dtpIngreso.Location = new Point(166, 139);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(268, 27);
            dtpIngreso.TabIndex = 19;
            // 
            // dtpSalida
            // 
            dtpSalida.Format = DateTimePickerFormat.Short;
            dtpSalida.Location = new Point(166, 190);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(268, 27);
            dtpSalida.TabIndex = 20;
            // 
            // btnRegistrarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(dtpSalida);
            Controls.Add(dtpIngreso);
            Controls.Add(cmbHabitaciones);
            Controls.Add(cmbClientes);
            Controls.Add(lblSalida);
            Controls.Add(lblHabitacion);
            Controls.Add(lblIngreso);
            Controls.Add(lblCliente);
            Controls.Add(btnRegistrar);
            Name = "btnRegistrarReserva";
            Text = "CrearReserva";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrar;
        private Label lblCliente;
        private Label lblIngreso;
        private Label lblHabitacion;
        private Label lblSalida;
        private ComboBox cmbClientes;
        private ComboBox cmbHabitaciones;
        private DateTimePicker dtpIngreso;
        private DateTimePicker dtpSalida;
    }
}