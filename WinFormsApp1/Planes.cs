using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using capaNegocios;

namespace UI.Desktop
{
    public partial class Planes : Form

    {


        bool Editar = false;
        string catcher;


        private PlanCRUD pc = new PlanCRUD();
        private void limpiarcampos()
        {
            Descripcion.Text = "";
            txtespecialidad.Text = "";
        }

        public void mostrar_todes_planes()
        {
            PlanCRUD a = new PlanCRUD();
            dataGridView1.DataSource = a.muestra();
        }

        public Planes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Planes_Load(object sender, EventArgs e)
        {
            mostrar_todes_planes();
        }

        private void BtnInserrtar_Click(object sender, EventArgs e)
        {
            PlanCRUD a = new PlanCRUD();
            if (Editar == false)
            {
                try
                {
                   
                    a.addp(txtdescripcion.Text, txtespecialidad.Text);
                    MessageBox.Show("se inserto correctamente");

                    mostrar_todes_planes();
                    limpiarcampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //edita
            if (Editar == true)
            {
                try
                {
                    a.Editap(txtdescripcion.Text,txtespecialidad.Text,catcher);
                    MessageBox.Show("se edito correctamente");
                    mostrar_todes_planes();
                    limpiarcampos();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }
    

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                PlanCRUD a = new PlanCRUD();
                catcher = dataGridView1.CurrentRow.Cells["id_plan"].Value.ToString();
                a.Eliminap(catcher);
                MessageBox.Show("Eliminado correctamente ");

                mostrar_todes_planes();
            }
            else
                MessageBox.Show("seleccione una fila ");
        }


        private void btnedit_Click(object sender, EventArgs e)
        {
                 if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
               
                txtdescripcion.Text = dataGridView1.CurrentRow.Cells["desc_plan"].Value.ToString();
              txtespecialidad.Text = dataGridView1.CurrentRow.Cells["id_especialidad"].Value.ToString();
               
               catcher= dataGridView1.CurrentRow.Cells["id_plan"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");



        }
    }
}

