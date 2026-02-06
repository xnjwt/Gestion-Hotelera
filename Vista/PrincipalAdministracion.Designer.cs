namespace Vista
{
    partial class PrincipalAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalAdministracion));
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
            salirToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem1 = new ToolStripMenuItem();
            listarToolStripMenuItem3 = new ToolStripMenuItem();
            reservaToolStripMenuItem = new ToolStripMenuItem();
            reservarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem4 = new ToolStripMenuItem();
            pagosToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            pagarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { empleadoToolStripMenuItem, habitacionToolStripMenuItem, tipoDeHabToolStripMenuItem, clientesToolStripMenuItem, reservaToolStripMenuItem, pagosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // empleadoToolStripMenuItem
            // 
            empleadoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contratarToolStripMenuItem, listarToolStripMenuItem });
            empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            empleadoToolStripMenuItem.Size = new Size(91, 24);
            empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // contratarToolStripMenuItem
            // 
            contratarToolStripMenuItem.Name = "contratarToolStripMenuItem";
            contratarToolStripMenuItem.Size = new Size(154, 26);
            contratarToolStripMenuItem.Text = "Contratar";
            contratarToolStripMenuItem.Click += contratarToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(154, 26);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // habitacionToolStripMenuItem
            // 
            habitacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarNuevaToolStripMenuItem, listarToolStripMenuItem1 });
            habitacionToolStripMenuItem.Name = "habitacionToolStripMenuItem";
            habitacionToolStripMenuItem.Size = new Size(96, 24);
            habitacionToolStripMenuItem.Text = "Habitacion";
            habitacionToolStripMenuItem.Click += habitacionToolStripMenuItem_Click;
            // 
            // registrarNuevaToolStripMenuItem
            // 
            registrarNuevaToolStripMenuItem.Name = "registrarNuevaToolStripMenuItem";
            registrarNuevaToolStripMenuItem.Size = new Size(194, 26);
            registrarNuevaToolStripMenuItem.Text = "Registrar nueva";
            registrarNuevaToolStripMenuItem.Click += registrarNuevaToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(194, 26);
            listarToolStripMenuItem1.Text = "Listar";
            listarToolStripMenuItem1.Click += listarToolStripMenuItem1_Click;
            // 
            // tipoDeHabToolStripMenuItem
            // 
            tipoDeHabToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem, listarToolStripMenuItem2 });
            tipoDeHabToolStripMenuItem.Name = "tipoDeHabToolStripMenuItem";
            tipoDeHabToolStripMenuItem.Size = new Size(109, 24);
            tipoDeHabToolStripMenuItem.Text = "Tipo de Hab.";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(224, 26);
            crearToolStripMenuItem.Text = "Crear";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem2
            // 
            listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            listarToolStripMenuItem2.Size = new Size(224, 26);
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
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem1, listarToolStripMenuItem3 });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // crearToolStripMenuItem1
            // 
            crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            crearToolStripMenuItem1.Size = new Size(224, 26);
            crearToolStripMenuItem1.Text = "Crear";
            crearToolStripMenuItem1.Click += crearToolStripMenuItem1_Click;
            // 
            // listarToolStripMenuItem3
            // 
            listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            listarToolStripMenuItem3.Size = new Size(224, 26);
            listarToolStripMenuItem3.Text = "Listar";
            listarToolStripMenuItem3.Click += listarToolStripMenuItem3_Click;
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reservarToolStripMenuItem, listarToolStripMenuItem4 });
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(74, 24);
            reservaToolStripMenuItem.Text = "Reserva";
            // 
            // reservarToolStripMenuItem
            // 
            reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            reservarToolStripMenuItem.Size = new Size(224, 26);
            reservarToolStripMenuItem.Text = "Reservar ";
            reservarToolStripMenuItem.Click += reservarToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem4
            // 
            listarToolStripMenuItem4.Name = "listarToolStripMenuItem4";
            listarToolStripMenuItem4.Size = new Size(224, 26);
            listarToolStripMenuItem4.Text = "Listar";
            listarToolStripMenuItem4.Click += listarToolStripMenuItem4_Click;
            // 
            // pagosToolStripMenuItem
            // 
            pagosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, pagarToolStripMenuItem });
            pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            pagosToolStripMenuItem.Size = new Size(62, 24);
            pagosToolStripMenuItem.Text = "Pagos";
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(224, 26);
            registrarToolStripMenuItem.Text = "Pagar ";
            registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click;
            // 
            // pagarToolStripMenuItem
            // 
            pagarToolStripMenuItem.Name = "pagarToolStripMenuItem";
            pagarToolStripMenuItem.Size = new Size(224, 26);
            pagarToolStripMenuItem.Text = "Listar";
            pagarToolStripMenuItem.Click += pagarToolStripMenuItem_Click;
            // 
            // PrincipalAdministracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrincipalAdministracion";
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
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem1;
        private ToolStripMenuItem listarToolStripMenuItem3;
        private ToolStripMenuItem reservaToolStripMenuItem;
        private ToolStripMenuItem reservarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem4;
        private ToolStripMenuItem pagosToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem pagarToolStripMenuItem;
    }
}