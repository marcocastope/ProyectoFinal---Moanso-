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
    public partial class MantenedorTipoHabitacion : Form
    {
        public MantenedorTipoHabitacion()
        {
            InitializeComponent();
            listarTiposHabitacion();
            datosTipoHabitacionGBox.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

      

        private void registrarTipolBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoHabitacion = new entTipoHabitacion();

                tipoHabitacion.Tipo = tipolHabitacionTxt.Text.Trim();
                tipoHabitacion.Descripcion = tipoHabitacionDescripcionTxt.Text.Trim();
                tipoHabitacion.Estado = estadoTipoHabitacionCheck.Checked;
                logTipoHabitacion.Instance.insertarTipoHabitacion(tipoHabitacion);
            } catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            MessageBox.Show("Tipo de habitacion registrado correctamente");
            listarTiposHabitacion();
            limpiarFormulario();
        }

        private void nuevoTipoBtn_Click(object sender, EventArgs e)
        {
            datosTipoHabitacionGBox.Enabled = true;
            limpiarFormulario();
        }

        private void listarTiposHabitacion()
        {
            listaTiposHabitacionGridView.DataSource = logTipoHabitacion.Instance.listarTipoHabitacion();
        }

        private void limpiarFormulario()
        {
            idTipoHabitacionTxt.Clear();
            tipolHabitacionTxt.Clear();
            tipoHabitacionDescripcionTxt.Clear();
            estadoTipoHabitacionCheck.Checked = false;
        }

        private void listaTiposHabitacionGridViewOnClick(object sender, DataGridViewCellEventArgs e)
        {
   
            DataGridViewRow filaActual = listaTiposHabitacionGridView.Rows[e.RowIndex];
            idTipoHabitacionTxt.Text = filaActual.Cells[0].Value.ToString();
            tipolHabitacionTxt.Text = filaActual.Cells[1].Value.ToString();
            tipoHabitacionDescripcionTxt.Text = filaActual.Cells[2].Value.ToString();
            estadoTipoHabitacionCheck.Checked = Convert.ToBoolean(filaActual.Cells[3].Value.ToString());
        }

        private void deshablitarTipoHabitacionBtn_Click(object sender, EventArgs e)
        {
           
            try {
                var tipoHabitacion = new entTipoHabitacion();
                tipoHabitacion.Id = int.Parse(idTipoHabitacionTxt.Text.Trim());
                estadoTipoHabitacionCheck.Checked = false;
                tipoHabitacion.Estado = estadoTipoHabitacionCheck.Checked;
                logTipoHabitacion.Instance.desabilitarTipoHabitacion(tipoHabitacion);
            
            } catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            MessageBox.Show("Tipo de habitacion deshablitado correctamente");
            limpiarFormulario();
            datosTipoHabitacionGBox.Enabled = false;
            listarTiposHabitacion();
        }

        private void modificarTipoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoHabitacion = new entTipoHabitacion();
                tipoHabitacion.Id = int.Parse(idTipoHabitacionTxt.Text.Trim());
                tipoHabitacion.Tipo = tipolHabitacionTxt.Text.Trim();
                tipoHabitacion.Descripcion = tipoHabitacionDescripcionTxt.Text.Trim();
                tipoHabitacion.Estado = estadoTipoHabitacionCheck.Checked;
                logTipoHabitacion.Instance.editarTipoHabitacion(tipoHabitacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            MessageBox.Show("Tipo de habitacion modificado correctamente");
            listarTiposHabitacion();
            limpiarFormulario();
        }
    }
}
