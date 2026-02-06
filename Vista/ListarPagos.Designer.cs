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
            label1 = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            ReservaID = new DataGridViewTextBoxColumn();
            MontoPagar = new DataGridViewTextBoxColumn();
            MetodoPago = new DataGridViewTextBoxColumn();
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
            dgvReserva.Size = new Size(466, 283);
            dgvReserva.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 72);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 16;
            label1.Text = "Pagos";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.MediumVioletRed;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(458, 72);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(128, 51);
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
            btnActualizar.Location = new Point(324, 72);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(128, 51);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ReservaID
            // 
            ReservaID.HeaderText = "ReservaID";
            ReservaID.MinimumWidth = 6;
            ReservaID.Name = "ReservaID";
            ReservaID.Width = 125;
            // 
            // MontoPagar
            // 
            MontoPagar.HeaderText = "MontoPagar";
            MontoPagar.MinimumWidth = 6;
            MontoPagar.Name = "MontoPagar";
            MontoPagar.Width = 125;
            // 
            // MetodoPago
            // 
            MetodoPago.HeaderText = "MetodoPago";
            MetodoPago.MinimumWidth = 6;
            MetodoPago.Name = "MetodoPago";
            MetodoPago.Width = 125;
            // 
            // ListarPagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 504);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Controls.Add(dgvReserva);
            Name = "ListarPagos";
            Text = "ListarPagos";
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