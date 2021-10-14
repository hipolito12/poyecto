using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop2;
using UI.Desktop2.database;
using CapaNegocios;

namespace UI.Desktop2
{
    public partial class Docentes_Cursos : Form
    {
        public Docentes_Cursos()
        {
            InitializeComponent();
            this.docentes_cursosTableAdapter1.Fill(this.tp2DataSet.docentes_cursos);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.docentes_cursosTableAdapter1.Fill(this.tp2DataSet.docentes_cursos);
        }

        private void Docentes_Cursos_Load(object sender, EventArgs e)
        {

        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            profesores_modulos dc1 = new profesores_modulos();
            
            dc1.estado = true;
            dc1.txtdictado.Visible = false;
            dc1.lblcargo.Visible = false;
            dc1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            profesores_modulos pm = new profesores_modulos();
            pm.estado = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {

                pm.txtcargos.Text = dataGridView1.CurrentRow.Cells["cargo"].Value.ToString();
                pm.txtCurso.Text = dataGridView1.CurrentRow.Cells["id_curso"].Value.ToString();
                pm.txtdictado.Text= dataGridView1.CurrentRow.Cells["id_dictado"].Value.ToString();
                pm.txtdocente.Text = dataGridView1.CurrentRow.Cells["id_docente"].Value.ToString();
                
                pm.Show();
                
            }
            else { MessageBox.Show("selecciona fila"); }
        }

        private void btnbaja_Click(object sender, EventArgs e)
        {
            try
            {
                docentes_cursos_CRUD dcc = new docentes_cursos_CRUD();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dynamic idc = dataGridView1.CurrentRow.Cells["id_curso"].Value.ToString();
                    var idd = dataGridView1.CurrentRow.Cells["id_docente"].Value.ToString();
                    dcc.DELETEdocentesCURSO(idc, idd);
                    this.docentes_cursosTableAdapter1.Fill(this.tp2DataSet.docentes_cursos);
                }
                else { MessageBox.Show("selecciona fila"); }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }

        }
    }
}
