using Controlador;
using Datos;
using Entidades;

namespace Vista
{
    public partial class InsertarT_Habitaciones : Form
    {

        TipoHabitacionControlador tipohabitacionControlador = new TipoHabitacionControlador();
        TipoHabitacionDatos tipohabitacionDatos = new TipoHabitacionDatos();

        public InsertarT_Habitaciones()
        {
            InitializeComponent();
        }

        private void InsertarT_Habitaciones_Load(object sender, EventArgs e)
        {
            tipohabitacionDGV.DataSource = null;
            tipohabitacionDGV.DataSource = tipohabitacionDatos.ListarT_Habitacion();
        }

        private void ingresarBTN_Click(object sender, EventArgs e)
        {
            TipoHabitacion tipohabitacion = new TipoHabitacion(
                0,
                nombreTXT.Text,
                capacidadTXT.Text,
                Convert.ToInt32(precio_nocheTXT.Text),
                caracteristicasTXT.Text);      
            if (tipohabitacionControlador.GuardarTipoHabitacion(tipohabitacion))
                MessageBox.Show("El usuario se ha registrado correctamente");
            else
                MessageBox.Show("El usuario no se ha registrado correctamente");

            tipohabitacionDGV.DataSource = tipohabitacionDatos.ListarT_Habitacion();
        }
    }
}
