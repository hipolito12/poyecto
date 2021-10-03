﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;
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
            else 
            { MessageBox.Show("error en la  contrasena"); 
                txtContrasena.Clear();
                txtusuarios.Clear();


            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            (string,int) tup;
            tup.Item2 = 0;
            tup.Item1 = " ";
            Login_ lg = new Login_();
            try
            {
               tup = lg.FindRoles(txtusuarios.Text, txtContrasena.Text);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("contraseña o usuario incorrectos:   ",ex.ToString());
                txtContrasena.Clear();
                txtusuarios.Clear();
            }

            switch (tup.Item2) 
            {
                case 0:  Suprer_Admins sa = new Suprer_Admins(); sa.ShowDialog(); sa.richTextBox1.Text = $"Bienvenido {tup.Item1}";    break;
                case 1:  Profesores p = new Profesores(); p.ShowDialog();   p.richTextBox1.Text = $"Bienvenido {tup.Item1}";   break;
                case 2: Alumnos al = new Alumnos(); al.ShowDialog(); al.texto.Text = $"Bienvenido {tup.Item1}"; break;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
