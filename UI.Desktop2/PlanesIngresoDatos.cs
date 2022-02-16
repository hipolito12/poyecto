using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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

            try
            {
                if (richdescripcion.Text != "" && Regex.IsMatch(richdescripcion.Text, "[a-z,A-Z,0-9]{10,500}"))
                {
                    if (estado == true)
                    {
                        try
                        {
                            int idespecialidad = Pl.cargargarcombos()[comboespecialdad.Text];
                            Pl.agregarplan(richdescripcion.Text, idespecialidad.ToString());
                            _Plan_ planform = new _Plan_();
                            planform.dataGridView1.Refresh();
                        }
                        catch (Exception ex) { MessageBox.Show("Ha ocurrido un error, verifique los campos y los datos"); }
                    }
                    if (estado == false)
                    {
                        try
                        {
                            int idespecialidad = Pl.cargargarcombos()[comboespecialdad.Text];
                            Pl.editplan(idedit, richdescripcion.Text, idespecialidad.ToString());

                            this.Close();

                        }
                        catch (Exception exe) { MessageBox.Show("Ha ocurrido un error, verifique los campos y los datos"); }
                    }
                    else
                    {
                        MessageBox.Show("campos vacios, verifiquelos");

                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, intente nuevamente!");
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
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error, verifique los campos y los datos"); }
        }

        private void PlanesIngresoDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
