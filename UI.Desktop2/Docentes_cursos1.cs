using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios;
using System.Windows.Forms;

namespace UI.Desktop2
{
    public partial class profesores_modulos : Form
    {
        public profesores_modulos()
        {
            InitializeComponent();
        }
        public void limpiar() 
        {
            txtcargos.Clear();
            txtCurso.Clear();
            txtdictado.Clear();
            txtdocente.Clear();
        }

        private void profesores_modulos_Load(object sender, EventArgs e)
        {

        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            docentes_cursos_CRUD dcc = new docentes_cursos_CRUD();
            dcc.ADDdocenteCURSO(txtcargos.Text,txtCurso.Text,txtdocente.Text);
            limpiar();

        }

        private void btnEDT_Click(object sender, EventArgs e)
        {
            Docentes_Cursos dc = new Docentes_Cursos();
            docentes_cursos_CRUD dcc = new docentes_cursos_CRUD();
            dcc.EDITdoceneteCURSO(txtcargos.Text,txtCurso.Text,txtdocente.Text,txtdictado.Text);
            MessageBox.Show("Editado!");
            
            

        }
    }
}
