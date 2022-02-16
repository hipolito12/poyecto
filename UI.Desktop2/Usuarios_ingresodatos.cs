using CapaNegocios;
using System;
using System.Text.RegularExpressions;
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
            if (txtapelliod.Text !="" && txtclave.Text != "" && txtemail.Text != "" && txtnombre.Text != "" && txtusuario.Text != "" 
                &&  Regex.IsMatch(txtapelliod.Text, "[a-z]{5,20}") ==true 
                &&  Regex.IsMatch(txtnombre.Text, "[a-z]{3,20}") ==true
                && Regex.IsMatch(txtusuario.Text, "[a-z]{5,20}") == true
                && Regex.IsMatch(txtemail.Text, "[a-z]@[a-z]{8,40}") == true
              )



                
            {


                if (estado == true)
                {
                    try
                    {


                        Usuario_ u = new Usuario_();
                        // string ide = u.idpersona(txtnombre.Text);

                        u.agregegarUsuarios(ide, txtnombre.Text, txtusuario.Text, txtapelliod.Text, txtclave.Text, chkcambiaclave.Checked, chkhabilitado.Checked, txtemail.Text);
                        MessageBox.Show("Agregado!");
                        limpiarcampos();


                    }
                    catch (Exception ex) { MessageBox.Show("Ha ocurrido un error, verifique los campos y los datos"); }
                }

                if (estado == false)
                {
                    try
                    {
                        Usuario_ u = new Usuario_();

                        u.editUsuarios(idusuario, ide, txtnombre.Text, txtusuario.Text, txtapelliod.Text, txtclave.Text, chkcambiaclave.Checked, chkhabilitado.Checked, txtemail.Text);
                        MessageBox.Show("Modificado!");
                        limpiarcampos();
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show("Ha ocurrido un error, verifique los campos y los datos"); }
                }
                
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, verifique los campos  y el formato de estos");
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        void limpiarcampos() 
        {
            txtapelliod.Clear();
            txtclave.Clear();
            txtemail.Clear();
            txtnombre.Clear();
            txtusuario.Clear();
        }

    }


}

