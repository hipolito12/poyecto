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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.tp2DataSet.especialidades);

        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            Especialidades1 es1 = new Especialidades1();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                es1.id = dataGridView1.CurrentRow.Cells["idespecialidad"].Value.ToString();
                es1.estado = false;
                es1.Show();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Especialidades1 es1 = new Especialidades1();
            es1.estado = true;
            es1.Show();
        }

        private void btnBAJA_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string id = dataGridView1.CurrentRow.Cells["idespecialidad"].Value.ToString();
                    Especialidad espes = new Especialidad();
                    espes.delete_especialidad(id);
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.especialidadesTableAdapter.Fill(this.tp2DataSet.especialidades);
        }
    }
}
