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
    public partial class MantenedorCiudad : Form, CustomUserInterface
    {
        public MantenedorCiudad()
        {
            InitializeComponent();
            ListarCiudad();
            groupBoxDatosCiudad.Enabled = false;
            textBoxIdCiudad.Enabled = false;
            btnModificar.Enabled = false;
        }
        public void ListarCiudad()
        {
            dgVCiudad.DataSource = logCiudad.Instancia.ListarCiudad();
            setCustomColumHeader();
        }

        private void limpiarFormulario()
        {
            textBoxIdCiudad.Clear();
            textBoxCiudad.Clear();
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            groupBoxDatosCiudad.Enabled = true;
            limpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                groupBoxDatosCiudad.Enabled = true;
                btnModificar.Enabled = true;
            
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {

            try
                {
                    entCiudad c = new entCiudad();
                    c.IdCiudad = int.Parse(textBoxIdCiudad.Text.Trim());
                    checkBoxEstado.Checked = false;
                    c.EstadoCiudad = checkBoxEstado.Checked;
                    logCiudad.Instancia.deshabilitaCiudad(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                limpiarFormulario();
                groupBoxDatosCiudad.Enabled = false;
                ListarCiudad();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
                try
                {

                    entCiudad c = new entCiudad();

                    c.Ciudad = textBoxCiudad.Text.Trim();
                    c.EstadoCiudad = checkBoxEstado.Checked;
                    logCiudad.Instancia.insertaCiudad(c);
                }

                catch (Exception ex)

                {
                    MessageBox.Show("Error" + ex);
                }

                groupBoxDatosCiudad.Enabled = false;

                ListarCiudad();
                limpiarFormulario();
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
              try
                {
                    entCiudad c = new entCiudad();
                    c.IdCiudad = int.Parse(textBoxIdCiudad.Text.Trim());
                    c.Ciudad = textBoxCiudad.Text.Trim();
                    c.EstadoCiudad = checkBoxEstado.Checked;
                    logCiudad.Instancia.editaCiudad(c);
                }

                catch (Exception ex)

                {
                    MessageBox.Show("Error" + ex);

                }
                groupBoxDatosCiudad.Enabled = false;

                ListarCiudad();
                limpiarFormulario();
            

        }

        private void dgVCiudad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
                DataGridViewRow FilaActualMouse = dgVCiudad.Rows[e.RowIndex];
                textBoxIdCiudad.Text = FilaActualMouse.Cells[0].Value.ToString();
                textBoxCiudad.Text = FilaActualMouse.Cells[1].Value.ToString();
                checkBoxEstado.Checked = Convert.ToBoolean(FilaActualMouse.Cells[2].Value.ToString());
            
        }

        public void setCustomColumHeader()
        {
            dgVCiudad.Columns[0].HeaderText = "ID";
            dgVCiudad.Columns[1].HeaderText = "Ciudad";
            dgVCiudad.Columns[2].HeaderText = "Estado";
            dgVCiudad.Columns[3].HeaderText = "Creación";
            dgVCiudad.Columns[4].HeaderText = "Modificación";
        }
    }
}
