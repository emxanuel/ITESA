using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace Capas
{
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        NegocioEmpleados negocio = new NegocioEmpleados();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if(negocio.loginEmpleados(tbUsuario.Text, tbContrasena.Text) == 1)
            {
                FormOrden form = new FormOrden();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        private void tbContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                if (negocio.loginEmpleados(tbUsuario.Text, tbContrasena.Text) == 1)
                {
                    FormOrden form = new FormOrden();
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
        }
    }
}
