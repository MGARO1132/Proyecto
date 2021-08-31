using System;

using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsUsuarios
    {
        SqlConnection _SqlConnection = null;//me permite establecer conexion con la BBDD
        SqlCommand _SqlCommand = null;//me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null;//me permite adaptar conjunto de datos SQL;
        string stConexion = string.Empty;//Cadena de conexion

        public clsUsuarios()
        {
            clsConexion obclsConexxion = new clsConexion();
            stConexion = obclsConexxion.getConexion();
        }

        /// <summary>
        /// VALIDAR USUARIO
        /// </summary>
        /// <param name="obclsUsuarios">OBJETO USUARIO</param>
        /// <returns>RETORNA TRUE O FALSE</returns>
        public bool getValidarUsuario(Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarusuario", _SqlConnection);

                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@cLogin", obclsUsuarios.stLogin));
                _SqlCommand.Parameters.Add(new SqlParameter("@cPassword", obclsUsuarios.stPassword));

                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                if (dsConsulta.Tables[0].Rows.Count > 0) return true;
                else return false;

            }
            catch(Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
            
            

        }
    }
}
