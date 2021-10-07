using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop2
{
    public partial class Planes_ : Form
    {
        public Planes_()
        {
            InitializeComponent();
        }

        private void Planes__Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.tp2DataSet.planes);

        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {

        }
    }
}
