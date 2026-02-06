namespace Vista
{
    partial class ListarReserva
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
            label1 = new Label();
            dgvReserva = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Habitacion = new DataGridViewTextBoxColumn();
            FechaEntrada = new DataGridViewTextBoxColumn();
            FechaSalida = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReserva).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 145);
            label1.Name = "label1";
            label1.Size = new Size(118, 37);
            label1.TabIndex = 17;
            label1.Text = "Reserva";
            // 
            // dgvReserva
            // 
            dgvReserva.BackgroundColor = Color.FromArgb(228, 191, 255);
            dgvReserva.BorderStyle = BorderStyle.Fixed3D;
            dgvReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserva.Columns.AddRange(new DataGridViewColumn[] { Cliente, Habitacion, FechaEntrada, FechaSalida });
            dgvReserva.Location = new Point(96, 221);
            dgvReserva.Margin = new Padding(3, 4, 3, 4);
            dgvReserva.Name = "dgvReserva";
            dgvReserva.RowHeadersWidth = 51;
            dgvReserva.Size = new Size(552, 283);
            dgvReserva.TabIndex = 14;
            // 
            // Cliente
            // 
            Cliente.DataPropertyName = "ClienteID";
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // Habitacion
            // 
            Habitacion.DataPropertyName = "HabitacionID";
            Habitacion.HeaderText = "Habitacion";
            Habitacion.MinimumWidth = 6;
            Habitacion.Name = "Habitacion";
            Habitacion.Width = 125;
            // 
            // FechaEntrada
            // 
            FechaEntrada.DataPropertyName = "FechaIngreso";
            FechaEntrada.HeaderText = "FechaEntrada";
            FechaEntrada.MinimumWidth = 6;
            FechaEntrada.Name = "FechaEntrada";
            FechaEntrada.Width = 125;
            // 
            // FechaSalida
            // 
            FechaSalida.DataPropertyName = "FechaSalida";
            FechaSalida.HeaderText = "FechaSalida";
            FechaSalida.MinimumWidth = 6;
            FechaSalida.Name = "FechaSalida";
            FechaSalida.Width = 125;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.MediumVioletRed;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(502, 134);
            btnEliminar.Margin = new Padding(3, 5, 3, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 68);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(348, 134);
            btnActualizar.Margin = new Padding(3, 5, 3, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(146, 68);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // ListarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 645);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Controls.Add(dgvReserva);
            Name = "ListarReserva";
            Text = "ListarReserva";
            Load += ListarReserva_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvReserva;
        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Habitacion;
        private DataGridViewTextBoxColumn FechaEntrada;
        private DataGridViewTextBoxColumn FechaSalida;
    }
}