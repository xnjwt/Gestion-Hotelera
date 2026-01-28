namespace Vista
{
    partial class VisualizarT_Habitaciones
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
            tipohabitacionesDGV = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tipohabitacionesDGV).BeginInit();
            SuspendLayout();
            // 
            // tipohabitacionesDGV
            // 
            tipohabitacionesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tipohabitacionesDGV.Location = new Point(12, 27);
            tipohabitacionesDGV.Name = "tipohabitacionesDGV";
            tipohabitacionesDGV.Size = new Size(776, 411);
            tipohabitacionesDGV.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 1;
            label1.Text = "Tipos de Habitaciones";
            // 
            // VisualizarT_Habitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tipohabitacionesDGV);
            Name = "VisualizarT_Habitaciones";
            Text = "Form2";
            Load += VisualizarT_Habitaciones_Load;
            ((System.ComponentModel.ISupportInitialize)tipohabitacionesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tipohabitacionesDGV;
        private Label label1;
    }
}