using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace UI.Desktop2
{
    public partial class Cambiar_contraseña : Form
    {
        public Cambiar_contraseña()
        {
            InitializeComponent();
        }

        public int id;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtactual.Text == null || txtconfirmar.Text == null || txtnueva.Text == null || txtconfirmar.Text != txtnueva.Text || txtconfirmar.Text.Length < 8 || txtnueva.Text.Length < 8)
                {
                    MessageBox.Show("hay  un error , verifique su entrada");
                }
                Notas n = new Notas();
                bool result = n.verifyActualPass(id, txtactual.Text);

                if (result == true)
                {
                    n.cambiarContrasena(id, txtnueva.Text);
                    MessageBox.Show("Modificada!");
                }
                else { MessageBox.Show("contraseña actual invalida "); }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error, intentelo nuevamente!");
            }

        }
    }
}
