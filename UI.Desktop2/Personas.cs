using CapaNegocios;
using System;
using CapaNegocios;
using System.Windows.Forms;
namespace UI.Desktop2
{
    public partial class Personas : Form
    {
        Persona p = new Persona();
        public Personas()
        {
            InitializeComponent();
           dataGridView1.DataSource= p.listar();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.tp2DataSet.personas);

        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = new Persona();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string id = dataGridView1.CurrentRow.Cells["id_persona"].Value.ToString();
                    p.deletepersonas(id);

                }
                else { MessageBox.Show("Seleccione fila"); }
            }
            catch (Exception ex) { MessageBox.Show($" no se puede eliminar  debido a que el dato esta esta siendo utilizado en otras funciones \n"); }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();
            //this.personasTableAdapter.Fill(this.tp2DataSet.personas);
            dataGridView1.DataSource = per.listar();

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            personas1 pe1 = new personas1();
            pe1.txtapellido.Text = dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
            pe1.txtdireccion.Text = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
            pe1.txtemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            pe1.txtfechan.Text = dataGridView1.CurrentRow.Cells["fecha_nac"].Value.ToString();
            pe1.txtlegajo.Text = dataGridView1.CurrentRow.Cells["legajo"].Value.ToString();
            pe1.txtnombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            //pe1.txtplan.Text= dataGridView1.CurrentRow.Cells["idplan"].Value.ToString();
            pe1.txttelefono.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            pe1.txttipo.Text = dataGridView1.CurrentRow.Cells["tipo_persona"].Value.ToString();
            pe1.id = dataGridView1.CurrentRow.Cells["id_persona"].Value.ToString();
            pe1.estado = false;
            pe1.Show();

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            personas1 pe1 = new personas1();
            pe1.estado = true;
            pe1.Show();
        }
    }
}
