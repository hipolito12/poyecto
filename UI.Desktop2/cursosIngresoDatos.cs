using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace UI.Desktop2
{
    public partial class cursos1 : Form

    {
        public bool estado;
        public string idcurso;
        Dictionary<string, int> mate = new Dictionary<string, int>();

        Dictionary<string, int> c = new Dictionary<string, int>();

        public cursos1()
        {
            InitializeComponent();
            cargarcombos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtanio.Text == null || txtCupo.Text == null || comboComision.Text == null || ComboMateria.Text == null)
                {
                    MessageBox.Show("campos vacios, verifique los campos");
                }
                if (estado == true)
                {
                    
                    
                    CursosCRUD curses = new CursosCRUD();
                    int idmat = curses.devuelv_combo().Item1[ComboMateria.Text];

                    int idcom = curses.devuelv_combo().Item2[comboComision.Text];

                    curses.agregarCurso(idmat.ToString(), idcom.ToString(), txtCupo.Text, txtanio.Text);
                    limpiacampos();

                }

                if (estado == false)
                {

                    
                    CursosCRUD curses = new CursosCRUD();
                    int idmat = curses.devuelv_combo().Item1[ComboMateria.Text];

                    int idcom = curses.devuelv_combo().Item2[comboComision.Text];
                    

                   curses.EditarCurso(idcurso, idcom.ToString(), txtCupo.Text, txtanio.Text, idmat.ToString());
                    this.Close();
                    MessageBox.Show("Modificado con exito");
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }


        }


        public void cargarcombos()
        {
            CursosCRUD curses = new CursosCRUD();
            (Dictionary<string, int>, Dictionary<string, int>) tup = curses.devuelv_combo();
            //(mate,c)
            foreach (var varia in tup.Item1)
            {


                ComboMateria.Items.Add(varia.Key);

                mate.Add(varia.Key, varia.Value);


            }

            foreach (var vari in tup.Item2)
            {
                comboComision.Items.Add(vari.Key);
                c.Add(vari.Key, vari.Value);

            }

        }
        public void limpiacampos()
        {
            txtanio.Clear();
            txtCupo.Clear();

        }
        private void cursos1_Load(object sender, EventArgs e)
        {

        }

        private void comboComision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
