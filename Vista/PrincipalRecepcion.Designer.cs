namespace Vista
{
    partial class PrincipalRecepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalRecepcion));
            menuStrip1 = new MenuStrip();
            reservaToolStripMenuItem = new ToolStripMenuItem();
            RegistrarReservaToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            ClientesToolStripMenuItem = new ToolStripMenuItem();
            RegistrarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            PagosToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem2 = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            reservaToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { reservaToolStripMenuItem, ClientesToolStripMenuItem, PagosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RegistrarReservaToolStripMenuItem, listarToolStripMenuItem, reservaToolStripMenuItem1 });
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(74, 24);
            reservaToolStripMenuItem.Text = "Reserva";
            // 
            // RegistrarReservaToolStripMenuItem
            // 
            RegistrarReservaToolStripMenuItem.Name = "RegistrarReservaToolStripMenuItem";
            RegistrarReservaToolStripMenuItem.Size = new Size(224, 26);
            RegistrarReservaToolStripMenuItem.Text = "Registrar";
            RegistrarReservaToolStripMenuItem.Click += contratarToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(224, 26);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // ClientesToolStripMenuItem
            // 
            ClientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RegistrarToolStripMenuItem, listarToolStripMenuItem1 });
            ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            ClientesToolStripMenuItem.Size = new Size(75, 24);
            ClientesToolStripMenuItem.Text = "Clientes";
            ClientesToolStripMenuItem.Click += habitacionToolStripMenuItem_Click;
            // 
            // RegistrarToolStripMenuItem
            // 
            RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem";
            RegistrarToolStripMenuItem.Size = new Size(127, 26);
            RegistrarToolStripMenuItem.Text = "Crear";
            RegistrarToolStripMenuItem.Click += registrarNuevaToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(127, 26);
            listarToolStripMenuItem1.Text = "Listar";
            listarToolStripMenuItem1.Click += listarToolStripMenuItem1_Click;
            // 
            // PagosToolStripMenuItem
            // 
            PagosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem, listarToolStripMenuItem2 });
            PagosToolStripMenuItem.Name = "PagosToolStripMenuItem";
            PagosToolStripMenuItem.Size = new Size(62, 24);
            PagosToolStripMenuItem.Text = "Pagos";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(151, 26);
            crearToolStripMenuItem.Text = "Registrar";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem2
            // 
            listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            listarToolStripMenuItem2.Size = new Size(151, 26);
            listarToolStripMenuItem2.Text = "Listar";
            listarToolStripMenuItem2.Click += listarToolStripMenuItem2_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 36);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(765, 567);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // reservaToolStripMenuItem1
            // 
            reservaToolStripMenuItem1.Name = "reservaToolStripMenuItem1";
            reservaToolStripMenuItem1.Size = new Size(224, 26);
            reservaToolStripMenuItem1.Text = "Reserva";
            // 
            // PrincipalRecepcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrincipalRecepcion";
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
        private ToolStripMenuItem reservaToolStripMenuItem;
        private ToolStripMenuItem RegistrarReservaToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem ClientesToolStripMenuItem;
        private ToolStripMenuItem PagosToolStripMenuItem;
        private ToolStripMenuItem RegistrarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem reservaToolStripMenuItem1;
    }
}