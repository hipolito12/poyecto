using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using capaNegocios;
using System.Data.SqlClient;
using System.Data;

namespace UI.Desktop
{
    public partial class Usuarios : Form
    {
        UsuariosCRUD u = new UsuariosCRUD();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Usuarios1 formul = new Usuarios1();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                formul.txtpersona.Text = dataGridView1.CurrentRow.Cells["id_persona"].Value.ToString();
                formul.txtApellido.Text = dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                formul.txtclave.Text = dataGridView1.CurrentRow.Cells["clave"].Value.ToString();
                formul.txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                formul.txtnombreU.Text = dataGridView1.CurrentRow.Cells["nombre_usuario"].Value.ToString();
                formul.txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                formul.txtid.Text = dataGridView1.CurrentRow.Cells["id_usuario"].Value.ToString();
                formul.Show();
            }
            else { MessageBox.Show("seleccione una fila"); }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void mostrarUsuarios()
        {
            UsuariosCRUD U = new UsuariosCRUD();
            dataGridView1.DataSource = U.muestra();


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Usuarios1 formul = new Usuarios1();
               string id= dataGridView1.CurrentRow.Cells["id_usuario"].Value.ToString();
                u.Eliminar(id);
                MessageBox.Show("Eliminado correctamente");
                mostrarUsuarios();
            }
            else { MessageBox.Show("seleccione una fila por favor"); }
        }
                

    

        private void btneditar_Click(object sender, EventArgs e)
        {
            Usuarios1 formul = new Usuarios1();
            formul.Show();
            mostrarUsuarios();


        }
    }
}

