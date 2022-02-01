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
        
        _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
        public inscripciones_alumno1()
        {
            InitializeComponent();

            this.cargacombo();
           
            
        }
        public int idalumno;
        public bool estado;
        public string ide;
        public int legajo;
        public bool activarmodis;


        
       
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
                
                if (estado == true)
                { 
                    if (idalumno != 0)
                    {
                       
                        int curso = ia.cargacombos().Item2[Combocurso.SelectedItem.ToString()];
                        bool x = ia.VerificarInscripcion(idalumno, curso);
                        if (x == false)
                        {
                            ia.agregar(idalumno.ToString(), curso.ToString(), " ", "-1");
                            MessageBox.Show("Inscripto!");
                        }
                        else 
                        {
                            MessageBox.Show("ya esta inscripto");

                        }
                        
                    }
                    else
                    {

                        if (Comboalumno.Text == "" || Combocurso.Text == "" || combocondicionalu.Text == "" || txtnota.Text == "")
                        { MessageBox.Show("Hay campos vacios , verifique su entrada"); }

                        int alumnoid = ia.cargacombos().Item1[Comboalumno.SelectedItem.ToString()];
                        int curso = ia.cargacombos().Item2[Combocurso.SelectedItem.ToString()];
                        //verificar que ya este inscripto
                        bool x = ia.VerificarInscripcion(alumnoid, curso);
                        if (x == false)
                        {
                            ia.agregar(alumnoid.ToString(), curso.ToString(), combocondicionalu.Text, txtnota.Text);


                            MessageBox.Show("Carga realizada!");
                        }
                        else { MessageBox.Show(" error en la Carga!"); }
                    }
                }
                if(estado == false) 
                {



                    string alumnoid;
                    string curso;

                    if (activarmodis != true)
                    {
                        if (txtauxalumno.Text == "" || txtauxcurso.Text == "" || combocondicionalu.Text == "" || txtnota.Text == "")
                        { MessageBox.Show("Hay campos vacios , verifique su entrada"); }
                       
                       

                        ia.modificar( txtauxalumno.Text , txtauxcurso.Text, combocondicionalu.Text, txtnota.Text, ide);
                        MessageBox.Show("Modificado!");
                        this.Close();
                    }
                    else 
                    {


                        if (Comboalumno.SelectedItem != null && Combocurso.SelectedItem != null)
                        {

                            if (Comboalumno.Text == "" || Combocurso.Text == "" || combocondicionalu.Text == "" || txtnota.Text == "")
                            { MessageBox.Show("Hay campos vacios , verifique su entrada"); }

                            alumnoid = ia.cargacombos().Item1[Comboalumno.SelectedItem.ToString()].ToString();
                            curso = ia.cargacombos().Item2[Combocurso.SelectedItem.ToString()].ToString();
                            ia.modificar(alumnoid, curso, combocondicionalu.Text, txtnota.Text, ide);
                            MessageBox.Show("Modificado!");
                            this.Close();
                        }
                        else 
                        {

                            if (txtauxalumno.Text == "" || /*combocursoaux.Text == "" ||*/ combocondicionalu.Text == "" || txtnota.Text == "")
                            { MessageBox.Show("Hay campos vacios , verifique su entrada"); }
                            alumnoid = txtauxalumno.Text;
                            string cursoAbuscar;
                            if (combocursoaux.SelectedItem == null) { curso = txtauxcurso.Text; } else { curso = ia.cargacombos().Item3[combocursoaux.SelectedItem.ToString()].ToString(); }
                           
                            ia.modificar(alumnoid, curso, combocondicionalu.Text, txtnota.Text, ide);
                            MessageBox.Show("Modificado!");
                            this.Close();
                        }


                        

                    }







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


            foreach (var k2 in ia.cargacombos().Item3.Keys)
            {
                combocursoaux.Items.Add(k2);
            }


        }

        private void Combocurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Comboalumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboAux_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtauxcurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void combocursoaux_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
