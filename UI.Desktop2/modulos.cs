using CapaNegocios;
using System;
using System.Linq;
using System.Windows.Forms;
using UI.Desktop2.database;
using CapaNegocios;
namespace UI.Desktop2
{

    public partial class modulos : Form
    {
        ModulosCRUD mod = new ModulosCRUD();
        public modulos()
        {
            InitializeComponent();
            dataGridView1.DataSource = mc.listar();
        }
        ModulosCRUD mc = new ModulosCRUD();

        private void mostrarmodulos()
        {
            using (Entidad en = new Entidad())
            {
                dataGridView1.DataSource = en.modulos.ToList();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mostrarmodulos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tp2DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void modulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.modulos' Puede moverla o quitarla según sea necesario.
            this.modulosTableAdapter.Fill(this.tp2DataSet.modulos);

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Modulos1 md1 = new Modulos1();
            md1.estado = true;
            md1.Show();
            //mostrarmodulos();

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            try
            {
                Modulos1 md1 = new Modulos1();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    md1.estado = false;
                    md1.txtdesc.Text = dataGridView1.CurrentRow.Cells["desc_modulo"].Value.ToString();
                    md1.txtEjecuta.Text = dataGridView1.CurrentRow.Cells["ejecuta"].Value.ToString();
                    md1.id = dataGridView1.CurrentRow.Cells["id_modulo"].Value.ToString();
                   
                    md1.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error, verifique los campos y los datos"); }

        }

        private void btnBAJA_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                 ModulosCRUD mcd = new ModulosCRUD();
                string id = dataGridView1.CurrentRow.Cells["id_modulo"].Value.ToString();
                mcd.Deletemodulo(id);
                
            }

           

            
            



        }

        private void modulosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            //this.modulosTableAdapter.Fill(this.tp2DataSet.modulos);
            dataGridView1.DataSource = mc.listar();
        }
    }
}
