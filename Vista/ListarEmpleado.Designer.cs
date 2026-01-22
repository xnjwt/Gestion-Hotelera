namespace Vista
{
    partial class ListarEmpleado
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
            dgvEmpleados = new DataGridView();
            Nombres = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = Color.FromArgb(228, 191, 255);
            dgvEmpleados.BorderStyle = BorderStyle.Fixed3D;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { Nombres, Correo, Celular, Rol, Turno, Estado });
            dgvEmpleados.Location = new Point(71, 128);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(843, 225);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombres
            // 
            Nombres.DataPropertyName = "Nombres";
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            Nombres.Width = 200;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Email";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.Width = 200;
            // 
            // Celular
            // 
            Celular.DataPropertyName = "Celular";
            Celular.HeaderText = "Celular";
            Celular.Name = "Celular";
            // 
            // Rol
            // 
            Rol.DataPropertyName = "Rol";
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            // 
            // Turno
            // 
            Turno.DataPropertyName = "Turno";
            Turno.HeaderText = "Turno";
            Turno.Name = "Turno";
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(684, 72);
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
            btnEliminar.Location = new Point(802, 72);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 38);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Despedir";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 72);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 13;
            label1.Text = "Empleados";
            // 
            // ListarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 416);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvEmpleados);
            Name = "ListarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Empleado";
            Load += ListarEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Turno;
        private DataGridViewTextBoxColumn Estado;
    }
}