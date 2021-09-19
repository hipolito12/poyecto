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
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;
using UI.Desktop2.database;

namespace UI.Desktop2
{
    public partial class Modulos1 : Form
    {
        modulos mo = new modulos();
        public Modulos1()
        {
            InitializeComponent();
        }
        public void Limpia() 
        {
            txtdesc.Clear();
            txtEjecuta.Clear();
        }


       
            


            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ModulosCRUD mc = new ModulosCRUD();

            mc.ADDmodulo(txtdesc.Text,txtEjecuta.Text);
            Limpia();
            this.Close();
           


        }

        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            
            ModulosCRUD mc = new ModulosCRUD();
            mc.Updatemodulo(txtdesc.Text,txtID.Text, txtEjecuta.Text);

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
