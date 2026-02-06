using Controlador;
using Datos;
using Entidades;
using System.Windows.Forms;

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

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            bool resultado = false;

            TipoHabitacion tipohabitacion = new TipoHabitacion(
                Convert.ToInt32(idTXT.Text),
                nombreTXT.Text,
                capacidadTXT.Text,
                Convert.ToInt32(precio_nocheTXT.Text),
                caracteristicasTXT.Text);

            if (tipohabitacion.Id_tipo_habitacion == 0)
                resultado = tipohabitacionControlador.GuardarTipoHabitacion(tipohabitacion);
            else
                resultado = (tipohabitacionControlador.ActualizarTipoHabitacion(tipohabitacion));

            if (resultado)
                MessageBox.Show("El usuario se ha registrado/actualizado correctamente");
            else
                MessageBox.Show("El usuario no se ha registrado/actualizado correctamente");

            tipohabitacionDGV.DataSource = tipohabitacionDatos.ListarT_Habitacion();
        }

        private void tipohabitacionDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (tipohabitacionDGV.SelectedRows.Count > 0)
            {
                idTXT.Text = tipohabitacionDGV.SelectedRows[0].Cells["id_tipo_Habitacion"].Value.ToString();
                nombreTXT.Text = tipohabitacionDGV.SelectedRows[0].Cells["Nombre"].Value.ToString();
                capacidadTXT.Text = tipohabitacionDGV.SelectedRows[0].Cells["Capacidad"].Value.ToString();
                precio_nocheTXT.Text = tipohabitacionDGV.SelectedRows[0].Cells["Precio_noche"].Value.ToString();
                caracteristicasTXT.Text = tipohabitacionDGV.SelectedRows[0].Cells["Caracteristicas"].Value.ToString();
            }


        }

        private void eliminarBTN_Click(object sender, EventArgs e)
        {
            TipoHabitacion tipohabitacion = new TipoHabitacion(
                Convert.ToInt32(idTXT.Text),
                nombreTXT.Text,
                capacidadTXT.Text,
                Convert.ToInt32(precio_nocheTXT.Text),
                caracteristicasTXT.Text);
            if (tipohabitacionControlador.EliminarTipoHabitacion(tipohabitacion))
                MessageBox.Show("El tipo de habitacion se ha eliminado correctamente");
            else
                MessageBox.Show("El usuario no se ha eliminado correctamente");
            tipohabitacionDGV.DataSource = tipohabitacionDatos.ListarT_Habitacion();
        }

        private void nuevoBTN_Click(object sender, EventArgs e)
        {
            idTXT.Text = 0.ToString();
            nombreTXT.Text = null;
            capacidadTXT.Text = null;
            precio_nocheTXT.Text = null;
            caracteristicasTXT.Text = null;
        }
    }
}
