namespace Vista
{
    partial class CrearHabitacion
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
            txtUbicacion = new TextBox();
            btnRegistrar = new Button();
            label4 = new Label();
            txtNumeroHabitacion = new TextBox();
            label3 = new Label();
            label1 = new Label();
            cmbTipoHabitacion = new ComboBox();
            SuspendLayout();
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(97, 210);
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(223, 47);
            txtUbicacion.TabIndex = 21;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Indigo;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(97, 292);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(223, 56);
            btnRegistrar.TabIndex = 19;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.BlueViolet;
            label4.Location = new Point(97, 184);
            label4.Name = "label4";
            label4.Size = new Size(185, 23);
            label4.TabIndex = 17;
            label4.Text = "Ubicación:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNumeroHabitacion
            // 
            txtNumeroHabitacion.Location = new Point(101, 154);
            txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            txtNumeroHabitacion.Size = new Size(219, 23);
            txtNumeroHabitacion.TabIndex = 16;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(101, 128);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 15;
            label3.Text = "Número de Habitación:  ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(97, 70);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 13;
            label1.Text = "Tipo de Habitación:  ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Location = new Point(101, 96);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(219, 23);
            cmbTipoHabitacion.TabIndex = 22;
            cmbTipoHabitacion.SelectedIndexChanged += cmbTipoHabitacion_SelectedIndexChanged;
            // 
            // CrearHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 414);
            Controls.Add(cmbTipoHabitacion);
            Controls.Add(txtUbicacion);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(txtNumeroHabitacion);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CrearHabitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Habitación";
            Load += CrearEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUbicacion;
        private Button btnRegistrar;
        private Label label4;
        private TextBox txtNumeroHabitacion;
        private Label label3;
        private Label label1;
        private ComboBox cmbTipoHabitacion;
    }
}