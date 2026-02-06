namespace Vista
{
    partial class CrearTipoHabitacion
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
            txtNombre = new TextBox();
            txtCapacidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRegistrar = new Button();
            txtPrecioHora = new TextBox();
            txtDescripcion = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(94, 39);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(94, 124);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(100, 23);
            txtCapacidad.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(94, 98);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 5;
            label3.Text = "Capacidad: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.BlueViolet;
            label4.Location = new Point(94, 153);
            label4.Name = "label4";
            label4.Size = new Size(185, 23);
            label4.TabIndex = 7;
            label4.Text = "Descripción: ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.BlueViolet;
            label5.Location = new Point(224, 98);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 9;
            label5.Text = "Precio: ";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Indigo;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(94, 281);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(223, 56);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtPrecioHora
            // 
            txtPrecioHora.Location = new Point(224, 124);
            txtPrecioHora.Name = "txtPrecioHora";
            txtPrecioHora.Size = new Size(93, 23);
            txtPrecioHora.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(94, 179);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(223, 74);
            txtDescripcion.TabIndex = 12;
            // 
            // CrearTipoHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 398);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecioHora);
            Controls.Add(btnRegistrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCapacidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CrearTipoHabitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Tipo de Habitación";
            Load += CrearEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtCapacidad;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegistrar;
        private TextBox txtPrecioHora;
        private TextBox txtDescripcion;
    }
}