using CapaNegocios;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace UI.Desktop2
{
    public partial class Materias1 : Form
    {
        public Materias1()
        {
            InitializeComponent();
            meterdatos();
        }
        public bool estado;
        public string IDmateria;
        private void txtIDPLAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Materias1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.tp2DataSet.planes);

        }

        private void comboidplan_SelectedIndexChanged(object sender, EventArgs e)
        {



            // meterdatos() ;  
        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdescripcion.Text != "" && comboidplan.Text != "" && txtdescripcion.Text != "" && txtHs_Semanales.Text != "" &&
                    Regex.IsMatch(txtdescripcion.Text, "[a-z,A-Z,0-1]{10,300}") == true &&
                    Regex.IsMatch(TXTHs_Totales.Text, "[0-9]") == true
                    && Regex.IsMatch(txtHs_Semanales.Text, "[0-9]") == true)
                {

                    Materia_n ma = new Materia_n();
                    if (estado == true)//Agrega
                    {
                        int ID = buscaid(comboidplan.Text);
                        ma.agregarmateria(txtdescripcion.Text, txtHs_Semanales.Text, TXTHs_Totales.Text, ID.ToString());
                        MessageBox.Show($"agregado!");
                    }
                    if (estado == false)//edita
                    {


                        int ID = buscaid(comboidplan.Text);
                        ma.EditarMaterias(txtdescripcion.Text, IDmateria, txtHs_Semanales.Text, TXTHs_Totales.Text, ID.ToString());
                        MessageBox.Show($"Modificado!");
                    }
                }
                else 
                {
                    MessageBox.Show($"error:hay campos vacios, verifiquelos!");

                }
                //string mid = txtidmateria.Text;
               
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error, verifique los campos y los datos ingresados"); }
        }

        private int buscaid(string desc)
        {

            Materia_n mn = new Materia_n();
            int k = mn.busqueda(desc);
            return k;
        }

        public void meterdatos()
        {
            Materia_n mn = new Materia_n();
            foreach (var k in mn.carga().ToArray() ) 
            {
                comboidplan.Items.Add(k);
            }
        }


    }
}
