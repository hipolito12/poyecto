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
        Plan_ Pl = new Plan_();
        public PlanesIngresoDatos()
        {
            InitializeComponent();
            carga_combo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void carga_combo()
        {
            
           comboBox1.DataSource= Pl.cargargarcombos().ToString();
        }
    }
}
