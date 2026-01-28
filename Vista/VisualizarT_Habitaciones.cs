using Datos;
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
    public partial class VisualizarT_Habitaciones : Form
    {
        public VisualizarT_Habitaciones()
        {
            InitializeComponent();
        }

        private void VisualizarT_Habitaciones_Load(object sender, EventArgs e)
        {
            TipoHabitacionDatos tipohabitacionDatos = new TipoHabitacionDatos();
            tipohabitacionesDGV.DataSource = null;
            tipohabitacionesDGV.DataSource = tipohabitacionDatos.ListarT_Habitacion();
        }
    }
}
