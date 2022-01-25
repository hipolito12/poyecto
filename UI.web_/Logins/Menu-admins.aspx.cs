using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.web_.Logins
{
    public partial class Menu_admins : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["niveldeacceso"].Value == null) { Response.Redirect("../Logins/Login.aspx"); }
            }
            else { if (Request.Cookies["niveldeacceso"].Value == null) { Response.Redirect("../Logins/Login.aspx"); } }
            if (Request.Cookies["niveldeacceso"].Value == null) { Response.Redirect("../Logins/Login.aspx"); }
        }

        
    }
}