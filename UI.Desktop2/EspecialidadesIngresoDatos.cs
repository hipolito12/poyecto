using CapaNegocios;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI.Desktop2
{
    public partial class Especialidades1 : Form

    {
        public bool estado;
        Especialidad es = new Especialidad();
        public string id;
        public Especialidades1()
        {
            InitializeComponent();
        }

        private void richdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (richdescripcion.Text != "" && Regex.IsMatch(richdescripcion.Text, "[a-z,A-Z,0-9]") == true)
            {
                if (estado == true)
                {
                    es.addEspecialidad(richdescripcion.Text);
                    this.Close();
                }

                if (estado == false)
                {

                    es.Editespecialidades(id, richdescripcion.Text);
                    this.Close();
                }
            }
            else 
            {
                MessageBox.Show($"hay campos vacios , verifiquelos");

            }
           
        }

        private void Especialidades1_Load(object sender, EventArgs e)
        {

        }
    }
}
