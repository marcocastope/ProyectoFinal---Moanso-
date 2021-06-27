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
    public partial class MantenedorServicio : Form
    {
        public MantenedorServicio()
        {
            InitializeComponent();
            ListarServicio();
            btnAgregar.Enabled = false;
            groupBoxDatosServicio.Enabled = false;
            textBoxNroServicio.Enabled = false;
            btnModificar.Enabled = false;
        }
        public void ListarServicio()
        {
            dgVServicio.DataSource = logServicio.Instancia.ListarServicio();
        }

       private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            groupBoxDatosServicio.Enabled = true;
            limpiarFormulario();
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                entServicio s = new entServicio();
                s.IdCliente = int.Parse(textBoxIdCliente.Text.Trim());
                s.Descripcion = textBoxDescripcion.Text.Trim();
                s.PrecioServicio = decimal.Parse(textBoxPrecioServicio.Text.Trim());
                s.estAtencionServicio = cbkestAtencionServicio.Checked;
                s.fecRegServicio = dtPickerRegServicio.Value;

                logServicio.Instancia.insertaServicio(s);
            }

            catch (Exception ex)

            {
                MessageBox.Show("Error" + ex);
            }

            groupBoxDatosServicio.Enabled = false;

            ListarServicio();
            limpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatosServicio.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entServicio s = new entServicio();
                s.NroServicio = int.Parse(textBoxNroServicio.Text.Trim());
                s.IdCliente = int.Parse(textBoxIdCliente.Text.Trim());
                s.Descripcion = textBoxDescripcion.Text.Trim();
                s.PrecioServicio = decimal.Parse(textBoxPrecioServicio.Text.Trim());
                s.estAtencionServicio = cbkestAtencionServicio.Checked;
                s.fecRegServicio = dtPickerRegServicio.Value;

                logServicio.Instancia.editaServicio(s);
            }

            catch (Exception ex)

            {
                MessageBox.Show("Error" + ex);

            }
            groupBoxDatosServicio.Enabled = false;

            ListarServicio();
            limpiarFormulario();
        }

        private void dgVServicio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow FilaActualMouse = dgVServicio.Rows[e.RowIndex];
            textBoxNroServicio.Text = FilaActualMouse.Cells[0].Value.ToString();
            textBoxIdCliente.Text = FilaActualMouse.Cells[1].Value.ToString();
            textBoxDescripcion.Text = FilaActualMouse.Cells[2].Value.ToString();
            textBoxPrecioServicio.Text = FilaActualMouse.Cells[3].Value.ToString();
            cbkestAtencionServicio.Checked = Convert.ToBoolean(FilaActualMouse.Cells[4].Value.ToString());
            dtPickerRegServicio.Text = FilaActualMouse.Cells[5].Value.ToString();
        }
        private void limpiarFormulario()
        {
            textBoxNroServicio.Clear();
            textBoxIdCliente.Clear();
            textBoxDescripcion.Clear();
            textBoxPrecioServicio.Clear();
            
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entServicio s = new entServicio();
                s.NroServicio= int.Parse(textBoxNroServicio.Text.Trim());
                cbkestAtencionServicio.Checked = false;
                s.estAtencionServicio= cbkestAtencionServicio.Checked;
                logServicio.Instancia.deshabilitaServicio(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            MessageBox.Show("Habitacion deshablitado correctamente");
            limpiarFormulario();
            groupBoxDatosServicio.Enabled = false;
            ListarServicio();
        }
    }
}
