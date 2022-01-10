using CapaNegocios;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace UI.Desktop2.Login
{
    public partial class Suprer_Admins : Form
    {
        private object menu_ca;

        public Suprer_Admins()
        {
            InitializeComponent();
            Login l = new Login();
            l.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPersonas_Click(object sender, System.EventArgs e)
        {
            Personas p = new Personas();
            p.Show();
        }

        private void btnisncalu_Click(object sender, System.EventArgs e)
        {
            Inscripciones_alumno ia = new Inscripciones_alumno();
            ia.Show();
            this.Close();
        }

        private void btncomisiones_Click(object sender, System.EventArgs e)
        {
            comisiones com = new comisiones();
            com.Show();
        }

        private void btnCursos_Click(object sender, System.EventArgs e)
        {
            cursos cu = new cursos();
            cu.Show();
        }

        private void btnDocentesxcursos_Click(object sender, System.EventArgs e)
        {
            Docentes_Cursos dc = new Docentes_Cursos();
            dc.Show();
        }

        private void btnEspecialidades_Click(object sender, System.EventArgs e)
        {
            Especialidades esp = new Especialidades();
            esp.Show();
        }

        private void btnmaterias_Click(object sender, System.EventArgs e)
        {
            Materia m = new Materia();
            m.Show();
        }

        private void btnModulo_Click(object sender, System.EventArgs e)
        {
            modulos m = new modulos();
            m.Show();
        }

        private void btnmodulxusu_Click(object sender, System.EventArgs e)
        {
           
        }

        private void btnPlanes_Click(object sender, System.EventArgs e)
        {
            _Plan_ pl = new _Plan_();
            pl.Show();
        }

        private void btnUsuarios_Click(object sender, System.EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Show();
        }

        private void inscripcionDeAlumnosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Inscripciones_alumno ins = new Inscripciones_alumno();
            ins.Show();
        }

        private void comisionesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            comisiones com = new comisiones();
            com.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            cursos cur = new cursos();
            cur.ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Especialidades esp = new Especialidades();
            esp.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Materia M = new Materia();
            M.Show();
        }

        private void modulosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            modulos mod = new modulos();
            mod.ShowDialog();
        }

        private void personasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Personas P = new Personas();
            P.Show();
        }

        private void planesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _Plan_ pla = new _Plan_();
            pla.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Show();
        }

        private void docentesPorCursosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Docentes_Cursos dc = new Docentes_Cursos();
            dc.Show();
        }

        private void btncantidades_Click(object sender, System.EventArgs e)
        {
            ReporteDeCantidad rc = new ReporteDeCantidad();
            Menu_Admin ad = new Menu_Admin();
            rc.Menu_AdminsBindingSource.DataSource = ad.CantidadDeCursosEintegrantes();

            ReportDataSource rd = new ReportDataSource("cantidades",ad.CantidadDeCursosEintegrantes() );
            rc.reportViewer1.LocalReport.DataSources.Clear();
            rc.reportViewer1.LocalReport.DataSources.Add(rd);
            rc.reportViewer1.RefreshReport();
            rc.Show();
        }
    }
}
