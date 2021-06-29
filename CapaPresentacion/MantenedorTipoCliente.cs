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
    public partial class MantenedorTipoCliente : Form
    {
        public MantenedorTipoCliente()
        {
            InitializeComponent();
            ListarTipoCliente();
            groupBoxDatos.Enabled = false;
            textBoxIdTipoCliente.Enabled = false;
            btnModificar.Enabled = false;
        }
        public void ListarTipoCliente()
        {
            dgVTipoCliente.DataSource = logTipoCliente.Instancia.ListarTipoCliente();
        }

        private void limpiarFormulario()
        {
            textBoxIdTipoCliente.Clear();
            textBoxTipoCliente.Clear();
            textBoxDescripcionTipoCliente.Clear();
        }

       
        private void MantenedorTipoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

                btnAgregar.Enabled = true;
                groupBoxDatos.Enabled = true;
                limpiarFormulario();
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

                groupBoxDatos.Enabled = true;
                btnModificar.Enabled = true;
           
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
                {
                    entTipoCliente t = new entTipoCliente();
                    t.IdTipoCliente = int.Parse(textBoxIdTipoCliente.Text.Trim());
                    checkBoxEstadoTipoCliente.Checked = false;
                    t.EstadoTipoCliente = checkBoxEstadoTipoCliente.Checked;
                    logTipoCliente.Instancia.deshabilitaTipoCliente(t);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                limpiarFormulario();
                groupBoxDatos.Enabled = false;
                ListarTipoCliente();
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             try
                {

                    entTipoCliente t = new entTipoCliente();

                    t.TipoCliente = textBoxTipoCliente.Text.Trim();
                    t.DescripcionTipoCliente = textBoxDescripcionTipoCliente.Text.Trim();
                    t.EstadoTipoCliente = checkBoxEstadoTipoCliente.Checked;

                    logTipoCliente.Instancia.insertaTipoCliente(t);
                }

                catch (Exception ex)

                {
                    MessageBox.Show("Error" + ex);
                }

                groupBoxDatos.Enabled = false;

                ListarTipoCliente();
                limpiarFormulario();
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

                try
                {
                    entTipoCliente t = new entTipoCliente();
                    t.IdTipoCliente = int.Parse(textBoxIdTipoCliente.Text.Trim());
                    t.TipoCliente = textBoxTipoCliente.Text.Trim();
                    t.DescripcionTipoCliente = textBoxDescripcionTipoCliente.Text.Trim();
                    t.EstadoTipoCliente = checkBoxEstadoTipoCliente.Checked;

                    logTipoCliente.Instancia.editaTipoCliente(t);
                }

                catch (Exception ex)

                {
                    MessageBox.Show("Error" + ex);

                }
                groupBoxDatos.Enabled = false;

                ListarTipoCliente();
                limpiarFormulario();
            

        }

        private void dgVTipoCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
               DataGridViewRow FilaActualMouse = dgVTipoCliente.Rows[e.RowIndex];
                textBoxIdTipoCliente.Text = FilaActualMouse.Cells[0].Value.ToString();
                textBoxTipoCliente.Text = FilaActualMouse.Cells[1].Value.ToString();
                textBoxDescripcionTipoCliente.Text = FilaActualMouse.Cells[2].Value.ToString();
                checkBoxEstadoTipoCliente.Checked = Convert.ToBoolean(FilaActualMouse.Cells[3].Value.ToString());
            
        }
    }
}
