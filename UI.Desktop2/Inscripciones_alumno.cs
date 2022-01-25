using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;


namespace UI.Desktop2
{
    public partial class Inscripciones_alumno : Form
    {
        _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
        public Inscripciones_alumno()
        {
            InitializeComponent();
            dataGridView1.DataSource = ia.Listar();
            combocurso.Visible = false;
            lblCurso.Visible = false;
            btnaceptar.Visible = false;
            combocurso.Refresh();
        }

        private void Inscripciones_alumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.alumnos_inscripciones' Puede moverla o quitarla según sea necesario.
            this.alumnos_inscripcionesTableAdapter.Fill(this.tp2DataSet.alumnos_inscripciones);

        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ia.Listar();


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
            string ide = dataGridView1.CurrentRow.Cells["id_inscripcion"].Value.ToString();
            ia.eliminar(ide);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            inscripciones_alumno1 ia1 = new inscripciones_alumno1();

            ia1.ide = dataGridView1.CurrentRow.Cells["id_inscripcion"].Value.ToString();
            ia1.txtnota.Text = dataGridView1.CurrentRow.Cells["nota"].Value.ToString();
            ia1.combocondicionalu.Text = dataGridView1.CurrentRow.Cells["condicion"].Value.ToString();
            //ia1.Comboalumno.Text= dataGridView1.CurrentRow.Cells["alumno"].Value.ToString();

            ia1.estado = false;
            ia1.Show();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            inscripciones_alumno1 ia1 = new inscripciones_alumno1();
            ia1.estado = true;
            ia1.Show();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Menu_profesores mp = new Menu_profesores();
            dataGridView1.DataSource =  ia.Listar();
            int idC =  Convert.ToInt32( combocurso.SelectedItem.ToString() ) ;
           dataGridView1.DataSource =  mp.filtrar(idC);
        }
    }
}
