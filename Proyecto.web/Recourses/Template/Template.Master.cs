using System;

namespace Proyecto.web.Recourses.Template
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string[] stEmail = null;

                if (Session["sessionEmail"] != null)
                {
                    stEmail = Session["sessionEmail"].ToString().Split('@');
                    lblUsuario.Text = stEmail[0];
                }
                else
                    Response.Redirect("../../Views/Login/Login.aspx");
            }

        }

      

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            //Session.Remove("sessionEmail");//Elimina una variable de session específica
            Session.RemoveAll();//Elimina a todas las variables de session
            Response.Redirect("../../Views/Login/Login.aspx");
        }
    }
}