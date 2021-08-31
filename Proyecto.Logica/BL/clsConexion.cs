
using System.Configuration;//Agregado en las referencias

namespace Proyecto.Logica.BL
{
    public class clsConexion
    {
        /// <summary>
        /// OBTIENE CONEXION A LA BASE DE DATOS
        /// </summary>
        /// <returns>RETORNA CADENA DE CONEXION</returns>
        public string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
        }
    }
}
