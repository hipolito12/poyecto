﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios2;
using System.Data.SqlClient;
using UI.Desktop2.database;

namespace UI.Desktop2
{
   
    public partial class modulos : Form
    { ModulosCRUD mod = new ModulosCRUD();
        public modulos()
        {
            InitializeComponent();
           
        }

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
            md1.btnEDITAR.Visible = false;
            md1.Show();
            //mostrarmodulos();
          
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            
            Modulos1 md1 = new Modulos1();
            if (dataGridView1.SelectedRows.Count>0 )
            {
                md1.txtdesc.Text = textBox1.Text;
                md1.txtEjecuta.Text = textBox3.Text;
                md1.txtID.Text = textBox2.Text;
                md1.btnagregar.Visible = false;
                md1.Show();
            }

        }

        private void btnBAJA_Click(object sender, EventArgs e)
        {
            ModulosCRUD mcd = new ModulosCRUD();

            string id = textBox2.Text;
            mcd.Deletemodulo(id);  
         

           
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
            this.modulosTableAdapter.Fill(this.tp2DataSet.modulos);
        }
    }
}