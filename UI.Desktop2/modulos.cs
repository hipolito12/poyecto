using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios2;

namespace UI.Desktop2
{
   
    public partial class modulos : Form
    { ModulosCRUD mod = new ModulosCRUD();
        public modulos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mod.Listmodulo();
        }
    }
}
