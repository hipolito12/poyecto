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
    public partial class comisiones : Form
    {
        public comisiones()
        {
            InitializeComponent();
            Comision c = new Comision();
            dataGridView1.DataSource = c.Listar();
        }

        private void comisiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.comisiones' Puede moverla o quitarla según sea necesario.
            this.comisionesTableAdapter.Fill(this.tp2DataSet.comisiones);

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Comision c = new Comision();
                    string id = dataGridView1.CurrentRow.Cells["id_comision"].Value.ToString();
                    c.eliminar_comision(id);
                }
                else { MessageBox.Show("selecione una fila"); }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error, los datos estan siendo utilizado en otro proceso"); }
            
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Comisiones_1 com1 = new Comisiones_1();
            com1.estado = false;
            com1.id = dataGridView1.CurrentRow.Cells["id_comision"].Value.ToString();
            com1.textanio.Text = dataGridView1.CurrentRow.Cells["anio_especialidad"].Value.ToString();
            com1.Show();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            Comisiones_1 com1 = new Comisiones_1();
            com1.estado = true;
            com1.Show();
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            Comision c = new Comision();
            dataGridView1.DataSource = c.Listar();
        }
    }
}
