using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop2.database;
using CapaNegocios;
namespace UI.Desktop2
{
    public partial class cursos1 : Form

    {
       public bool estado;
        public string idcurso;
        Dictionary<string, int> mate = new Dictionary< string,int>();
        Dictionary<string, int> c = new Dictionary<string, int>();
        public cursos1()
        {
            InitializeComponent();
            cargarcombos();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            if (estado == true) 
            {
               int idmat= mate[ComboMateria.Text];
              int  idcom = c[comboComision.Text];
                CursosCRUD curses = new CursosCRUD();
                
                curses.agregarCurso(idmat.ToString(),idcom.ToString(),txtCupo.Text,txtanio.Text);
                limpiacampos();

            }

            if(estado == false) 
            {
                int idmat = mate[ComboMateria.Text];
                cursos cu = new cursos();
               
                int idcom = c[comboComision.Text];
                CursosCRUD curses = new CursosCRUD();
              
                curses.EditarCurso(  idcurso, idcom.ToString() ,txtCupo.Text, txtanio.Text,idmat.ToString()  );
            }
      
        
        }


        public void cargarcombos() 
        {
            Entidad en = new Entidad();
            comisiones com = new comisiones();
            materias mat = new materias();
            var vari = en.comisiones;
           
            foreach (var comis in vari)//comisiones
            {
                var variab = comis.id_comision;
               comisiones co = en.comisiones.Where(comi => comi.id_comision== variab).First();
                string descripcion = co.desc_comision;
                int key1 = co.id_comision;
                c.Add(descripcion, key1);
                this.comboComision.Items.Add(descripcion).ToString();
            }
            var varia = en.materias;
            foreach (var ma in varia)//materias
            {
                var variab = ma.id_materia;
                materias m = en.materias.Where(materi => materi.id_materia == variab).First();
                string descripcion = m.desc_materia;
                int key2 = m.id_plan;
                mate.Add(descripcion,key2);
                this.ComboMateria.Items.Add(descripcion).ToString();
            }

        
        
        }
        public void limpiacampos() 
        {
            txtanio.Clear();
            txtCupo.Clear();
            
        }
        private void cursos1_Load(object sender, EventArgs e)
        {

        }
    }
}
