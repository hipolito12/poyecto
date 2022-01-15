using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.web_.Reportes
{
    public partial class reporteMATERIAS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button2.Attributes.Add("onclick", "imprime()");
        }
    }
}