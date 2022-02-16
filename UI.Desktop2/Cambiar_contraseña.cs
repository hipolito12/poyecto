using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                if (
                    txtactual.Text != "" && txtconfirmar.Text != "" && txtnueva.Text != ""
                    && txtconfirmar.Text == txtnueva.Text && txtconfirmar.Text.Length >= 8
                    && txtnueva.Text.Length >= 8 && Regex.IsMatch(txtactual.Text, "[A-Z,a-z,0-9]{1,8}") == true
                    && Regex.IsMatch(txtconfirmar.Text, "[A-Z,a-z,0-9]{1,8}") == true
                    && Regex.IsMatch(txtnueva.Text, "[A-Z,a-z,0-9]{1,8}") == true
                    )
                {
                    Notas n = new Notas();
                    bool result = n.verifyActualPass(id, txtactual.Text);

                    if (result == true)
                    {
                        n.cambiarContrasena(id, txtnueva.Text);
                        MessageBox.Show("Modificada!");
                    }
                    else { MessageBox.Show("contraseña actual invalida "); }
                }
                else { MessageBox.Show("hay  un error , verifique su entrada"); }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error, intentelo nuevamente!");
            }

        }
    }
}
