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
    public partial class _Plan_ : Form
    {
        
        public _Plan_()
        {
            InitializeComponent();
        }

        private void _Plan__Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.tp2DataSet.planes);

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ID = dataGridView1.CurrentRow.Cells["idplan"].Value.ToString();
                Plan_ pl = new Plan_();
                pl.eliminaplan(ID.ToString());
            }
            else { MessageBox.Show($"seleccionar una fila"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.planesTableAdapter.Fill(this.tp2DataSet.planes);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            PlanesIngresoDatos uid = new PlanesIngresoDatos();
            uid.estado = true;
            uid.Show();
            
        }

        private void btnmodificacion_Click(object sender, EventArgs e)
        {
            PlanesIngresoDatos uid = new PlanesIngresoDatos();
            uid.estado = false;
            uid.richdescripcion.Text= dataGridView1.CurrentRow.Cells["descplan"].Value.ToString();
            uid.Show();

        }
    }
}
