using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop2.database;
using CapaNegocios; 


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
            //string mid = txtidmateria.Text;
            Materia_n ma = new Materia_n();
            if (estado == true)//Agrega
            {
                int ID = buscaid(comboidplan.Text);
                ma.agregarmateria(txtdescripcion.Text,txtHs_Semanales.Text,TXTHs_Totales.Text, ID.ToString());

            }
            if(estado == false)//edita
            {
                Materia maf = new Materia();
              
                int ID = buscaid(comboidplan.Text);
                ma.EditarMaterias(txtdescripcion.Text, IDmateria ,txtHs_Semanales.Text, TXTHs_Totales.Text,ID.ToString());
                
            }
        }
    
       private int buscaid(string desc) 
        { Entidad en = new Entidad();
            planes pl = new planes();
            planes pla= en.planes.Where(plan=> plan.desc_plan== desc).First();
            int ID =pla.id_plan;
            Console.WriteLine(ID);
            return ID;
        }

        public void meterdatos()
        {
            planes p = new planes();
            Entidad en = new Entidad();
            var vari = en.planes;

            foreach (var per in vari)
            {
                var variab = per.id_plan;
                planes pla = en.planes.Where(pl => pl.id_plan == variab).First();
                string descripcion = pla.desc_plan;
                this.comboidplan.Items.Add(descripcion).ToString();
            }
        }


    }
}
