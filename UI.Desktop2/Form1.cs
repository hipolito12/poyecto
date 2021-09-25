using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace UI.Desktop2
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();

            list.Add("hola");
            list.Add("mundo");
            combo.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tat a = new tat();
         //   combo.DataSource = "hola mundo";
            //MessageBox.Show(combo.Text);
            a.kikint();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
    }
}
