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
    public partial class MantenedorPrenda : Form
    {
        public MantenedorPrenda()
        {
            InitializeComponent();
            ListarPrenda();
            btnAgregar.Enabled = false;
            groupBoxDatosPrendas.Enabled = false;
            textBoxNroPrenda.Enabled = false;
        }
        public void ListarPrenda()
        {
            dgVPrenda.DataSource = logPrenda.Instancia.ListarPrenda();
        }
       
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            groupBoxDatosPrendas.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                entPrenda p = new entPrenda();
                p.idCliente = int.Parse(textBoxIdCliente.Text.Trim());
                p.tipoPrenda = textBoxTipoPrenda.Text.Trim();
                p.estadoPrenda = textBoxEstadoPrenda.Text.Trim();
                p.colorPrenda = textBoxColorPrenda.Text.Trim();
                p.fecRegPrenda = dtPickerRegPrenda.Value;
                p.estAtencion = cbkEstadoAtencion.Checked;
                logPrenda.Instancia.insertaPrenda(p);
            }

            catch (Exception ex)

            {
                MessageBox.Show("Error" + ex);
            }

            groupBoxDatosPrendas.Enabled = false;

            ListarPrenda();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatosPrendas.Enabled = true;
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entPrenda p = new entPrenda();
                p.nroPrenda = int.Parse(textBoxNroPrenda.Text.Trim());
                p.idCliente = int.Parse(textBoxIdCliente.Text.Trim());
                p.tipoPrenda = textBoxTipoPrenda.Text.Trim();
                p.estadoPrenda = textBoxEstadoPrenda.Text.Trim();
                p.colorPrenda = textBoxColorPrenda.Text.Trim();
                p.fecRegPrenda = dtPickerRegPrenda.Value;
                p.estAtencion = cbkEstadoAtencion.Checked;

                logPrenda.Instancia.editaPrenda(p);
            }

            catch (Exception ex)

            {
                MessageBox.Show("Error" + ex);

            }
            groupBoxDatosPrendas.Enabled = false;

            ListarPrenda();
        }

        private void dgVPrenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow FilaActualMouse = dgVPrenda.Rows[e.RowIndex];
            textBoxNroPrenda.Text = FilaActualMouse.Cells[0].Value.ToString();
            textBoxIdCliente.Text = FilaActualMouse.Cells[1].Value.ToString();
            textBoxTipoPrenda.Text = FilaActualMouse.Cells[2].Value.ToString();
            textBoxEstadoPrenda.Text=FilaActualMouse.Cells[3].Value.ToString();
            textBoxColorPrenda.Text = FilaActualMouse.Cells[4].Value.ToString();
            dtPickerRegPrenda.Text = FilaActualMouse.Cells[5].Value.ToString();
            cbkEstadoAtencion.Checked = Convert.ToBoolean(FilaActualMouse.Cells[6].Value.ToString());

        }
    }
}
