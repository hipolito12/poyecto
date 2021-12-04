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
        public Inscripciones_alumno()
        {
            InitializeComponent();
        }

        private void Inscripciones_alumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.alumnos_inscripciones' Puede moverla o quitarla según sea necesario.
            this.alumnos_inscripcionesTableAdapter.Fill(this.tp2DataSet.alumnos_inscripciones);

        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            this.alumnos_inscripcionesTableAdapter.Fill(this.tp2DataSet.alumnos_inscripciones);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
            string ide = dataGridView1.CurrentRow.Cells["inscripcion"].Value.ToString();
            ia.eliminar(ide);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            inscripciones_alumno1 ia1 = new inscripciones_alumno1();

            ia1.ide = dataGridView1.CurrentRow.Cells["inscripcion"].Value.ToString();
            ia1.txtnota.Text = dataGridView1.CurrentRow.Cells["nota"].Value.ToString();
            ia1.combocondicionalu.Text = dataGridView1.CurrentRow.Cells["condicion"].Value.ToString();
            ia1.estado = false;
            ia1.Show();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            inscripciones_alumno1 ia1 = new inscripciones_alumno1();
            ia1.estado = true;
            ia1.Show();
        }




       
    
    }
}
