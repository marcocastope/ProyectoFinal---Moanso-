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
            datosHabitacionGBox.Enabled = false;
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
            listaHabitacionesGridView.DataSource = logHabitacion.Instance.listarHabitaciones();
        }

        private void llenarDatosComboBoxTipo() {
            tipoHabitacionCbo.DataSource = logTipoHabitacion.Instance.listarTipoHabitacion();
            tipoHabitacionCbo.DisplayMember = "Tipo";
            tipoHabitacionCbo.ValueMember = "ID";
        }

        private void limpiarFormulario()
        {
            idHabitacionTxt.Clear();
            numeroHabitacionTxt.Clear();
            cantCamasTxt.Clear();
            ubicacionPisoTxt.Clear();
            precioHabitacionTxt.Clear();
        }

        private void modificarHabitacionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var habitacion = new entHabitacion();
                habitacion.idHabitacion = int.Parse(idHabitacionTxt.Text.Trim());
                habitacion.numeroHabitacion = numeroHabitacionTxt.Text.Trim();
                habitacion.cantidadCamas = Convert.ToInt32(cantCamasTxt.Text.Trim());
                habitacion.pisoHabitacion = ubicacionPisoTxt.Text.Trim();
                habitacion.precio = Convert.ToDouble(precioHabitacionTxt.Text.Trim());
                habitacion.idTipoHabitacion = Convert.ToInt32(tipoHabitacionCbo.SelectedValue);
                habitacion.estadoHabitacion = estHabitacionCheck.Checked;
                logHabitacion.Instance.editarHabitacion(habitacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            MessageBox.Show("Habitacion editado correctamente");
            listarHabitaciones();
            limpiarFormulario();
        }

        private void deshabilitarHabitacionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var habitacion = new entHabitacion();
                habitacion.idHabitacion = int.Parse(idHabitacionTxt.Text.Trim());
                estHabitacionCheck.Checked = false;
                habitacion.estadoHabitacion = estHabitacionCheck.Checked;
                logHabitacion.Instance.desabilitarHabitacion(habitacion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            MessageBox.Show("Habitacion deshablitado correctamente");
            limpiarFormulario();
            datosHabitacionGBox.Enabled = false;
            listarHabitaciones();
        }

        private void nuevoHabitacionBtn_Click(object sender, EventArgs e)
        {
            datosHabitacionGBox.Enabled = true;
            limpiarFormulario();
        }

        private void listarHabitacionesOnClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = listaHabitacionesGridView.Rows[e.RowIndex];
            idHabitacionTxt.Text = filaActual.Cells[0].Value.ToString();
            numeroHabitacionTxt.Text = filaActual.Cells[1].Value.ToString();
            tipoHabitacionCbo.Text = filaActual.Cells[2].Value.ToString();
            cantCamasTxt.Text = filaActual.Cells[3].Value.ToString();
            ubicacionPisoTxt.Text = filaActual.Cells[4].Value.ToString();
            precioHabitacionTxt.Text = filaActual.Cells[5].Value.ToString();
            estHabitacionCheck.Checked = Convert.ToBoolean(filaActual.Cells[6].Value.ToString());
        }
    }
}
