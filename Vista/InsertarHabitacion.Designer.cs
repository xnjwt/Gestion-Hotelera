namespace Vista
{
    partial class InsertarHabitacion
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
            idTXT = new TextBox();
            numhabitacionTXT = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            habitacionDGV = new DataGridView();
            ingresarBTN = new Button();
            tidCB = new ComboBox();
            ubicacionCB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)habitacionDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Habitacion ID";
            // 
            // idTXT
            // 
            idTXT.Enabled = false;
            idTXT.Location = new Point(12, 27);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(100, 23);
            idTXT.TabIndex = 1;
            // 
            // numhabitacionTXT
            // 
            numhabitacionTXT.Location = new Point(12, 134);
            numhabitacionTXT.Name = "numhabitacionTXT";
            numhabitacionTXT.Size = new Size(100, 23);
            numhabitacionTXT.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero de Habitación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de Habitacion ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Ubicación";
            // 
            // habitacionDGV
            // 
            habitacionDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            habitacionDGV.Location = new Point(158, 12);
            habitacionDGV.Name = "habitacionDGV";
            habitacionDGV.Size = new Size(630, 426);
            habitacionDGV.TabIndex = 8;
            // 
            // ingresarBTN
            // 
            ingresarBTN.Location = new Point(12, 231);
            ingresarBTN.Name = "ingresarBTN";
            ingresarBTN.Size = new Size(75, 23);
            ingresarBTN.TabIndex = 9;
            ingresarBTN.Text = "Ingresar";
            ingresarBTN.UseVisualStyleBackColor = true;
            ingresarBTN.Click += button1_Click;
            // 
            // tidCB
            // 
            tidCB.FormattingEnabled = true;
            tidCB.Items.AddRange(new object[] { "1", "2", "3" });
            tidCB.Location = new Point(12, 80);
            tidCB.Name = "tidCB";
            tidCB.Size = new Size(121, 23);
            tidCB.TabIndex = 10;
            // 
            // ubicacionCB
            // 
            ubicacionCB.FormattingEnabled = true;
            ubicacionCB.Items.AddRange(new object[] { "Primer piso", "Segundo piso", "Tercer piso" });
            ubicacionCB.Location = new Point(12, 188);
            ubicacionCB.Name = "ubicacionCB";
            ubicacionCB.Size = new Size(121, 23);
            ubicacionCB.TabIndex = 11;
            // 
            // InsertarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ubicacionCB);
            Controls.Add(tidCB);
            Controls.Add(ingresarBTN);
            Controls.Add(habitacionDGV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numhabitacionTXT);
            Controls.Add(label2);
            Controls.Add(idTXT);
            Controls.Add(label1);
            Name = "InsertarHabitacion";
            Text = "InsertarHabitacion";
            Load += InsertarHabitacion_Load;
            ((System.ComponentModel.ISupportInitialize)habitacionDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idTXT;
        private TextBox numhabitacionTXT;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView habitacionDGV;
        private Button ingresarBTN;
        private ComboBox tidCB;
        private ComboBox ubicacionCB;
    }
}