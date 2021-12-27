using System;
using System.Windows.Forms;

namespace UI.Desktop2.Login
{
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
            Login l = new Login();
            l.Close();
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

        private void Profesores_Load(object sender, EventArgs e)
        {

        }

        private void btninscripcionAlumno_Click(object sender, EventArgs e)
        {
            Inscripciones_alumno ins = new Inscripciones_alumno();
            ins.Show();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materia m = new Materia();
            m.Show();
        }

        private void asasasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inscripcionDeAlumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void materiasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void planesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void especialidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cursos cur = new cursos();
            cur.ShowDialog();
        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modulos mod = new modulos();
            mod.ShowDialog();
        }

        private void inscripcionAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscripciones_alumno ins = new Inscripciones_alumno();
            ins.Show();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Plan_ pla = new _Plan_();
            pla.Show();
        }

        private void docentesCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Docentes_Cursos dc = new Docentes_Cursos();
            dc.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materia m = new Materia();
            m.Show();
        }
    }
}
