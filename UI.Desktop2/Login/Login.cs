using CapaNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace UI.Desktop2.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
         }

        public int idaux ;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuarios_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtusuarios.Text.Length >= 8 && txtusuarios.Text != "")
            {

            }
            else { MessageBox.Show("error en el usuario"); }

            if (txtContrasena.Text.Length >= 8 && txtContrasena.Text != null)
            {

            }
            else
            {
                MessageBox.Show("error en la  contrasena");
                txtContrasena.Clear();
                txtusuarios.Clear();


            }
            (string, int,int) tup;
            tup.Item2 = -1;
            tup.Item1 = " ";
            tup.Item3 = -1;
            
            Login_ lg = new Login_();
            try
            {
                tup = lg.FindRoles(txtusuarios.Text, txtContrasena.Text);
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("contraseña o usuario incorrectos:   ", ex.ToString());
                txtContrasena.Clear();
                txtusuarios.Clear();
            }

            idaux = tup.Item3;
            switch (tup.Item2)
            {
                
                case 0:    Suprer_Admins sa = new Suprer_Admins(); sa.richTextBox1.Text = $"               Bienvenido {tup.Item1}"; sa.richTextBox1.ReadOnly = true; sa.ShowDialog(); break;
                case 1: Profesores p = new Profesores(); p.richTextBox1.Text = $"               Bienvenido {tup.Item1}"; p.richTextBox1.ReadOnly = true; p.ShowDialog(); break;
                case 2: Alumnos a = new Alumnos(); a.algo = tup.Item3; ;  a.texto.Text = $"               Bienvenido {tup.Item1}"; a.texto.ReadOnly = true; a.ShowDialog()  ; break;
            }


        }
        
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
