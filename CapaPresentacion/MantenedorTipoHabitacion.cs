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

        private void listaPersonalGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registrarTipolBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoHabitacion = new entTipoHabitacion();

                tipoHabitacion.Tipo = tipolHabitacionTxt.Text.Trim();
                tipoHabitacion.Descripcion = tipoHabitacionDescripcionTxt.Text.Trim();
                tipoHabitacion.Estado = estadoHabitacionCheck.Checked;
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
        }

        private void listarTiposHabitacion()
        {
            listaTiposHabitacionGridView.DataSource = logTipoHabitacion.Instance.listarTipoHabitacion();
        }

        private void limpiarFormulario()
        {
            tipolHabitacionTxt.Clear();
            tipoHabitacionDescripcionTxt.Clear();
        }
    }
}
