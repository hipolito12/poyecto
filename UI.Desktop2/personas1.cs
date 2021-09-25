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
using UI.Desktop2.database;

namespace UI.Desktop2
{
    public partial class personas1 : Form
    {   public  bool estado;
       public  string id;
        Persona per =new  Persona();
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
            if(estado == true) 
            { int idplan = person[comboBox1.Text];

                per.addpersonas(txtnombre.Text, txtapellido.Text, txtdireccion.Text , txtemail.Text 
               , txttelefono.Text , txtfechan.Text , txtlegajo.Text , txttipo.Text , idplan.ToString() );

            }
            if (estado == false) 
            {
                int idplan = person[comboBox1.Text];

                per.modifypersonas(id,txtnombre.Text, txtapellido.Text, txtdireccion.Text , txtemail.Text , txttelefono.Text , txtfechan.Text , txtlegajo.Text , txttipo.Text , idplan.ToString() );
            
            
            }
        }

      
        
        
        public void cargacombo()
        {
            planes p = new planes();
            Entidad en = new Entidad();
            var vari = en.planes;

            foreach (var per in vari)
            {
                var variab = per.id_plan;
                planes pla = en.planes.Where(pl => pl.id_plan == variab).First();
                string descripcion = pla.desc_plan;
                int id = pla.id_plan;
                person.Add(descripcion,id);
                this.comboBox1.Items.Add(descripcion).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
