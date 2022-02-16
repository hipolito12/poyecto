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
                       
                        int curso = ia.cargadorDeCombos()[Combocurso.SelectedItem.ToString()];
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

                        if (true==true)
                        {
                            int alumnoid = ia.cargacombos().Item1[Comboalumno.SelectedItem.ToString()];
                            int curso = ia.cargadorDeCombos()[Combocurso.SelectedItem.ToString()];
                            //verificar que ya este inscripto
                            bool x = ia.VerificarInscripcion(alumnoid, curso);
                            if (x == false)
                            {
                                ia.agregar(alumnoid.ToString(), curso.ToString(), " ","-1");


                                MessageBox.Show("Carga realizada!");
                            }
                            else { MessageBox.Show(" error en la Carga!"); }
                        }
                       

                       
                    }
                }
                if(estado == false) 
                {



                    string alumnoid;
                    string curso;

                    if (activarmodis != true)
                    {
                        if (Comboalumno.Text != "" && Combocurso.Text != ""  && txtnota.Text != "")
                        {
                            if (validador(combocondicion.SelectedItem.ToString(), Convert.ToInt32(txtnota.Text)) == true) 
                            {
                                ia.modificar( txtauxalumno.Text , txtauxcurso.Text, combocondicion.SelectedItem.ToString(), txtnota.Text, ide);
                                MessageBox.Show("Modificado!");
                                this.Close();

                            }
                               
                        }
                        else {MessageBox.Show("Hay campos vacios , verifique su entrada"); }
                       
                       

                        
                    }
                    else 
                    {


                        if (Comboalumno.SelectedItem != null && Combocurso.SelectedItem != null)
                        {

                            if (Comboalumno.Text != "" && Combocurso.Text != "" && txtnota.Text != "")
                            {
                                if (validador(combocondicion.SelectedItem.ToString(), Convert.ToInt32(txtnota.Text)) == true)
                                {
                                    alumnoid = ia.cargacombos().Item1[Comboalumno.SelectedItem.ToString()].ToString();
                                    curso = ia.cargadorDeCombos()[Combocurso.SelectedItem.ToString()].ToString();
                                    ia.modificar(alumnoid, curso, combocondicion.SelectedItem.ToString(), txtnota.Text, ide);
                                    MessageBox.Show("Modificado!");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hay campos vacios , verifique su entrada");

                            }

                           
                        }
                        else 
                        {

                            if (txtauxalumno.Text != "" && /*combocursoaux.Text == "" ||*/   txtnota.Text != "")
                            {
                               alumnoid = txtauxalumno.Text;
                            string cursoAbuscar;
                            if (combocursoaux.SelectedItem == null) { curso = txtauxcurso.Text; } else { curso = ia.cargadorDeComboscursosdelAno()[combocursoaux.SelectedItem.ToString()].ToString() ; }
                           
                            ia.modificar(alumnoid, curso, combocondicion.SelectedItem.ToString(), txtnota.Text, ide);
                            MessageBox.Show("Modificado!");
                            this.Close();
                            }
                            else {  MessageBox.Show("Hay campos vacios , verifique su entrada");}
                            
                        }


                        

                    }







                }
            }
            catch(Exception ex) { MessageBox.Show("Ha ocurrido un error, verifique los campos y los datos"); }
        }



        public void cargacombo()
        {
            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();

             
            

                foreach (var k in ia.cargacombos().Item1.Keys)
                {
                    Comboalumno.Items.Add(k);
                }
           
                foreach (var k1 in ia.cargadorDeCombos().Keys)
                {
                    Combocurso.Items.Add(k1);
                }

            foreach (var k2 in ia.cargadorDeComboscursosdelAno().Keys) 
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

      bool validador( string estado , int nota ) 
        {
            switch (estado) 
            {

                case "Aprobado": if (nota >= 6 && nota <= 10) { return true; } else { MessageBox.Show("para un aprobado la nota tiene que ser mayor a 6 y menor a 10" ); return false; }      break;

                case "Libre": if (nota >= 0 && nota < 6) { return true; } else { MessageBox.Show("para un Libre la nota tiene que ser mayor a 0 y menor a 6"); return false; } break;

                case "Aprobacion directa":
                    if (nota >= 7 && nota <= 10) { return true; } else { MessageBox.Show("para un aprobado directo la nota tiene que ser mayor a 7 y menor a 10"); return false; }
                    break;

            }
            return false;
        }
    }
}
