using System;
using System.Windows.Forms;

namespace UI.Desktop2.Login
{
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void btncursos_Click(object sender, EventArgs e)
        {
            cursos cur = new cursos();
            cur.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            _Plan_ pla = new _Plan_();
            pla.Show();
        }

        private void btndocentescursos_Click(object sender, EventArgs e)
        {
            Docentes_Cursos dc = new Docentes_Cursos();
            dc.ShowDialog();
        }

        private void btnModuos_Click(object sender, EventArgs e)
        {
            modulos mod = new modulos();
            mod.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesores p = new Profesores();
            p.Close();
        }
    }
}
