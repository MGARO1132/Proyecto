using System;


namespace Proyecto.web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ctrl + k + c Comentar
            //ctrl + k + u Descomentar

            //Defino objeto con propiedades
         
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
                    Response.Redirect("../Index/index.aspx");//Redirección
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