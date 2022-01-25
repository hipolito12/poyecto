using CapaNegocios;
using System;
using System.Windows.Forms;
using CapaNegocios;
namespace UI.Desktop2
{
    public partial class _Plan_ : Form
    {
         Plan_ pl = new Plan_();
        public _Plan_()
        {
            InitializeComponent();
            dataGridView1.DataSource = pl.listar();

        }
       
        private void _Plan__Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.tp2DataSet.planes);

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string ID = dataGridView1.CurrentRow.Cells["id_plan"].Value.ToString();
                    Plan_ pl = new Plan_();
                    pl.eliminaplan(ID.ToString());
                }
                else { MessageBox.Show($"seleccionar una fila"); }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.planesTableAdapter.Fill(this.tp2DataSet.planes);
            Plan_ pla = new Plan_();
            dataGridView1.DataSource = pla.listar();
            dataGridView1.Refresh();
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
            uid.richdescripcion.Text = dataGridView1.CurrentRow.Cells["desc_plan"].Value.ToString();
            uid.idedit = dataGridView1.CurrentRow.Cells["id_plan"].Value.ToString();
            uid.Show();

        }
    }
}
