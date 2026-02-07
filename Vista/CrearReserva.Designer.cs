namespace Vista
{
    // El nombre debe ser CrearReserva para que coincida con tu archivo lógico
    partial class CrearReserva
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
            btnRegistrar.Location = new Point(126, 220);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(223, 56);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Crear Reserva";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblCliente
            // 
            lblCliente.Font = new Font("Segoe UI", 9F);
            lblCliente.ForeColor = Color.BlueViolet;
            lblCliente.Location = new Point(40, 46);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(100, 23);
            lblCliente.TabIndex = 13;
            lblCliente.Text = "Cliente:";
            lblCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIngreso
            // 
            lblIngreso.Font = new Font("Segoe UI", 9F);
            lblIngreso.ForeColor = Color.BlueViolet;
            lblIngreso.Location = new Point(40, 104);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(100, 23);
            lblIngreso.TabIndex = 14;
            lblIngreso.Text = "Fecha Entrada:";
            lblIngreso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHabitacion
            // 
            lblHabitacion.Font = new Font("Segoe UI", 9F);
            lblHabitacion.ForeColor = Color.BlueViolet;
            lblHabitacion.Location = new Point(40, 73);
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(100, 23);
            lblHabitacion.TabIndex = 15;
            lblHabitacion.Text = "Habitación";
            lblHabitacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSalida
            // 
            lblSalida.Font = new Font("Segoe UI", 9F);
            lblSalida.ForeColor = Color.BlueViolet;
            lblSalida.Location = new Point(40, 142);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(100, 23);
            lblSalida.TabIndex = 16;
            lblSalida.Text = "Fecha Salida:";
            lblSalida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(145, 48);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(235, 23);
            cmbClientes.TabIndex = 17;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            // 
            // cmbHabitaciones
            // 
            cmbHabitaciones.FormattingEnabled = true;
            cmbHabitaciones.Location = new Point(145, 75);
            cmbHabitaciones.Name = "cmbHabitaciones";
            cmbHabitaciones.Size = new Size(235, 23);
            cmbHabitaciones.TabIndex = 18;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Format = DateTimePickerFormat.Short;
            dtpIngreso.Location = new Point(145, 104);
            dtpIngreso.Margin = new Padding(3, 2, 3, 2);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(235, 23);
            dtpIngreso.TabIndex = 19;
            // 
            // dtpSalida
            // 
            dtpSalida.Format = DateTimePickerFormat.Short;
            dtpSalida.Location = new Point(145, 142);
            dtpSalida.Margin = new Padding(3, 2, 3, 2);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(235, 23);
            dtpSalida.TabIndex = 20;
            // 
            // CrearReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 338);
            Controls.Add(dtpSalida);
            Controls.Add(dtpIngreso);
            Controls.Add(cmbHabitaciones);
            Controls.Add(cmbClientes);
            Controls.Add(lblSalida);
            Controls.Add(lblHabitacion);
            Controls.Add(lblIngreso);
            Controls.Add(lblCliente);
            Controls.Add(btnRegistrar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CrearReserva";
            Text = "Crear Reserva";
            Load += CrearReserva_Load;
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