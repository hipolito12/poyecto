using CapaNegocios;
using System;
using System.Collections.Generic;
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
                if (estado == true)
                {
                    int idplan = per.cargar()[comboidplan.Text];

                    per.addpersonas(txtnombre.Text, txtapellido.Text, txtdireccion.Text, txtemail.Text
                   , txttelefono.Text, txtfechan.Text, txtlegajo.Text, txttipo.Text, idplan.ToString());

                }
                if (estado == false)
                {
                    int idplan = per.cargar()[comboidplan.Text];
                   
                    per.modifypersonas(id, txtnombre.Text, txtapellido.Text, txtdireccion.Text, txtemail.Text, txttelefono.Text, txtfechan.Text, txtlegajo.Text, txttipo.Text, idplan.ToString());


                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }
        }




        public void cargacombo()
        {
            Dictionary<string, int> tup = new Dictionary<string, int>();



            foreach (string k in per.cargar().Keys)
            {
                comboidplan.Items.Add(k);

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void personas1_Load(object sender, EventArgs e)
        {

        }
    }
}
