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
namespace UI.Desktop2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try {
                personas p = new personas();
                Entidad en = new Entidad();
                var s = textBox1.Text;
               if( textBox1.Text.Length == 0 || textBox1.Text.Length == null) ;
                personas per = en.personas.Where(pers=> pers.nombre == s).First();
            }
            catch(Exception en)
           
            {
                  
            }
        }
    }
}
