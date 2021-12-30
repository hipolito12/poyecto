using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.SqlServer.Types;
using System.Data.SqlClient;
using CapaNegocios;
namespace UI.Desktop2
{
    public partial class Pruebas : Form
    {
        public int idpersonacp ;
        public Pruebas()
        {
            
          
            InitializeComponent();
            cargarpls();
            reportViewer1.Visible = false;
          
        }
        
        public void cargarpls() 
        {
            Notas n = new Notas();
            foreach (var m in n.fechasyparacombo(idpersonacp)) { 
            comboBox1.Items.Add(m.anio + m.materia+ m.Nota);
            }

        }

        private void Pruebas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2DataSet.cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.tp2DataSet.cursos);

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
         

        }
        void alg( int fecha , int idpersona ) 
        {
            Notas n = new Notas();
            mostrar_notasBindingSource.DataSource = n.algo(fecha,idpersona);
          //  mostrar_notasBindingSource.Add(t.algo());

            ReportDataSource ds = new ReportDataSource("Prueba", n.algo(fecha,idpersona));
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            
        }

        /*void cargarcombo() 
        {
            int i = 0;
            Notas n = new Notas();
            Login.Alumnos al = new Login.Alumnos();
            
            foreach (var k in n.fechasyparacombo(al.idpersona))
            {
              i=i+1;
                comboBox1.Items.Add("hola");
                comboBox1.Items.Add(k.anio.ToString());


            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Login.Alumnos al = new Login.Alumnos();
                string campo = Convert.ToString(  comboBox2.SelectedItem.ToString()  );
                foreach (var k in comboBox2.Items) 
                {
                    var m = k;
                    MessageBox.Show(k.ToString());
                }
                MessageBox.Show(campo );
                //alg(10,15);
               // reportViewer1.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
