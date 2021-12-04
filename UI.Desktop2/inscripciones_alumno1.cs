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
    public partial class inscripciones_alumno1 : Form
    {
        public bool estado;
        public string ide;
        _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
        public inscripciones_alumno1()
        {
            InitializeComponent();
            this.cargacombo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inscripciones_alumno1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Comboalumno.Text =="" || Combocurso.Text=="" || combocondicionalu.Text==""|| txtnota.Text=="") 
                { MessageBox.Show("Hay campos vacios , verifique su entrada");  }
                if (estado == true)
                {

                    int alumnoid = ia.cargacombos().Item1[Comboalumno.Text];
                    int curso = ia.cargacombos().Item2[Combocurso.Text];
                   
                    ia.agregar(alumnoid.ToString(),curso.ToString(),  combocondicionalu.Text, txtnota.Text);
                    
                }
                if(estado == false) 
                {
                   int alumnoid= ia.cargacombos().Item1[Comboalumno.Text];
                    int curso = ia.cargacombos().Item2[Combocurso.Text];
                    
                    ia.modificar(alumnoid.ToString(), curso.ToString(), combocondicionalu.Text, txtnota.Text, ide);
                    this.Close();
                }
            }
            catch(Exception ex) { MessageBox.Show("error " + ex); }
        }



        public void cargacombo()
        {
            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();

            foreach (var k in ia.cargacombos().Item1.Keys)
            {
                Comboalumno.Items.Add(k);
            }

            foreach (var k1 in ia.cargacombos().Item2.Keys) 
            {
                Combocurso.Items.Add(k1);
            }

        }
    }
}
