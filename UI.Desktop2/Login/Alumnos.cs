using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace UI.Desktop2.Login
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos al = new Alumnos();
            al.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void btnmaterias_Click(object sender, EventArgs e)
        {
            Materia mat = new Materia();
            mat.ShowDialog();
        }

        private void btnmodulos_Click(object sender, EventArgs e)
        {
            modulos mod = new modulos();
            mod.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            _Plan_ pla = new _Plan_();
            pla.Show();
        }

        private void btnespecialidades_Click(object sender, EventArgs e)
        {
            Especialidades ESP = new Especialidades();
            ESP.ShowDialog();

        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            cursos cur = new cursos();
            cur.ShowDialog();
        }
    }
}
