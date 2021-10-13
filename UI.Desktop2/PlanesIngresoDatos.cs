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
    public partial class PlanesIngresoDatos : Form
    {
        public bool estado;
        public string idedit;
        Dictionary<string, int> posiciones = new Dictionary<string, int>();
        Plan_ Pl = new Plan_();
        public PlanesIngresoDatos()
        {
            InitializeComponent();
            carga_combo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (estado == true && richdescripcion.Text != null) 
            {
                try
                {
                    int posi = posiciones[comboBox1.Text];
                    Pl.agregarplan(richdescripcion.Text,posi.ToString() );
                }
                catch (Exception ex) { MessageBox.Show($"error:{ex} "); }
            }
            if (estado ==  false && richdescripcion.Text != null) 
            {
                try
                {
                    int posi = posiciones[comboBox1.Text];
                    Pl.editplan(idedit,richdescripcion.Text,posi.ToString());
                }
                catch (Exception exe) { MessageBox.Show($"error:{exe} "); }
            }
        }

        private void carga_combo()
        {
           
            int pos=0;
            foreach (var k in Pl.cargargarcombos()) 
            {
                comboBox1.Items.Add(k);
                posiciones.Add(k,pos);
                pos++;
            }
        }

        private void PlanesIngresoDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
