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
    public partial class ReporteAlumnosxComisiones : Form
    {
        public ReporteAlumnosxComisiones()
        {
            InitializeComponent();
        }

        private void ReporteAlumnosxComisiones_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        void cargargridview() 
        {
            Menu_profesores m = new Menu_profesores();

            Menu_profesoressBindingSource.DataSource = m.cargarReporte();

            ReportDataSource rd = new ReportDataSource("AlumnosCurso", m.cargarReporte());
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rd);
            reportViewer2.RefreshReport();
        }
    }
}
