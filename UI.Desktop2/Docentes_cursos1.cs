﻿using CapaNegocios;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UI.Desktop2
{
    public partial class profesores_modulos : Form
    {
        public string id;
        public bool estado;
        public profesores_modulos()
        {
            InitializeComponent();
            cargacombos();
        }
        public void limpiar()
        {
            txtcargos.Clear();
           
        }

        private void profesores_modulos_Load(object sender, EventArgs e)
        {

        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcargos.Text == null || Combo_id_docente.Text == null ||combo_id_Curso.Text == null)
                {
                    MessageBox.Show("campos vacios , verifique los campos");

                }
                if (estado == true)
                {     
                    docentes_cursos_CRUD dcc = new docentes_cursos_CRUD();
                    int id_docente = dcc.cargaDeCombos().Item1[Combo_id_docente.Text];
                    int id_curso = dcc.cargaDeCombos().Item2[combo_id_Curso.Text];
                    dcc.ADDdocenteCURSO(txtcargos.Text,id_curso.ToString(), id_docente.ToString());
                    MessageBox.Show("agregado!");
                    this.Close();
                    limpiar();
                }
                if (estado == false)
                {
                    
                    docentes_cursos_CRUD dcc = new docentes_cursos_CRUD();
                    int id_docente = dcc.cargaDeCombos().Item1[Combo_id_docente.Text];
                    int id_curso = dcc.cargaDeCombos().Item2[combo_id_Curso.Text];

                    dcc.EDITdoceneteCURSO(txtcargos.Text, id_curso.ToString() , id_docente.ToString(), id.ToString());
                    MessageBox.Show("Editado!");
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }
        }

        private void btnEDT_Click(object sender, EventArgs e)
        {




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void cargacombos() 
        {
            docentes_cursos_CRUD dcc = new docentes_cursos_CRUD();
            foreach (var docente in dcc.cargaDeCombos().Item1.Keys   ) 
            {
                Combo_id_docente.Items.Add(docente);

            }

            
            foreach (var cur in dcc.cargaDeCombos().Item2.Keys  ) 
            {
                combo_id_Curso.Items.Add(cur);
            }
        }

    }

}
