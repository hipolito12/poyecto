﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.web_.Reportes
{
    public partial class DocentesXcursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnImprimir_Click(object sender, EventArgs e)
        { btnImprimir.Visible = false;
            btnImprimir.Attributes.Add("onclick", "imprime()");

            btnImprimir.Visible = true;

        }
    }
}