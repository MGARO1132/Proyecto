using System;

namespace Proyecto.web.Views.Register
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtNombre.Text)) stMensaje += "Ingrese un nombre, ";
                if (string.IsNullOrEmpty(txtApellido.Text)) stMensaje += "Ingrese su apellido, ";
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingrese email, ";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "Ingrese Password,";
                if (string.IsNullOrEmpty(txtConfrmPassword.Text)) stMensaje += "Confirme su password, ";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(',')); //Error controlado


            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('error!', '" + ex.Message + " !', 'error') </script>");
            }

        }
    }
}