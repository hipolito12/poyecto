using CapaNegocios;
using System;
using System.Windows.Forms;
using CapaNegocios;
namespace UI.Desktop2
{
    public partial class Usuarios : Form
    {
        Usuario_ us = new Usuario_();
        
        public Usuarios()
        {
            InitializeComponent();
            dataGridView1.DataSource = us.listar();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.tp2DataSet.usuarios);

        }

        private void btnbaja_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario_ u_ = new Usuario_();
                string id = dataGridView1.CurrentRow.Cells["id_usuario"].Value.ToString();
                u_.eliminarUsuarios(id);
                MessageBox.Show("eliminado!");
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error, verifique los campos y los datos"); }
        }

        private void btnRefressh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = " ";
            Usuario_ usu = new Usuario_();
            //this.usuariosTableAdapter.Fill(this.tp2DataSet.usuarios);
            dataGridView1.DataSource = usu.listar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Usuarios_ingresodatos ui = new Usuarios_ingresodatos();
            ui.estado = true;
            ui.ide = dataGridView1.CurrentRow.Cells["id_persona"].Value.ToString();
            ui.ShowDialog();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Usuarios_ingresodatos ui = new Usuarios_ingresodatos();
            ui.idusuario = dataGridView1.CurrentRow.Cells["id_usuario"].Value.ToString();
            ui.estado = false;
            ui.txtapelliod.Text = dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
            ui.txtclave.Text = dataGridView1.CurrentRow.Cells["clave"].Value.ToString();
            ui.txtemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            ui.txtnombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            ui.txtusuario.Text = dataGridView1.CurrentRow.Cells["nombre_usuario"].Value.ToString();
            ui.ide = dataGridView1.CurrentRow.Cells["id_persona"].Value.ToString();
            ui.id = dataGridView1.CurrentRow.Cells["id_persona"].Value.ToString();
            ui.ShowDialog();

        }
    }
}
