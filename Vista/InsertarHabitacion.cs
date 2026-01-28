using Datos;
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
using Controlador;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Habitacion habitacion = new Habitacion(
                0,
                Convert.ToInt32(tidCB.SelectedItem.ToString()),
                Convert.ToInt32(numhabitacionTXT.Text),
                ubicacionCB.SelectedItem.ToString());
            if (habitacionControlador.GuardarHabitacion(habitacion))
                MessageBox.Show("El usuario se ha registrado correctamente");
            else
                MessageBox.Show("El usuario no se ha registrado correctamente");

            habitacionDGV.DataSource = habitacionDatos.ListarHabitacion();
        }

    }
}
