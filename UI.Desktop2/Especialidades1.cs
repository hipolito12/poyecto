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
    public partial class Especialidades1 : Form
       
        { public bool estado;
       Especialidad es = new Especialidad();
        public string id;
        public Especialidades1()
        {
            InitializeComponent();
        }

        private void richdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == true) 
            {
                es.addEspecialidad(richdescripcion.Text);
            }

            if (estado == false) 
            {
                
                es.Editespecialidades(id, richdescripcion.Text);
            }
        }
    }
}
