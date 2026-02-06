namespace Vista
{
    partial class ListarTipoHabitacion
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
            dgvTiposHabitacion = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            PrecioNoche = new DataGridViewTextBoxColumn();
            caracteristicas = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTiposHabitacion).BeginInit();
            SuspendLayout();
            // 
            // dgvTiposHabitacion
            // 
            dgvTiposHabitacion.BackgroundColor = Color.FromArgb(228, 191, 255);
            dgvTiposHabitacion.BorderStyle = BorderStyle.Fixed3D;
            dgvTiposHabitacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiposHabitacion.Columns.AddRange(new DataGridViewColumn[] { Nombre, Correo, PrecioNoche, caracteristicas });
            dgvTiposHabitacion.Location = new Point(71, 128);
            dgvTiposHabitacion.Name = "dgvTiposHabitacion";
            dgvTiposHabitacion.Size = new Size(643, 225);
            dgvTiposHabitacion.TabIndex = 0;
            dgvTiposHabitacion.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 200;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Capacidad";
            Correo.HeaderText = "Capacidad";
            Correo.Name = "Correo";
            // 
            // PrecioNoche
            // 
            PrecioNoche.DataPropertyName = "Precio_noche";
            PrecioNoche.HeaderText = "Precio x Noche";
            PrecioNoche.Name = "PrecioNoche";
            // 
            // caracteristicas
            // 
            caracteristicas.DataPropertyName = "Caracteristicas";
            caracteristicas.HeaderText = "Características";
            caracteristicas.Name = "caracteristicas";
            caracteristicas.Width = 200;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(486, 72);
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
            btnEliminar.Location = new Point(604, 72);
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
            label1.Size = new Size(209, 30);
            label1.TabIndex = 13;
            label1.Text = "Tipos de Habitación";
            // 
            // ListarTipoHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 416);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvTiposHabitacion);
            Name = "ListarTipoHabitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Empleado";
            Load += ListarTipoHabitacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTiposHabitacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTiposHabitacion;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn PrecioNoche;
        private DataGridViewTextBoxColumn caracteristicas;
    }
}