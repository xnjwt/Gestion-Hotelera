using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        private EmpleadoControlador Empc { get; set; }

        //Colocar los demás controladores que se necesiten

        public Login(EmpleadoControlador empc) //Pasar por parámetro los demás controladores
        {
            InitializeComponent();
            Empc = empc;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var empleados = Empc.ListarEmpleados();

            var empleadoLogueado = empleados
            .FirstOrDefault(e =>
                e.Email.Equals(txtCorreo.Text.Trim(), StringComparison.CurrentCultureIgnoreCase) &&
                e.Contrasena.Equals(txtContrasena.Text.Trim(), StringComparison.CurrentCultureIgnoreCase) &&
                e.Estado.Equals("activo", StringComparison.CurrentCultureIgnoreCase)
            );

            if (empleadoLogueado != null)
            {
                MessageBox.Show("Ingreso exitoso");
                this.Hide();
                var frmPrincipal = new Principal(Empc);
                frmPrincipal.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
