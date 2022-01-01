using CapaNegocios;
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
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }



        private void inscripcionDeAlumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inscripciones_alumno ins = new Inscripciones_alumno();
            ins.Show();
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

            MessageBox.Show(algo.ToString());


            NotasAlumnos na = new NotasAlumnos();
            Notas n = new Notas();
            foreach (var k in n.fechasyparacombo(15)) 
            { 
            na.comboBox1.Items.Add(k.anio);
            }
            na.idpersonacp = algo;
            na.Show();
        }

        
    }
}
