namespace Vista
{
    partial class ListarPagos
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
            dgvReserva = new DataGridView();
            ReservaID = new DataGridViewTextBoxColumn();
            MontoPagar = new DataGridViewTextBoxColumn();
            MetodoPago = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReserva).BeginInit();
            SuspendLayout();
            // 
            // dgvReserva
            // 
            dgvReserva.BackgroundColor = Color.FromArgb(228, 191, 255);
            dgvReserva.BorderStyle = BorderStyle.Fixed3D;
            dgvReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserva.Columns.AddRange(new DataGridViewColumn[] { ReservaID, MontoPagar, MetodoPago });
            dgvReserva.Location = new Point(120, 141);
            dgvReserva.Margin = new Padding(3, 4, 3, 4);
            dgvReserva.Name = "dgvReserva";
            dgvReserva.RowHeadersWidth = 51;
            dgvReserva.Size = new Size(449, 283);
            dgvReserva.TabIndex = 15;
            // 
            // ReservaID
            // 
            ReservaID.DataPropertyName = "ReservaID";
            ReservaID.HeaderText = "ReservaID";
            ReservaID.MinimumWidth = 6;
            ReservaID.Name = "ReservaID";
            ReservaID.Width = 125;
            // 
            // MontoPagar
            // 
            MontoPagar.DataPropertyName = "MontoTotal";
            MontoPagar.HeaderText = "MontoPagar";
            MontoPagar.MinimumWidth = 6;
            MontoPagar.Name = "MontoPagar";
            MontoPagar.Width = 125;
            // 
            // MetodoPago
            // 
            MetodoPago.DataPropertyName = "Metodo";
            MetodoPago.HeaderText = "MetodoPago";
            MetodoPago.MinimumWidth = 6;
            MetodoPago.Name = "MetodoPago";
            MetodoPago.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 54);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 16;
            label1.Text = "Pagos";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.MediumVioletRed;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(401, 54);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 38);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(284, 54);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 38);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ListarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 378);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Controls.Add(dgvReserva);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarPagos";
            Text = "ListarPagos";
            Load += ListarPagos_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReserva;
        private Label label1;
        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridViewTextBoxColumn ReservaID;
        private DataGridViewTextBoxColumn MontoPagar;
        private DataGridViewTextBoxColumn MetodoPago;
    }
}