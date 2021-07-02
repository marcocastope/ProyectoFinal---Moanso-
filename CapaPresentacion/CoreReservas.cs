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
    public partial class CoreReservas : Form
    {
        public CoreReservas()
        {
            InitializeComponent();
            listarReservas();
            llenarDatosComboBox();
        }

        private void CoreReservas_Load(object sender, EventArgs e)
        {

        }

        private void datosReservaGBox_Enter(object sender, EventArgs e)
        {

        }

        private void registrarReservaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var reserva = new entReserva();

                reserva.idCliente = Convert.ToInt32(comboBoxCliente.SelectedValue);
                reserva.idHabitacion = Convert.ToInt32(comboBoxHabitacion.SelectedValue);
                reserva.checkIn = dateTimePickerCheckIn.Value;
                reserva.checkOut = dateTimePickerCheckOut.Value;
                reserva.estadoReserva = checkBoxEstadoReserva.Checked;
                logReserva.Instance.insertarReserva(reserva);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            MessageBox.Show("Reserva registrado correctamente");
            listarReservas();
            limpiarFormulario();
        }

        private void listarReservas()
        {
            dataGridViewReservas.DataSource = logReserva.Instance.listarReservas();
        }

        private void llenarDatosComboBox()
        {
            comboBoxCliente.DataSource = logCliente.Instancia.ListarCliente();
            comboBoxCliente.DisplayMember = "nombreCliente";
            comboBoxCliente.ValueMember = "IdCliente";

            comboBoxHabitacion.DataSource = logHabitacion.Instance.listarHabitaciones();
            comboBoxHabitacion.DisplayMember = "numeroHabitacion";
            comboBoxHabitacion.ValueMember = "idHabitacion";
        }

        private void limpiarFormulario()
        {
            
        }
    }
}
