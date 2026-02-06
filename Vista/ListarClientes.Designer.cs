namespace Vista
{
    partial class ListarClientes
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
            dgvClientes = new DataGridView();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            btnDesactivar = new Button();
            btnActualizar = new Button();
            cmbEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 106);
            label1.Name = "label1";
            label1.Size = new Size(90, 30);
            label1.TabIndex = 14;
            label1.Text = "Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.FromArgb(228, 191, 255);
            dgvClientes.BorderStyle = BorderStyle.Fixed3D;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Nombres, Apellidos, Cedula, Celular, Direccion, FechaNacimiento, Correo });
            dgvClientes.Location = new Point(27, 158);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(1058, 194);
            dgvClientes.TabIndex = 15;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // Nombres
            // 
            Nombres.DataPropertyName = "Nombre";
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 6;
            Nombres.Name = "Nombres";
            Nombres.Width = 200;
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "Apellido";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 125;
            // 
            // Cedula
            // 
            Cedula.DataPropertyName = "Cedula";
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 6;
            Cedula.Name = "Cedula";
            Cedula.Width = 150;
            // 
            // Celular
            // 
            Celular.DataPropertyName = "Celular";
            Celular.HeaderText = "Celular";
            Celular.MinimumWidth = 6;
            Celular.Name = "Celular";
            Celular.Width = 125;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 150;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.DataPropertyName = "FechaNacimiento";
            FechaNacimiento.HeaderText = "FechaNacimiento";
            FechaNacimiento.MinimumWidth = 6;
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Width = 125;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Email";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 250;
            // 
            // btnDesactivar
            // 
            btnDesactivar.BackColor = Color.MediumVioletRed;
            btnDesactivar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesactivar.ForeColor = SystemColors.ButtonFace;
            btnDesactivar.Location = new Point(959, 85);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(112, 38);
            btnDesactivar.TabIndex = 17;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = false;
            btnDesactivar.Click += btnDesactivar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(841, 85);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 38);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "todos", "activo", "inactivo" });
            cmbEstado.Location = new Point(123, 113);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 18;
            // 
            // ListarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 399);
            Controls.Add(cmbEstado);
            Controls.Add(btnDesactivar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvClientes);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarClientes";
            Text = "ListarClientes";
            Load += ListarClientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Correo;
        private Button btnDesactivar;
        private Button btnActualizar;
        private ComboBox cmbEstado;
    }
}