using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocios;

namespace UI.Desktop
{
    public partial class Usuarios1 : Form
    {
        int habilitado = 0;
        bool Editar = false;
        private UsuariosCRUD usu = new UsuariosCRUD();

        private void limpiarForm() 
        {
            txtApellido.Clear();
            txtclave.Clear();
            
            txtEmail.Clear();
            txtNombre.Clear();
            txtnombreU.Clear();
            txtpersona.Clear();
            
        
        }


        public Usuarios1()
        {
            InitializeComponent();
        }

      private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {

               usu.addU( txtpersona.Text,   txtNombre.Text  ,txtnombreU.Text    ,txtApellido.Text   ,txtclave.Text  ,nueva.Checked ,habilitadoo.Checked ,txtEmail.Text);
             
                limpiarForm();
            }

        }

        private void btnmodificacion_Click(object sender, EventArgs e)
        {
         
            usu.EditarU(txtpersona.Text, txtNombre.Text, txtnombreU.Text, txtApellido.Text, txtclave.Text, nueva.Checked, habilitadoo.Checked, txtEmail.Text,txtid.Text);
        }
        
        private void btnModi_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            txtid.BackColor = SystemColors.Control;
        }

        private void txtpersona_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkahab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpersona_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
