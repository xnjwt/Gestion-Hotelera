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
            cmbHabitaciones = new ComboBox();
            cmbClientes = new ComboBox();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // lblSalida
            // 
            lblSalida.Font = new Font("Segoe UI", 9F);
            lblSalida.ForeColor = Color.BlueViolet;
            lblSalida.Location = new Point(45, 190);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(114, 31);
            lblSalida.TabIndex = 20;
            lblSalida.Text = "Fecha Salida:";
            lblSalida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHabitacion
            // 
            lblHabitacion.Font = new Font("Segoe UI", 9F);
            lblHabitacion.ForeColor = Color.BlueViolet;
            lblHabitacion.Location = new Point(45, 101);
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(114, 31);
            lblHabitacion.TabIndex = 19;
            lblHabitacion.Text = "Habitación";
            lblHabitacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIngreso
            // 
            lblIngreso.Font = new Font("Segoe UI", 9F);
            lblIngreso.ForeColor = Color.BlueViolet;
            lblIngreso.Location = new Point(35, 143);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(114, 31);
            lblIngreso.TabIndex = 18;
            lblIngreso.Text = "Fecha Entrada:";
            lblIngreso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCliente
            // 
            lblCliente.Font = new Font("Segoe UI", 9F);
            lblCliente.ForeColor = Color.BlueViolet;
            lblCliente.Location = new Point(45, 65);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(114, 31);
            lblCliente.TabIndex = 17;
            lblCliente.Text = "Cliente:";
            lblCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpSalida
            // 
            dtpSalida.Format = DateTimePickerFormat.Short;
            dtpSalida.Location = new Point(165, 194);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(268, 27);
            dtpSalida.TabIndex = 25;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Format = DateTimePickerFormat.Short;
            dtpIngreso.Location = new Point(165, 143);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(268, 27);
            dtpIngreso.TabIndex = 24;
            // 
            // cmbHabitaciones
            // 
            cmbHabitaciones.FormattingEnabled = true;
            cmbHabitaciones.Items.AddRange(new object[] { "Recepción", "Limpieza", "Administrador" });
            cmbHabitaciones.Location = new Point(165, 104);
            cmbHabitaciones.Margin = new Padding(3, 4, 3, 4);
            cmbHabitaciones.Name = "cmbHabitaciones";
            cmbHabitaciones.Size = new Size(268, 28);
            cmbHabitaciones.TabIndex = 23;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Items.AddRange(new object[] { "Recepción", "Limpieza", "Administrador" });
            cmbClientes.Location = new Point(165, 68);
            cmbClientes.Margin = new Padding(3, 4, 3, 4);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(268, 28);
            cmbClientes.TabIndex = 22;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(156, 279);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(255, 75);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "ActualizarReserva ";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ActualizarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpSalida);
            Controls.Add(dtpIngreso);
            Controls.Add(cmbHabitaciones);
            Controls.Add(cmbClientes);
            Controls.Add(btnActualizar);
            Controls.Add(lblSalida);
            Controls.Add(lblHabitacion);
            Controls.Add(lblIngreso);
            Controls.Add(lblCliente);
            Name = "ActualizarReserva";
            Text = "ActualizarReserva";
            ResumeLayout(false);
        }

        #endregion

        private Label lblSalida;
        private Label lblHabitacion;
        private Label lblIngreso;
        private Label lblCliente;
        private DateTimePicker dtpSalida;
        private DateTimePicker dtpIngreso;
        private ComboBox cmbHabitaciones;
        private ComboBox cmbClientes;
        private Button btnActualizar;
    }
}