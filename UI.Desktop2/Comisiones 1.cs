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
    public partial class Comisiones_1 : Form
    {
        public Comisiones_1()
        {
            InitializeComponent();
            cargarCombos();
        }
        public bool estado;
        public string id;
        private void Comisiones_1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Comision c = new Comision();
                if (txtdescripcion.Text =="" || comboidpan.Text == ""|| textanio.Text == "")
                {
                    MessageBox.Show("Hay campos vacios , verifique su entrada");

                }



                if (estado == true)
                {
                   int idplan= c.cargarcombo()[comboidpan.Text];
                    
                    c.agregar_comisiones(txtdescripcion.Text, textanio.Text, idplan.ToString());
                }

                if (estado == false)
                {
                    int idplan = c.cargarcombo()[comboidpan.Text];
                    c.editar_comision(txtdescripcion.Text, textanio.Text, idplan.ToString(), id);
                }
            }
            catch (Exception ex) { MessageBox.Show("error:" + ex); }
        }
    
    
    
    
        public void cargarCombos() 
        {
            Comision c = new Comision();
           foreach(var k in c.cargarcombo()) 
           {
                comboidpan.Items.Add(k.Key);
           }
        }
    }
}
