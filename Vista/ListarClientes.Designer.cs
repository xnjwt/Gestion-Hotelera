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
            Correo = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 57);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 14;
            label1.Text = "Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.FromArgb(228, 191, 255);
            dgvClientes.BorderStyle = BorderStyle.Fixed3D;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Nombres, Correo, Celular, Rol, Turno, Estado });
            dgvClientes.Location = new Point(1, 123);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(750, 252);
            dgvClientes.TabIndex = 15;
            // 
            // Nombres
            // 
            Nombres.DataPropertyName = "Nombres";
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 6;
            Nombres.Name = "Nombres";
            Nombres.Width = 200;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Email";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 200;
            // 
            // Celular
            // 
            Celular.DataPropertyName = "Celular";
            Celular.HeaderText = "Celular";
            Celular.MinimumWidth = 6;
            Celular.Name = "Celular";
            Celular.Width = 125;
            // 
            // Rol
            // 
            Rol.DataPropertyName = "Rol";
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.Width = 125;
            // 
            // Turno
            // 
            Turno.DataPropertyName = "Turno";
            Turno.HeaderText = "Turno";
            Turno.MinimumWidth = 6;
            Turno.Name = "Turno";
            Turno.Width = 125;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(507, 55);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(128, 51);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ListarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(dgvClientes);
            Controls.Add(label1);
            Name = "ListarClientes";
            Text = "ListarClientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Turno;
        private DataGridViewTextBoxColumn Estado;
        private Button btnActualizar;
    }
}