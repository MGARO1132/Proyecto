using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.web.Views.Index
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stEmail = string.Empty;
            if(!IsPostBack)
            {
                if(Request.QueryString["stEmail"]!=null)
                {
                    stEmail = Request.QueryString["stEmail"].ToString();
                }
            }
        }
    }
}