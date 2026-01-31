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
            var empleadoLog = Empc.IniciarSesion(txtCorreo.Text.Trim().ToLower(), txtContrasena.Text.Trim());
            if (empleadoLog == null)
            {
                MessageBox.Show("Credenciales incorrectas");
                return;
            }

            switch (empleadoLog.Rol)
            {
                
                case RolEmpleado.Recepcion:
                    this.Hide();
                    var frmPrincipalRecepcion = new PrincipalRecepcion(empleadoLog);
                    frmPrincipalRecepcion.ShowDialog();
                    this.Show();
                    break;
                case RolEmpleado.Administrador:
                    this.Hide();
                    var frmPrincipal = new PrincipalAdministracion(Empc);
                    frmPrincipal.ShowDialog();
                    this.Show();
                    break;

                case RolEmpleado.Limpieza:
                    this.Hide();
                    var frmPrincipalLimpieza = new PrincipalLimpieza();
                    frmPrincipalLimpieza.ShowDialog();
                    this.Show();
                    break;

                default:
                    MessageBox.Show("Rol no reconocido. Consulte Administración");
                    return;
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
