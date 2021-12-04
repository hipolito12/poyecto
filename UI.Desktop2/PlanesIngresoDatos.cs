using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Desktop2
{
    public partial class PlanesIngresoDatos : Form
    {
        public bool estado;
        public string idedit;
        Dictionary<string, int> posiciones = new Dictionary<string, int>();
        Plan_ Pl = new Plan_();
        public PlanesIngresoDatos()
        {
            InitializeComponent();
            carga_combo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (richdescripcion.Text == null || comboespecialdad.Text == null)
            {
                MessageBox.Show("campos vacios, verifiquelos");
            }
            if (estado == true && richdescripcion.Text != null)
            {
                try
                {
                    int idespecialidad = Pl.cargargarcombos()[comboespecialdad.Text];
                    Pl.agregarplan(richdescripcion.Text, idespecialidad.ToString());
                    _Plan_ planform = new _Plan_();
                    planform.dataGridView1.Refresh();
                }
                catch (Exception ex) { MessageBox.Show($"error:{ex} "); }
            }
            if (estado == false && richdescripcion.Text != null)
            {
                try
                {
                    int idespecialidad = Pl.cargargarcombos()[comboespecialdad.Text];
                    Pl.editplan(idedit, richdescripcion.Text, idespecialidad.ToString());

                    this.Close();

                }
                catch (Exception exe) { MessageBox.Show($"error:{exe} "); }
            }
        }

        private void carga_combo()
        {
            try
            {


                foreach (var k in Pl.cargargarcombos())
                {
                    comboespecialdad.Items.Add(k.Key);

                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex}"); }
        }

        private void PlanesIngresoDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
