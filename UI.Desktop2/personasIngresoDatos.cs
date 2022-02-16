using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI.Desktop2
{
    public partial class personas1 : Form
    {
        public bool estado;
        public string id;
        Persona per = new Persona();
        Dictionary<string, int> person = new Dictionary<string, int>();
        public personas1()
        {
            InitializeComponent();
            cargacombo();
        }
        Dictionary<string, int> tipos = new Dictionary<string, int>();

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnacept_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtapellido.Text !="" &&  txtdireccion.Text != "" && txtemail.Text != "" && txtlegajo.Text != "" && txtnombre.Text != "" && txttelefono.Text != "" 
                    && Regex.IsMatch(txtapellido.Text, "[A-Z,a-z]{5,10}") ==true && Regex.IsMatch(txtnombre.Text, "[A-Z,a-z]{5,10}") == true
                    && Regex.IsMatch(txttelefono.Text, "[0-9]{5,10}") == true
                    && Regex.IsMatch(txtlegajo.Text, "[0-9]{1,10}") == true
                    && Regex.IsMatch(txtemail.Text, "[A-Z,a-z,0-9]@[A-Z,a-z]") == true
                    && Regex.IsMatch(txtdireccion.Text, "[A-Z,a-z,0-9]{5,50}") == true) {
                    if (estado == true)
                    {
                        int idplan = per.cargar()[comboidplan.Text];

                        per.addpersonas(txtnombre.Text, txtapellido.Text, txtdireccion.Text, txtemail.Text
                       , txttelefono.Text, dtpnacimiento.Value.ToString(), txtlegajo.Text, tipos[comboTipos.SelectedItem.ToString()].ToString(), idplan.ToString());
                        MessageBox.Show("Agregado!");
                    }
                    if (estado == false)
                    {
                        int idplan = per.cargar()[comboidplan.Text];

                        per.modifypersonas(id, txtnombre.Text, txtapellido.Text, txtdireccion.Text, txtemail.Text, txttelefono.Text, dtpnacimiento.Value.ToString(), txtlegajo.Text, tipos[comboTipos.SelectedItem.ToString()].ToString(), idplan.ToString());
                        MessageBox.Show("Modificado!");
                        this.Close();
                    }
                }
                else { MessageBox.Show("Ha ocurrido un error, verifique que no haya campos vacios y el formato de cada campo ") ; vaciarcampos(); }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error, verifique los campos y los datos"); }
        }




        public void cargacombo()
        {
            Dictionary<string, int> tup = new Dictionary<string, int>();



            foreach (string k in per.cargar().Keys)
            {
                comboidplan.Items.Add(k);

            }

            tipos.Add("Profesor",1);
            tipos.Add("Alumno", 2);
            tipos.Add("Administrador", 0);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void personas1_Load(object sender, EventArgs e)
        {

        }

        void vaciarcampos() 
        {
            txtapellido.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
            txtlegajo.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
        }
    }
}
