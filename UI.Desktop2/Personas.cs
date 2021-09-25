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
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.tp2DataSet.personas);

        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                string id = dataGridView1.CurrentRow.Cells["idpersona"].Value.ToString();
                p.deletepersonas(id);
            
            }
            else { MessageBox.Show("Seleccione fila"); }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.personasTableAdapter.Fill(this.tp2DataSet.personas);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            personas1 pe1 = new personas1();
            pe1.txtapellido.Text= dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
            pe1.txtdireccion.Text = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
            pe1.txtemail.Text= dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            pe1.txtfechan.Text= dataGridView1.CurrentRow.Cells["fechanac"].Value.ToString();
            pe1.txtlegajo.Text= dataGridView1.CurrentRow.Cells["legajo"].Value.ToString();
            pe1.txtnombre.Text= dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            //pe1.txtplan.Text= dataGridView1.CurrentRow.Cells["idplan"].Value.ToString();
            pe1.txttelefono.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            pe1.txttipo.Text= dataGridView1.CurrentRow.Cells["tipopersonas"].Value.ToString();
            pe1.id= dataGridView1.CurrentRow.Cells["idpersona"].Value.ToString();
            pe1.estado = false;
            pe1.Show();

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            personas1 pe1 = new personas1();           
            pe1.estado =true;
            pe1.Show();
        }
    }
}
