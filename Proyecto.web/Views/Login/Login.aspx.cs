using System;
using System.Web;

namespace Proyecto.web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ctrl + k + c Comentar
            //ctrl + k + u Descomentar

            //Defino objeto con propiedades

            //la primera vez que carga la pagina
            if(!IsPostBack)
            {
                if(Request.Cookies["cookiesEmail"]!=null)
                {
                    txtEmail.Text = Request.Cookies["cookiesEmail"].Value.ToString();
                }
            }
         
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingrese email, ";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "Ingrese Password,";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(',')); //Error controlado

                Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                {
                    stLogin = txtEmail.Text,
                    stPassword = txtPassword.Text
                };


                //Instancio controlador

                Controllers.LoginController obLoginController = new Controllers.LoginController();
                bool blBandera = obLoginController.getValidarUsuarioController(obclsUsuarios);

                if (blBandera)
                {
                    Session["sessionEmail"] = txtEmail.Text;

                    if(chkRecordar.Checked)
                    {
                        //Creo un objeto cookie
                        HttpCookie cookie = new HttpCookie("cookieEmail",txtEmail.Text);
                        //adiciono el tiempo de vida
                        cookie.Expires = DateTime.Now.AddDays(2);
                        //agrego a la coleccion de cookies
                        Response.Cookies.Add(cookie);

                    }
                    else
                    {
                        HttpCookie cookie = new HttpCookie("cookieEmail", txtEmail.Text);
                        //cookie expira en el día de ayer
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookie);
                    }
                    Response.Redirect("../Index/index.aspx?stEmail="+txtEmail.Text);//Redirección
                }
                else
                    throw new Exception("Usuario o password incorrectos ");

            }
            catch (Exception ex)
            {
                
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('error!', '"+ ex.Message+" !', 'error') </script>");
            }

        }
    }
}