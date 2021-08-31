using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.web.Controllers
{
    public class LoginController
    {
        /// <summary>
        /// VALIDA USUARIO
        /// </summary>
        /// <param name="objclsUsuarios">USUARIO</param>
        /// <returns>CONFIRMACION</returns>
        public bool getValidarUsuarioController(Logica.Models.clsUsuarios objclsUsuarios)
        {
            try
            {
                Logica.BL.clsUsuarios obclsUsuario = new Logica.BL.clsUsuarios();
                return obclsUsuario.getValidarUsuario(objclsUsuarios);
            }
            catch(Exception ex) { throw ex; }
            finally { }

        }
    }
}