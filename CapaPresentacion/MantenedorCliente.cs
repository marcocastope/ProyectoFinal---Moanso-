using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            ListarCliente();
            btnAgregar.Enabled = false;
            groupBoxDatosCliente.Enabled = false;
            textBoxIdCliente.Enabled = false;
            btnModificar.Enabled = false;
        }
        public void ListarCliente()
        {
            dgVCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            groupBoxDatosCliente.Enabled = true;
            limpiarFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                entCliente c = new entCliente();
                c.dni = int.Parse(textBoxDni.Text.Trim());
                c.nombreCliente = textBoxNombreCliente.Text.Trim();
                c.profesion = textBoxProfesion.Text.Trim();
                c.ciudad = comboBoxCiudad.Text.Trim();
                c.tipoCliente = comboBoxTipoCliente.Text.Trim();
                c.estAtencionCliente = cbkestAtencionCliente.Checked;
                c.fecRegCliente = dtPickerRegCliente.Value;
  
                logCliente.Instancia.insertaCliente(c);
            }

            catch (Exception ex)

            {
                MessageBox.Show("Error" + ex);
            }

            groupBoxDatosCliente.Enabled = false;

            ListarCliente();
            limpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatosCliente.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();

                c.IdCliente = int.Parse(textBoxIdCliente.Text.Trim());
                c.dni = int.Parse(textBoxDni.Text.Trim());
                c.nombreCliente = textBoxNombreCliente.Text.Trim();
                c.profesion = textBoxProfesion.Text.Trim();
                c.ciudad = comboBoxCiudad.Text.Trim();
                c.tipoCliente = comboBoxTipoCliente.Text.Trim();
                c.estAtencionCliente = cbkestAtencionCliente.Checked;
                c.fecRegCliente = dtPickerRegCliente.Value;

                logCliente.Instancia.editaCliente(c);
            }

            catch (Exception ex)

            {
                MessageBox.Show("Error" + ex);

            }
            groupBoxDatosCliente.Enabled = false;

            ListarCliente();
            limpiarFormulario();
        }

        private void dgVServicio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow FilaActualMouse = dgVCliente.Rows[e.RowIndex];
            textBoxIdCliente.Text = FilaActualMouse.Cells[0].Value.ToString();
            textBoxDni.Text = FilaActualMouse.Cells[1].Value.ToString();
            textBoxNombreCliente.Text = FilaActualMouse.Cells[2].Value.ToString();
            textBoxProfesion.Text = FilaActualMouse.Cells[3].Value.ToString();
            comboBoxCiudad.Text = FilaActualMouse.Cells[4].Value.ToString();
            comboBoxTipoCliente.Text = FilaActualMouse.Cells[5].Value.ToString();
            cbkestAtencionCliente.Checked = Convert.ToBoolean(FilaActualMouse.Cells[6].Value.ToString());
            dtPickerRegCliente.Text = FilaActualMouse.Cells[7].Value.ToString();



        }
        private void limpiarFormulario()
        {
            textBoxIdCliente.Clear();
            textBoxDni.Clear();
            textBoxNombreCliente.Clear();
            textBoxProfesion.Clear();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.IdCliente= int.Parse(textBoxIdCliente.Text.Trim());
                cbkestAtencionCliente.Checked = false;
                c.estAtencionCliente = cbkestAtencionCliente.Checked;
                logCliente.Instancia.deshabilitaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            limpiarFormulario();
            groupBoxDatosCliente.Enabled = false;
            ListarCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
