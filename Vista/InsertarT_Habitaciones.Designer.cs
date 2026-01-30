namespace Vista
{
    partial class InsertarT_Habitaciones
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
            ingresarBTN = new Button();
            tipohabitacionDGV = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            capacidadTXT = new TextBox();
            label2 = new Label();
            idTXT = new TextBox();
            label1 = new Label();
            nombreTXT = new TextBox();
            precio_nocheTXT = new TextBox();
            label5 = new Label();
            caracteristicasTXT = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)tipohabitacionDGV).BeginInit();
            SuspendLayout();
            // 
            // ingresarBTN
            // 
            ingresarBTN.Location = new Point(12, 415);
            ingresarBTN.Name = "ingresarBTN";
            ingresarBTN.Size = new Size(75, 23);
            ingresarBTN.TabIndex = 19;
            ingresarBTN.Text = "Ingresar";
            ingresarBTN.UseVisualStyleBackColor = true;
            ingresarBTN.Click += ingresarBTN_Click;
            // 
            // tipohabitacionDGV
            // 
            tipohabitacionDGV.BackgroundColor = Color.BlueViolet;
            tipohabitacionDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tipohabitacionDGV.Location = new Point(256, 14);
            tipohabitacionDGV.Name = "tipohabitacionDGV";
            tipohabitacionDGV.Size = new Size(532, 424);
            tipohabitacionDGV.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Location = new Point(12, 172);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 17;
            label4.Text = "Precio por noche";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(192, 0, 192);
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            // 
            // capacidadTXT
            // 
            capacidadTXT.Location = new Point(12, 136);
            capacidadTXT.Name = "capacidadTXT";
            capacidadTXT.Size = new Size(100, 23);
            capacidadTXT.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 14;
            label2.Text = "Capacidad (personas)";
            // 
            // idTXT
            // 
            idTXT.Enabled = false;
            idTXT.Location = new Point(12, 29);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(100, 23);
            idTXT.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 12;
            label1.Text = "Tipo Habitacion ID";
            // 
            // nombreTXT
            // 
            nombreTXT.Location = new Point(12, 82);
            nombreTXT.Name = "nombreTXT";
            nombreTXT.Size = new Size(100, 23);
            nombreTXT.TabIndex = 22;
            // 
            // precio_nocheTXT
            // 
            precio_nocheTXT.Location = new Point(12, 190);
            precio_nocheTXT.Name = "precio_nocheTXT";
            precio_nocheTXT.Size = new Size(100, 23);
            precio_nocheTXT.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(192, 0, 192);
            label5.Location = new Point(12, 228);
            label5.Name = "label5";
            label5.Size = new Size(170, 15);
            label5.TabIndex = 24;
            label5.Text = "Caracteristicas de la habitación";
            // 
            // caracteristicasTXT
            // 
            caracteristicasTXT.Location = new Point(12, 246);
            caracteristicasTXT.Name = "caracteristicasTXT";
            caracteristicasTXT.Size = new Size(238, 163);
            caracteristicasTXT.TabIndex = 25;
            caracteristicasTXT.Text = "";
            // 
            // InsertarT_Habitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(caracteristicasTXT);
            Controls.Add(label5);
            Controls.Add(precio_nocheTXT);
            Controls.Add(nombreTXT);
            Controls.Add(ingresarBTN);
            Controls.Add(tipohabitacionDGV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(capacidadTXT);
            Controls.Add(label2);
            Controls.Add(idTXT);
            Controls.Add(label1);
            Name = "InsertarT_Habitaciones";
            Text = "InsertarT_Habitaciones";
            Load += InsertarT_Habitaciones_Load;
            ((System.ComponentModel.ISupportInitialize)tipohabitacionDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ingresarBTN;
        private DataGridView tipohabitacionDGV;
        private Label label4;
        private Label label3;
        private TextBox capacidadTXT;
        private Label label2;
        private TextBox idTXT;
        private Label label1;
        private TextBox nombreTXT;
        private TextBox precio_nocheTXT;
        private Label label5;
        private RichTextBox caracteristicasTXT;
    }
}