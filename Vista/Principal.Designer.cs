namespace Vista
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            menuStrip1 = new MenuStrip();
            empleadoToolStripMenuItem = new ToolStripMenuItem();
            contratarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            habitacionToolStripMenuItem = new ToolStripMenuItem();
            registrarNuevaToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            tipoDeHabToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem2 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { empleadoToolStripMenuItem, habitacionToolStripMenuItem, tipoDeHabToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // empleadoToolStripMenuItem
            // 
            empleadoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contratarToolStripMenuItem, listarToolStripMenuItem });
            empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            empleadoToolStripMenuItem.Size = new Size(72, 20);
            empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // contratarToolStripMenuItem
            // 
            contratarToolStripMenuItem.Name = "contratarToolStripMenuItem";
            contratarToolStripMenuItem.Size = new Size(124, 22);
            contratarToolStripMenuItem.Text = "Contratar";
            contratarToolStripMenuItem.Click += contratarToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(124, 22);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // habitacionToolStripMenuItem
            // 
            habitacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarNuevaToolStripMenuItem, listarToolStripMenuItem1 });
            habitacionToolStripMenuItem.Name = "habitacionToolStripMenuItem";
            habitacionToolStripMenuItem.Size = new Size(77, 20);
            habitacionToolStripMenuItem.Text = "Habitacion";
            habitacionToolStripMenuItem.Click += habitacionToolStripMenuItem_Click;
            // 
            // registrarNuevaToolStripMenuItem
            // 
            registrarNuevaToolStripMenuItem.Name = "registrarNuevaToolStripMenuItem";
            registrarNuevaToolStripMenuItem.Size = new Size(155, 22);
            registrarNuevaToolStripMenuItem.Text = "Registrar nueva";
            registrarNuevaToolStripMenuItem.Click += registrarNuevaToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(155, 22);
            listarToolStripMenuItem1.Text = "Listar";
            listarToolStripMenuItem1.Click += listarToolStripMenuItem1_Click;
            // 
            // tipoDeHabToolStripMenuItem
            // 
            tipoDeHabToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem, listarToolStripMenuItem2 });
            tipoDeHabToolStripMenuItem.Name = "tipoDeHabToolStripMenuItem";
            tipoDeHabToolStripMenuItem.Size = new Size(87, 20);
            tipoDeHabToolStripMenuItem.Text = "Tipo de Hab.";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(102, 22);
            crearToolStripMenuItem.Text = "Crear";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem2
            // 
            listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            listarToolStripMenuItem2.Size = new Size(102, 22);
            listarToolStripMenuItem2.Text = "Listar";
            listarToolStripMenuItem2.Click += listarToolStripMenuItem2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(669, 425);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem empleadoToolStripMenuItem;
        private ToolStripMenuItem contratarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem habitacionToolStripMenuItem;
        private ToolStripMenuItem tipoDeHabToolStripMenuItem;
        private ToolStripMenuItem registrarNuevaToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}