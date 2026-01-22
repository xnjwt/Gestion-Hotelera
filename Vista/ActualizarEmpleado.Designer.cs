namespace Vista
{
    partial class ActualizarEmpleado
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
            txtNombres = new TextBox();
            cmbRol = new ComboBox();
            txtCorreo = new TextBox();
            label2 = new Label();
            txtCelular = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbTurno = new ComboBox();
            btnRegistrar = new Button();
            txtContrasena = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(86, 63);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombres: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(86, 89);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(223, 23);
            txtNombres.TabIndex = 1;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Recepción", "Limpieza", "Administrador" });
            cmbRol.Location = new Point(86, 260);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(110, 23);
            cmbRol.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(86, 145);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(223, 23);
            txtCorreo.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(86, 119);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Correo: ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCelular
            // 
            txtCelular.ForeColor = Color.Black;
            txtCelular.Location = new Point(86, 316);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(223, 23);
            txtCelular.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(86, 290);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 5;
            label3.Text = "Celular: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.BlueViolet;
            label4.Location = new Point(86, 234);
            label4.Name = "label4";
            label4.Size = new Size(32, 23);
            label4.TabIndex = 7;
            label4.Text = "Rol: ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.BlueViolet;
            label5.Location = new Point(199, 234);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 9;
            label5.Text = "Turno: ";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbTurno
            // 
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cmbTurno.Location = new Point(199, 260);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(110, 23);
            cmbTurno.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Indigo;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(86, 373);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(223, 56);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Actualizar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(86, 202);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(223, 23);
            txtContrasena.TabIndex = 13;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.BlueViolet;
            label6.Location = new Point(86, 176);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 12;
            label6.Text = "Contraseña: ";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ActualizarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 481);
            Controls.Add(txtContrasena);
            Controls.Add(label6);
            Controls.Add(btnRegistrar);
            Controls.Add(label5);
            Controls.Add(cmbTurno);
            Controls.Add(label4);
            Controls.Add(txtCelular);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(cmbRol);
            Controls.Add(txtNombres);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ActualizarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Empleado";
            Load += ActualizarEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombres;
        private ComboBox cmbRol;
        private TextBox txtCorreo;
        private Label label2;
        private TextBox txtCelular;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbTurno;
        private Button btnRegistrar;
        private TextBox txtContrasena;
        private Label label6;
    }
}