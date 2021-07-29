using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocios;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        materiasCRUD k = new materiasCRUD();
        private string idmateria= null;
        private string planid = null;
         bool Editar = false;

        private void limpiarForm()
        {
            descrip.Clear();
            totales.Text = "";
            semanales.Clear();
            plant.Text = "";
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarmaterias();
        }
        private void mostrarmaterias()
        {
            materiasCRUD s = new materiasCRUD();
            dataGridView1.DataSource = s.muestra();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hs_semanales_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                k.add(descrip.Text, totales.Text, semanales.Text, plant.Text);
                mostrarmaterias();
                limpiarForm();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //edita
            

            if (Editar == true)
            {
                try
                {
                    
                      k.Edita(descrip.Text, totales.Text, semanales.Text,plant.Text, idmateria);
                    MessageBox.Show("se edito correctamente");
                    mostrarmaterias();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
           
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;

                descrip.Text = dataGridView1.CurrentRow.Cells["desc_materia"].Value.ToString();
                semanales.Text = dataGridView1.CurrentRow.Cells["hs_semanales"].Value.ToString();
                totales.Text = dataGridView1.CurrentRow.Cells["hs_totales"].Value.ToString();
                plant.Text = dataGridView1.CurrentRow.Cells["id_plan"].Value.ToString();
                idmateria = dataGridView1.CurrentRow.Cells["Id_materia"].Value.ToString();


            }
            else
                MessageBox.Show("seleccione una fila por favor");
              }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idmateria = dataGridView1.CurrentRow.Cells["Id_materia"].Value.ToString();
                k.Elimina(idmateria);
                MessageBox.Show("Eliminado correctamente");
                mostrarmaterias();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
    }
    

