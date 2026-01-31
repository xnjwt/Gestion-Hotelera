
namespace Vista
{
    partial class CrearClientes
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
            txtApellidos = new TextBox();
            label2 = new Label();
            txtCelular = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnRegistrar = new Button();
            txtCorreo = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtDireccion = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            txtCedula = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(89, 35);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 0;
            label1.Text = "Nombres: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(89, 70);
            txtNombres.Margin = new Padding(3, 4, 3, 4);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(254, 27);
            txtNombres.TabIndex = 1;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(89, 136);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(254, 27);
            txtApellidos.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(89, 101);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 3;
            label2.Text = "Apellidos:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCelular
            // 
            txtCelular.ForeColor = Color.Black;
            txtCelular.Location = new Point(89, 259);
            txtCelular.Margin = new Padding(3, 4, 3, 4);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(254, 27);
            txtCelular.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(89, 224);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 5;
            label3.Text = "Celular: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.BlueViolet;
            label4.Location = new Point(85, 417);
            label4.Name = "label4";
            label4.Size = new Size(187, 31);
            label4.TabIndex = 7;
            label4.Text = "Fecha De Nacimiento : ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Indigo;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(84, 497);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(255, 75);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(89, 193);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(254, 27);
            txtCorreo.TabIndex = 13;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.BlueViolet;
            label6.Location = new Point(89, 167);
            label6.Name = "label6";
            label6.Size = new Size(114, 31);
            label6.TabIndex = 12;
            label6.Text = "Correo:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.BlueViolet;
            label7.Location = new Point(98, 290);
            label7.Name = "label7";
            label7.Size = new Size(114, 31);
            label7.TabIndex = 14;
            label7.Text = "Direccion: ";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Location = new Point(89, 320);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(254, 27);
            txtDireccion.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(84, 463);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.BlueViolet;
            label5.Location = new Point(98, 351);
            label5.Name = "label5";
            label5.Size = new Size(114, 31);
            label5.TabIndex = 17;
            label5.Text = "Cedula: ";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(85, 386);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(254, 27);
            txtCedula.TabIndex = 18;
            // 
            // CrearClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 637);
            Controls.Add(txtCedula);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtDireccion);
            Controls.Add(label7);
            Controls.Add(txtCorreo);
            Controls.Add(label6);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(txtCelular);
            Controls.Add(label3);
            Controls.Add(txtApellidos);
            Controls.Add(label2);
            Controls.Add(txtNombres);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Empleado";
            Load += CrearEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void CrearEmpleado_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private Label label2;
        private TextBox txtCelular;
        private Label label3;
        private Label label4;
        private Button btnRegistrar;
        private TextBox txtCorreo;
        private Label label6;
        private Label label7;
        private TextBox txtDireccion;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox txtCedula;
    }
}