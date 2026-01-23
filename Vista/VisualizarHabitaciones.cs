using Controlador;
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
    public partial class VisualizarHabitaciones : Form
    {

        HabitacionControlador habitacionControlador = new HabitacionControlador();
        public VisualizarHabitaciones()
        {
            InitializeComponent();
        }

        private void VisualizarHabitaciones_Load(object sender, EventArgs e)
        {
            // Asegurar que el combo no permita escribir
            habitacionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarTiposHabitacion();
            CargarHabitaciones();
        }

        private void CargarTiposHabitacion()
        {
            try
            {
                var tipos = habitacionControlador.ObtenerTiposHabitacion();

                habitacionComboBox.Items.Clear();

                foreach (var tipo in tipos)
                    habitacionComboBox.Items.Add(tipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos: " + ex.Message);
            }
        }

        private void CargarHabitaciones()
        {
            try
            {
                var lista = habitacionControlador.ObtenerHabitaciones();
                habitacionesDGV.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void habitacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si no hay selección, salir
            if (habitacionComboBox.SelectedItem == null)
                return;

            string tipoSeleccionado = habitacionComboBox.SelectedItem.ToString();

            try
            {
                var lista = habitacionControlador.ObtenerHabitacionesPorTipo(tipoSeleccionado);
                habitacionesDGV.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
            }
        }

        private void btnMostarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                CargarHabitaciones();   // ← Vuelve a cargar TODAS las habitaciones
                habitacionComboBox.SelectedIndex = -1; // Limpia selección del ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar todas: " + ex.Message);
            }
        }
    }
}
