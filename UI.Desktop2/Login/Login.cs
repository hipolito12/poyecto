using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop2.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuarios_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtusuarios.Text.Length > 8 && txtusuarios.Text != null)
            {

            }
            else { MessageBox.Show("error en el usuario"); }

           
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Length > 8 && txtContrasena.Text!= null)
            {
                
            }
            else { MessageBox.Show("error en la  contrasena"); }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
