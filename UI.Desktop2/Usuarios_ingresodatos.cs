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
using UI.Desktop2.database;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (estado == true) 
            {
               

                Usuario_ u = new Usuario_();
              //  string ide = u.idpersona(txtnombre.Text,);
              
                u.agregegarUsuarios(ide,txtnombre.Text,txtusuario.Text,txtapelliod.Text,txtclave.Text,chkcambiaclave.Checked,chkhabilitado.Checked,txtemail.Text);
            }
           
            if (estado == false) 
            {
                
                Usuario_ u = new Usuario_();
               
                u.editUsuarios( idusuario,id, txtnombre.Text, txtusuario.Text, txtapelliod.Text, txtclave.Text, chkcambiaclave.Checked, chkhabilitado.Checked, txtemail.Text);
            }
        }


           
       
        
        
    }


}

