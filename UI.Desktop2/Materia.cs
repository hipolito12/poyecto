using CapaNegocios;
using System;
using System.Windows.Forms;

namespace UI.Desktop2
{
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }

        private void Materia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.tp2DataSet.materias);

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Materias1 ma1 = new Materias1();
            ma1.estado = true;
            //ma1.lblidmateria.Visible = false;
            // ma1.txtidmateria.Visible = false;
            ma1.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Materias1 ma1 = new Materias1();
            ma1.estado = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ma1.txtdescripcion.Text = dataGridView1.CurrentRow.Cells["descripcionMateriaD"].Value.ToString();
                //  ma1.txtidmateria.Text = dataGridView1.CurrentRow.Cells["idMateriaD"].Value.ToString();
                ma1.txtHs_Semanales.Text = dataGridView1.CurrentRow.Cells["hsSemanlaesD"].Value.ToString();
                ma1.TXTHs_Totales.Text = dataGridView1.CurrentRow.Cells["hsTotales_D"].Value.ToString();
                ma1.Show();
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Materia_n m = new Materia_n();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.CurrentRow.Cells["idMateria"].Value.ToString();
                m.eliminarMateria(id);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.materiasTableAdapter.Fill(this.tp2DataSet.materias);
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            Materias1 ma1 = new Materias1();
            ma1.estado = true;
            // ma1.lblidmateria.Visible = false;
            //ma1.txtidmateria.Visible = false;
            ma1.Show();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Materias1 ma1 = new Materias1();
            ma1.estado = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ma1.txtdescripcion.Text = dataGridView1.CurrentRow.Cells["desc_materia"].Value.ToString();
                ma1.IDmateria = dataGridView1.CurrentRow.Cells["idMateria"].Value.ToString();
                ma1.txtHs_Semanales.Text = dataGridView1.CurrentRow.Cells["hs_semanales"].Value.ToString();
                ma1.TXTHs_Totales.Text = dataGridView1.CurrentRow.Cells["hs_totales"].Value.ToString();
                ma1.Show();
            }
            else { MessageBox.Show("seleccione columna"); }
        }
    }
}
