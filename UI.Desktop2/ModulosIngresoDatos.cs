using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Desktop2
{

    public partial class Modulos1 : Form
    {
        public bool estado;
        public string  id;
        modulos mo = new modulos();
        public Modulos1()
        {
            InitializeComponent();
         //   cargarcombo();
        }
        public void Limpia()
        {
            txtdesc.Clear();
            txtEjecuta.Clear();
        }

        Dictionary<string, int> dicti = new Dictionary<string, int>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (estado == true)
                {
                    ModulosCRUD mc = new ModulosCRUD();

                    mc.ADDmodulo(txtdesc.Text, txtEjecuta.Text);
                    Limpia();
                    this.Close();
                }
                if (estado == false)
                {
                    ModulosCRUD mc = new ModulosCRUD();
                    //int n = mc.cargador()[txtdesc.Text];
                    mc.Updatemodulo(txtdesc.Text, id.ToString(), txtEjecuta.Text);
                }

            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }

        }

        private void btnEDITAR_Click(object sender, EventArgs e)
        {



        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Modulos1_Load(object sender, EventArgs e)
        {

        }
      
    }
}
