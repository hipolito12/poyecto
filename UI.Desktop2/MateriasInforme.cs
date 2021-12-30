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
    public partial class MateriasInforme : Form
    {
        public MateriasInforme()
        {
            InitializeComponent();
        }

        private void MateriasInforme_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.tp2DataSet.materias);

            this.reportViewer1.RefreshReport();
        }
    }
}
