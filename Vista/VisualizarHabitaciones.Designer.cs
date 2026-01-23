namespace Vista
{
    partial class VisualizarHabitaciones
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
            habitacionComboBox = new ComboBox();
            habitacionesDGV = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            MostarTodo_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)habitacionesDGV).BeginInit();
            SuspendLayout();
            // 
            // habitacionComboBox
            // 
            habitacionComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Estandar", "Familiar", "De lujo" });
            habitacionComboBox.FormattingEnabled = true;
            habitacionComboBox.Location = new Point(12, 37);
            habitacionComboBox.Name = "habitacionComboBox";
            habitacionComboBox.Size = new Size(121, 23);
            habitacionComboBox.TabIndex = 0;
            // 
            // habitacionesDGV
            // 
            habitacionesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            habitacionesDGV.Location = new Point(194, 37);
            habitacionesDGV.Name = "habitacionesDGV";
            habitacionesDGV.Size = new Size(594, 315);
            habitacionesDGV.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Habitación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 19);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Habitaciones";
            // 
            // MostarTodo_Click
            // 
            MostarTodo_Click.Location = new Point(24, 75);
            MostarTodo_Click.Name = "MostarTodo_Click";
            MostarTodo_Click.Size = new Size(85, 44);
            MostarTodo_Click.TabIndex = 4;
            MostarTodo_Click.Text = "Mostrar todo";
            MostarTodo_Click.UseVisualStyleBackColor = true;
            // 
            // VisualizarHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MostarTodo_Click);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(habitacionesDGV);
            Controls.Add(habitacionComboBox);
            Name = "VisualizarHabitaciones";
            Text = "Form2";
            Load += VisualizarHabitaciones_Load;
            ((System.ComponentModel.ISupportInitialize)habitacionesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox habitacionComboBox;
        private DataGridView habitacionesDGV;
        private Label label1;
        private Label label2;
        private Button MostarTodo_Click;
    }
}