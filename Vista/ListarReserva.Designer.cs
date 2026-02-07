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
            btnCancelar = new Button();
            btnActualizar = new Button();
            cmbEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvReserva).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 82);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 17;
            label1.Text = "Reserva";
            // 
            // dgvReserva
            // 
            dgvReserva.BackgroundColor = Color.FromArgb(228, 191, 255);
            dgvReserva.BorderStyle = BorderStyle.Fixed3D;
            dgvReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserva.Columns.AddRange(new DataGridViewColumn[] { Cliente, Habitacion, FechaEntrada, FechaSalida });
            dgvReserva.Location = new Point(79, 130);
            dgvReserva.Name = "dgvReserva";
            dgvReserva.RowHeadersWidth = 51;
            dgvReserva.Size = new Size(555, 212);
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
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.MediumVioletRed;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(505, 69);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 51);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(370, 69);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(128, 51);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Todas", "Pendiente", "Confirmada", "Cancelada" });
            cmbEstado.Location = new Point(173, 89);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 20;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // ListarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 428);
            Controls.Add(cmbEstado);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Controls.Add(dgvReserva);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnCancelar;
        private Button btnActualizar;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Habitacion;
        private DataGridViewTextBoxColumn FechaEntrada;
        private DataGridViewTextBoxColumn FechaSalida;
        private ComboBox cmbEstado;
    }
}