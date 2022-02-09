using CapaNegocios;
using System;
using System.Windows.Forms;
namespace UI.Desktop2
{
    public partial class Usuarios_ingresodatos : Form
    {
        public bool estado;
        public string idusuario;
        public string id;


        public Usuarios_ingresodatos()
        {
            InitializeComponent();

        }

        private void chkhabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Usuarios_ingresodatos_Load(object sender, EventArgs e)
        {

        } 
        public string ide;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           

            if (estado == true)
            { 
                try
                {


                    Usuario_ u = new Usuario_();
                    // string ide = u.idpersona(txtnombre.Text);
                   
                    u.agregegarUsuarios(ide, txtnombre.Text, txtusuario.Text, txtapelliod.Text, txtclave.Text, chkcambiaclave.Checked, chkhabilitado.Checked, txtemail.Text);
                    MessageBox.Show("Agregado!");
                    this.Close();

                }
                catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }
            }

            if (estado == false)
            {
                try
                {
                    Usuario_ u = new Usuario_();

                    u.editUsuarios(idusuario, ide, txtnombre.Text, txtusuario.Text, txtapelliod.Text, txtclave.Text, chkcambiaclave.Checked, chkhabilitado.Checked, txtemail.Text);
                    MessageBox.Show("Modificado!");
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

