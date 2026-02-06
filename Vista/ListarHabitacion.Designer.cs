namespace Vista
{
    partial class ListarHabitacion
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
            dgvHabitaciones = new DataGridView();
            TipoHabitacion = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Ubicacion = new DataGridViewTextBoxColumn();
            Disponibilidad = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.BackgroundColor = Color.FromArgb(228, 191, 255);
            dgvHabitaciones.BorderStyle = BorderStyle.Fixed3D;
            dgvHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabitaciones.Columns.AddRange(new DataGridViewColumn[] { TipoHabitacion, Correo, Ubicacion, Disponibilidad });
            dgvHabitaciones.Location = new Point(71, 128);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.Size = new Size(643, 225);
            dgvHabitaciones.TabIndex = 0;
            dgvHabitaciones.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TipoHabitacion
            // 
            TipoHabitacion.DataPropertyName = "Id_tipohabitacion";
            TipoHabitacion.HeaderText = "Tipo de Habitación";
            TipoHabitacion.Name = "TipoHabitacion";
            TipoHabitacion.Width = 200;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Numhabitación";
            Correo.HeaderText = "Número de Habitación";
            Correo.Name = "Correo";
            // 
            // Ubicacion
            // 
            Ubicacion.DataPropertyName = "Ubicación";
            Ubicacion.HeaderText = "Ubicación";
            Ubicacion.Name = "Ubicacion";
            Ubicacion.Width = 200;
            // 
            // Disponibilidad
            // 
            Disponibilidad.DataPropertyName = "Disponibilidad";
            Disponibilidad.HeaderText = "Disponibilidad";
            Disponibilidad.Name = "Disponibilidad";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(484, 72);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 38);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.MediumVioletRed;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(602, 72);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 38);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 72);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 13;
            label1.Text = "Habitaciones";
            // 
            // ListarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 416);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvHabitaciones);
            Name = "ListarHabitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Empleado";
            Load += ListarHabitacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHabitaciones;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
        private DataGridViewTextBoxColumn TipoHabitacion;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Ubicacion;
        private DataGridViewTextBoxColumn Disponibilidad;
    }
}