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
        }

        public void ListarCliente()
        {
            dgVCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {

                entCliente c = new entCliente();
                c.dniCliente = int.Parse(textBoxDniCliente.Text.Trim());
                c.nombreCliente = textBoxNombreCliente.Text.Trim();
                c.apellidoCliente = textBoxApellidoCliente.Text.Trim();
                c.emailCliente = textBoxEmailCliente.Text.Trim();
                c.telefonoCliente = textBoxTelefono.Text.Trim();
                c.fecRegCliente = dtPickerRegCliente.Value;

                logCliente.Instancia.insertaCliente(c);



            }

            catch (Exception ex)

            {

                MessageBox.Show("Error" + ex);



            }

            groupBoxDatosCliente.Enabled = false;

            ListarCliente();
        }

        

        private void dgVCliente_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow FilaActualMouseCliente = dgVCliente.Rows[e.RowIndex];
            textBoxIdCliente.Text= FilaActualMouseCliente.Cells[0].Value.ToString();
            textBoxDniCliente.Text= FilaActualMouseCliente.Cells[1].Value.ToString();
            textBoxNombreCliente.Text = FilaActualMouseCliente.Cells[2].Value.ToString();
            textBoxApellidoCliente.Text = FilaActualMouseCliente.Cells[3].Value.ToString();
            textBoxEmailCliente.Text = FilaActualMouseCliente.Cells[4].Value.ToString();
            textBoxTelefono.Text = FilaActualMouseCliente.Cells[5].Value.ToString();
            dtPickerRegCliente.Text= FilaActualMouseCliente.Cells[6].Value.ToString();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                groupBoxDatosCliente.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
                try
                {
                    entCliente c = new entCliente();
                    c.idCliente = int.Parse(textBoxIdCliente.Text.Trim());
                    c.dniCliente = int.Parse(textBoxDniCliente.Text.Trim());
                    c.nombreCliente = textBoxNombreCliente.Text.Trim();
                    c.apellidoCliente = textBoxApellidoCliente.Text.Trim();
                    c.emailCliente = textBoxEmailCliente.Text.Trim();
                    c.telefonoCliente = textBoxTelefono.Text.Trim();
                    c.fecRegCliente = dtPickerRegCliente.Value;

                    logCliente.Instancia.editaCliente(c);
                }

                catch (Exception ex)

                {
                    MessageBox.Show("Error" + ex);

                }

                groupBoxDatosCliente.Enabled = false;

                ListarCliente();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            groupBoxDatosCliente.Enabled = true;

        }
    }
}

