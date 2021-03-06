using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsPrioridad
    {
        SqlConnection _SqlConnection = null;//me permite establecer conexion con la BBDD
        SqlCommand _SqlCommand = null;//me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null;//me permite adaptar conjunto de datos SQL;
        string stConexion = string.Empty;//Cadena de conexion

        SqlParameter _sqlParameter = null;

        public clsPrioridad()
        {
            clsConexion obclsConexxion = new clsConexion();
            stConexion = obclsConexxion.getConexion();
        }
        /// <summary>
        /// CONSULTA PRIORIDAD
        /// </summary>
        /// <returns>REGISTROS PRIORIDAD</returns>

        public DataSet getConsultarPrioridad()
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarPrioridad", _SqlConnection);//Nombre del Store Procedure que se encuentra en la BBDD

                _SqlCommand.CommandType = CommandType.StoredProcedure;



                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;

            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }

    }
}
