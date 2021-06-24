using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MantenedorHabitacion : Form
    {
        public MantenedorHabitacion()
        {
            InitializeComponent();
            listarHabitaciones();
            llenarDatosComboBoxTipo();
        }

        private void registrarHabtacionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var habitacion = new entHabitacion();

                habitacion.numeroHabitacion = numeroHabitacionTxt.Text.Trim();
                habitacion.cantidadCamas = Convert.ToInt32(cantCamasTxt.Text.Trim());
                habitacion.pisoHabitacion = ubicacionPisoTxt.Text.Trim();
                habitacion.precio = Convert.ToDouble(precioHabitacionTxt.Text.Trim());
                habitacion.idTipoHabitacion = Convert.ToInt32(tipoHabitacionCbo.SelectedValue);
                habitacion.estadoHabitacion = estHabitacionCheck.Checked;
                logHabitacion.Instance.insertarHabitacion(habitacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            MessageBox.Show("Habitacion registrado correctamente");
            listarHabitaciones();
            limpiarFormulario();
        }

        private void listarHabitaciones()
        {
            listaHabitacionesGridView.DataSource = logHabitacion.Instance.listarHabitacion();
        }

        private void llenarDatosComboBoxTipo() {
            tipoHabitacionCbo.DataSource = logTipoHabitacion.Instance.listarTipoHabitacion();
            tipoHabitacionCbo.DisplayMember = "Tipo";
            tipoHabitacionCbo.ValueMember = "ID";
        }

        private void limpiarFormulario()
        {
            numeroHabitacionTxt.Clear();
            cantCamasTxt.Clear();
            ubicacionPisoTxt.Clear();
            precioHabitacionTxt.Clear();
        }
    }
}
