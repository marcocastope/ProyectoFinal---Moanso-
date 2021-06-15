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

        }

        private void mantPersonalBtn_Click(object sender, EventArgs e)
        {
            navigateToMantenedorPersonal(new FormPersonal());
        }


        private void navigateToMantenedorPersonal(object form)
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
            navigateToMantenedorPersonal(new FormServicio());
        }
    }
}
