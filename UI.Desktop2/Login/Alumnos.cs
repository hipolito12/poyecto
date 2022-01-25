using CapaNegocios;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using CapaNegocios;
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
            
            inscripciones_alumno1 ins1 = new inscripciones_alumno1();
            ins1.lblestado.Visible = false;
            ins1.lblnota.Visible = false;
            ins1.txtnota.Text = "0";
            ins1.estado = true;
            ins1.combocondicionalu.Text = "   ";
            ins1.txtnota.Visible = false;
            ins1.lblalumno.Text ="Legajo de alumno";
            ins1.combocondicionalu.Visible = false;
            ins1.btnAceptar.Text = "Inscribirse";
            ins1.Show();

        }

        private void btnmaterias_Click(object sender, EventArgs e)
        {
            MateriasInforme mi = new MateriasInforme();
            mi.Show();
            
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
            //Listar Cursos
            cursos c = new cursos();
            c.btnagregar.Visible = false;
            c.btnModificar.Visible = false;
            c.btnRefresh.Visible = false;
            c.btbElimina.Visible = false;
            CursosCRUD cc = new CursosCRUD();
            c.dataGridView1.DataSource = cc.cargarcamposCursos();
            c.dataGridView1.Columns[1].Visible = false;
            c.ShowDialog();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }



        private void inscripcionDeAlumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            inscripciones_alumno1 ins1 = new inscripciones_alumno1();
            ins1.lblestado.Visible = false;
            ins1.lblnota.Visible = false;
            ins1.txtnota.Text = "0";
            ins1.estado = true;
            ins1.combocondicionalu.Text = "   ";
            ins1.txtnota.Visible = false;
            ins1.lblalumno.Text = "Legajo de alumno";
            ins1.combocondicionalu.Visible = false;
            ins1.btnAceptar.Text = "Inscribirse";
            ins1.Show();
        }

        private void materiasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Materia mat = new Materia();
            mat.ShowDialog();
        }

        private void modulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Listar Materias
        }

        private void planesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _Plan_ pla = new _Plan_();
            pla.Show();
        }

        private void especialidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Especialidades ESP = new Especialidades();
            ESP.ShowDialog();
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cursos cur = new cursos();
            cur.ShowDialog();
        }


        public int algo;
        private void button1_Click(object sender, EventArgs e)
        {

            NotasAlumnos na = new NotasAlumnos();
            Notas n = new Notas();
            foreach (var k in n.fechasyparacombo(algo)) 
            { 
            na.comboBox1.Items.Add(k.ItemArray[0]);
            }
            na.idpersonacp = algo;
            na.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Notas mp = new Notas();
                DocentesXcursosreporte dxc = new DocentesXcursosreporte();
                dxc.Menu_profesoressBindingSource.DataSource = mp.cargarInformeDocentesXcurso();

                ReportDataSource rd = new ReportDataSource("DocentesXCursos", mp.cargarInformeDocentesXcurso());
                dxc.reportViewer1.LocalReport.DataSources.Clear();
                dxc.reportViewer1.LocalReport.DataSources.Add(rd);
                dxc.reportViewer1.RefreshReport();
                dxc.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cambiar_contraseña cc = new Cambiar_contraseña();
            cc.id = algo;
            cc.Show();

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(algo.ToString());


            NotasAlumnos na = new NotasAlumnos();
            Notas n = new Notas();
            foreach (var k in n.fechasyparacombo(algo))
            {
                na.comboBox1.Items.Add(k.ItemArray[0]);
            }
            na.idpersonacp = algo;
            na.Show();
        }

        private void docentesDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Notas mp = new Notas();
                DocentesXcursosreporte dxc = new DocentesXcursosreporte();
                dxc.Menu_profesoressBindingSource.DataSource = mp.cargarInformeDocentesXcurso();

                ReportDataSource rd = new ReportDataSource("DocentesXCursos", mp.cargarInformeDocentesXcurso());
                dxc.reportViewer1.LocalReport.DataSources.Clear();
                dxc.reportViewer1.LocalReport.DataSources.Add(rd);
                dxc.reportViewer1.RefreshReport();
                dxc.Show();
            }
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MateriasInforme mi = new MateriasInforme();
            mi.Show();
        }
    }
}
