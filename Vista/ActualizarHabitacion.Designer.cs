namespace Vista
{
    partial class ActualizarHabitacion
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
            txtDescripcion = new TextBox();
            label2 = new Label();
            chbDisponibilidad = new CheckBox();
            SuspendLayout();
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(97, 202);
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
            btnRegistrar.Location = new Point(97, 395);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(223, 56);
            btnRegistrar.TabIndex = 19;
            btnRegistrar.Text = "Actualizar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.BlueViolet;
            label4.Location = new Point(97, 176);
            label4.Name = "label4";
            label4.Size = new Size(185, 23);
            label4.TabIndex = 17;
            label4.Text = "Ubicación:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNumeroHabitacion
            // 
            txtNumeroHabitacion.Location = new Point(101, 146);
            txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            txtNumeroHabitacion.Size = new Size(219, 23);
            txtNumeroHabitacion.TabIndex = 16;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(101, 120);
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
            label1.Location = new Point(100, 62);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 13;
            label1.Text = "Tipo de Habitación:  ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Location = new Point(101, 88);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(219, 23);
            cmbTipoHabitacion.TabIndex = 22;
            cmbTipoHabitacion.SelectedIndexChanged += cmbTipoHabitacion_SelectedIndexChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(97, 283);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(223, 47);
            txtDescripcion.TabIndex = 24;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(97, 257);
            label2.Name = "label2";
            label2.Size = new Size(185, 23);
            label2.TabIndex = 23;
            label2.Text = "Descripción:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chbDisponibilidad
            // 
            chbDisponibilidad.AutoSize = true;
            chbDisponibilidad.ForeColor = Color.BlueViolet;
            chbDisponibilidad.Location = new Point(100, 347);
            chbDisponibilidad.Name = "chbDisponibilidad";
            chbDisponibilidad.Size = new Size(82, 19);
            chbDisponibilidad.TabIndex = 26;
            chbDisponibilidad.Text = "Disponible";
            chbDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // ActualizarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 503);
            Controls.Add(chbDisponibilidad);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(cmbTipoHabitacion);
            Controls.Add(txtUbicacion);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(txtNumeroHabitacion);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "ActualizarHabitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Habitación";
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
        private TextBox txtDescripcion;
        private Label label2;
        private CheckBox chbDisponibilidad;
    }
}