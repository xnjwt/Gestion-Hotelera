
namespace Vista
{
    partial class ActualizarClientes
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
            cbActivo = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(78, 26);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombres: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(78, 52);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(223, 23);
            txtNombres.TabIndex = 1;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(78, 102);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(223, 23);
            txtApellidos.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(78, 78);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Apellidos:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCelular
            // 
            txtCelular.ForeColor = Color.Black;
            txtCelular.Location = new Point(78, 194);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(223, 23);
            txtCelular.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(78, 171);
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
            label4.Location = new Point(78, 322);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 7;
            label4.Text = "Fecha De Nacimiento : ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Indigo;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(70, 423);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(231, 56);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(78, 145);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(223, 23);
            txtCorreo.TabIndex = 13;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.BlueViolet;
            label6.Location = new Point(78, 125);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 12;
            label6.Text = "Correo:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.BlueViolet;
            label7.Location = new Point(78, 220);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 14;
            label7.Text = "Direccion: ";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Location = new Point(78, 240);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(223, 23);
            txtDireccion.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(78, 347);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(223, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.BlueViolet;
            label5.Location = new Point(78, 266);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 17;
            label5.Text = "Cedula: ";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(78, 290);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(223, 23);
            txtCedula.TabIndex = 18;
            // 
            // cbActivo
            // 
            cbActivo.AutoSize = true;
            cbActivo.ForeColor = Color.BlueViolet;
            cbActivo.Location = new Point(78, 384);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(60, 19);
            cbActivo.TabIndex = 19;
            cbActivo.Text = "Activo";
            cbActivo.UseVisualStyleBackColor = true;
            // 
            // ActualizarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 536);
            Controls.Add(cbActivo);
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
            Name = "ActualizarClientes";
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
        private CheckBox cbActivo;
    }
}