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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void mantenedorClienteBtn_Click(object sender, EventArgs e)
        {
            navigateToMantenedor(new MantenedorCliente());
        }

        private void mantPersonalBtn_Click(object sender, EventArgs e)
        {
            navigateToMantenedor(new MantenedorTipoHabitacion());
        }


        private void navigateToMantenedor(object form)
        {
            if(this.containerForm.Controls.Count > 0)
            {
                this.containerForm.Controls.RemoveAt(0);
            }
            Form fm = form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.containerForm.Controls.Add(fm);
            this.containerForm.Tag = fm;
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navigateToMantenedor(new MantenedorServicio());
        }

        private void mantTipoHabitacionBtn_Click(object sender, EventArgs e)
        {
            navigateToMantenedor(new MantenedorTipoHabitacion());
        }

        private void mantHabitacionBtn_Click(object sender, EventArgs e)
        {
            navigateToMantenedor(new MantenedorHabitacion());
        }

        private void btnTipoCliente_Click(object sender, EventArgs e)
        {
            navigateToMantenedor(new MantenedorTipoCliente());
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            navigateToMantenedor(new MantenedorCiudad());
        }
    }
}
