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
                string id = dataGridView1.CurrentRow.Cells["idusuario"].Value.ToString();
                u_.eliminarUsuarios(id);
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }
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
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Usuarios_ingresodatos ui = new Usuarios_ingresodatos();
            ui.idusuario = dataGridView1.CurrentRow.Cells["idusuario"].Value.ToString();
            ui.estado = false;
            ui.txtapelliod.Text = dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
            ui.txtclave.Text = dataGridView1.CurrentRow.Cells["clave"].Value.ToString();
            ui.txtemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            ui.txtnombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            ui.txtusuario.Text = dataGridView1.CurrentRow.Cells["nombreU"].Value.ToString();
            ui.txtid.Text = dataGridView1.CurrentRow.Cells["idpersonas"].Value.ToString();
            ui.id = dataGridView1.CurrentRow.Cells["idpersonas"].Value.ToString();
            ui.ShowDialog();

        }
    }
}
