using Controlador;
using Datos;
using Entidades;
using Modelo;
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
    public partial class InsertarHabitacion : Form
    {

        HabitacionControlador habitacionControlador = new HabitacionControlador();
        HabitacionDatos habitacionDatos = new HabitacionDatos();
        public InsertarHabitacion()
        {
            InitializeComponent();
        }

        private void InsertarHabitacion_Load(object sender, EventArgs e)
        {
            habitacionDGV.DataSource = null;
            habitacionDGV.DataSource = habitacionDatos.ListarHabitacion();
        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {

            bool resultado = false;

            Habitacion habitacion = new Habitacion(
                Convert.ToInt32(idTXT.Text),
                Convert.ToInt32(tidCB.SelectedItem.ToString()),
                Convert.ToInt32(numhabitacionTXT.Text),
                ubicacionCB.SelectedItem.ToString());

            if (habitacion.Id_tipo_habitacion == 0)
                resultado = habitacionControlador.GuardarHabitacion(habitacion);
            else
                resultado = (habitacionControlador.ActualizarHabitacion(habitacion));

            if (habitacionControlador.GuardarHabitacion(habitacion))
                MessageBox.Show("El usuario se ha registrado correctamente");
            else
                MessageBox.Show("El usuario no se ha registrado correctamente");

            habitacionDGV.DataSource = habitacionDatos.ListarHabitacion();
        }

        private void eliminarBTN_Click(object sender, EventArgs e)
        {
            Habitacion habitacion = new Habitacion(
                Convert.ToInt32(idTXT.Text),
                Convert.ToInt32(tidCB.SelectedItem.ToString()),
                Convert.ToInt32(numhabitacionTXT.Text),
                ubicacionCB.SelectedItem.ToString());

            if (habitacionControlador.EliminarHabitacion(habitacion))
                MessageBox.Show("La habitacion se ha eliminado correctamente");
            else
                MessageBox.Show("La habitacion no se ha eliminado correctamente");
            habitacionDGV.DataSource = habitacionDatos.ListarHabitacion();
        }

        private void nuevoBTN_Click(object sender, EventArgs e)
        {
            idTXT.Text = 0.ToString();
            tidCB.SelectedItem = null;
            numhabitacionTXT.Text = null;
            ubicacionCB.SelectedItem = null;
        }

        private void habitacionDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (habitacionDGV.SelectedRows.Count > 0)
            {
                idTXT.Text = habitacionDGV.SelectedRows[0].Cells["id_Habitacion"].Value.ToString();
                tidCB.Text = habitacionDGV.SelectedRows[0].Cells["id_tipo_Habitacion"].Value.ToString();
                numhabitacionTXT.Text = habitacionDGV.SelectedRows[0].Cells["numero_habitacion"].Value.ToString();
                ubicacionCB.Text = habitacionDGV.SelectedRows[0].Cells["ubicacion"].Value.ToString();
            }
        }
    }
}
