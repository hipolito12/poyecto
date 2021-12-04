using CapaNegocios;
using System;
using System.Windows.Forms;

namespace UI.Desktop2
{
    public partial class cursos : Form
    {
        public cursos()
        {
            InitializeComponent();
        }

        private void cursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.tp2DataSet.cursos);

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            cursos1 cur = new cursos1();
            cur.estado = true;
            cur.Show();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                cursos1 cur = new cursos1();
                cur.estado = false;
                cur.txtanio.Text = dataGridView1.CurrentRow.Cells["aniocalendario"].Value.ToString();
                cur.txtCupo.Text = dataGridView1.CurrentRow.Cells["cupo"].Value.ToString();
                cur.idcurso = dataGridView1.CurrentRow.Cells["idcursos"].Value.ToString();
                cur.Show();
            }
            else { MessageBox.Show("seleccione columna"); }
        }

        private void btbElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    CursosCRUD curses = new CursosCRUD();
                    string idcurso = dataGridView1.CurrentRow.Cells["idcursos"].Value.ToString();
                    curses.elimminarcurso(idcurso);

                }
                else { MessageBox.Show("seleccione columna"); }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.cursosTableAdapter.Fill(this.tp2DataSet.cursos);
        }
    }
}
