using CapaNegocios;
using System;
using System.Windows.Forms;
using CapaNegocios;

namespace UI.Desktop2
{
    public partial class cursos : Form
    {
        public cursos()
        {
           
            InitializeComponent();
            cargargrid();
        }

        private void cursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.tp2DataSet.cursos);

        }
        void cargargrid() 
        {
            CursosCRUD cc = new CursosCRUD();
            dataGridView1.DataSource = cc.Listar();
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
                cur.txtanio.Text = dataGridView1.CurrentRow.Cells["anio_calendario"].Value.ToString();
                cur.txtCupo.Text = dataGridView1.CurrentRow.Cells["cupo"].Value.ToString();
                cur.idcurso = dataGridView1.CurrentRow.Cells["id_curso"].Value.ToString();
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
                    string idcurso = dataGridView1.CurrentRow.Cells["id_curso"].Value.ToString();
                    curses.elimminarcurso(idcurso);
                    MessageBox.Show("eliminado!");
                }
                else { MessageBox.Show("seleccione columna"); }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error, los datos estan siendo utilizado en otro proceso"); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CursosCRUD dc = new CursosCRUD();
           dataGridView1.DataSource= dc.Listar();
        }
    }
}
