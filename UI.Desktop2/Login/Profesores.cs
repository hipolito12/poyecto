using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.SqlServer.Types;
using System.Data.SqlClient;
using CapaNegocios;

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

        

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            _Plan_ pla = new _Plan_();
            pla.Show();
        }

        private void btndocentescursos_Click(object sender, EventArgs e)
        {
            Inscripciones_alumno ai = new Inscripciones_alumno();
            Menu_profesores mp = new Menu_profesores();
            foreach (var k in mp.comboidcurso()) 
            {
                ai.combocurso.Items.Add(k);
            }
            ai.combocurso.Visible = true;
            ai.btnaceptar.Visible = true;
            ai.btneliminar.Visible = false;
            ai.btnagregar.Visible = false;
            ai.lblCurso.Visible = true;
            ai.Show();
          
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

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteAlumnosxComisiones r = new ReporteAlumnosxComisiones();

            Menu_profesores m = new Menu_profesores();

            r.Menu_profesoressBindingSource.DataSource = m.cargarReporte();

            ReportDataSource rd = new ReportDataSource("AlumnosCurso", m.cargarReporte());
            r.reportViewer2.LocalReport.DataSources.Clear();
            r.reportViewer2.LocalReport.DataSources.Add(rd);
            r.reportViewer2.RefreshReport();
            r.Show();
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            comisiones c = new comisiones();
            c.btnaceptar.Visible = false;
            c.btneliminar.Visible = false;
            c.btnmodificar.Visible = false;
            c.Show();
            
        }

        private void btncursos_Click(object sender, EventArgs e)
        {
            {
                Menu_profesores mp = new Menu_profesores();
                DocentesXcursosreporte dxc = new DocentesXcursosreporte();
                dxc.Menu_profesoressBindingSource.DataSource = mp.cargarInformeDocentesXcurso();

                ReportDataSource rd = new ReportDataSource("DocentesXCursos", mp.cargarInformeDocentesXcurso());
                dxc.reportViewer1.LocalReport.DataSources.Clear();
                dxc.reportViewer1.LocalReport.DataSources.Add(rd);
                dxc.reportViewer1.RefreshReport();
                dxc.Show();
            }
        }

    }
}
