using System;

using System.Data;

namespace Proyecto.web.Controllers
{
    public class PosiblesClientesController
    {
        /// <summary>
        /// OBTIENE REGISTROS POSIBLES CLIENTES
        /// </summary>
        /// <returns>DATA POSIBLES CLIENTES</returns>
        public DataSet getConsultarPosiblesClientesController()
        {
            
            try
            {
                Logica.BL.clsPosiblesClientes obclsPosiblesClientes = new Logica.BL.clsPosiblesClientes();
                return obclsPosiblesClientes.getConsultarPosibleaClientes();

            }
            catch(Exception ex) { throw ex; }
        }
        /// <summary>
        /// ADMINISTRA POSIBLES CLIENTES
        /// </summary>
        /// <param name="obclsPosiblesClientesModels">OBJETO</param>
        /// <param name="inOpcion">OPCION DE EJECUCION</param>
        /// <returns>MENSAJE DE PROCESO</returns>
        public string setAdministrarPosiblesClientesController(Logica.Models.clsPosiblesClientes obclsPosiblesClientesModels, int inOpcion)
        {
            try
            {
                Logica.BL.clsPosiblesClientes obclsPosiblesClientes = new Logica.BL.clsPosiblesClientes();
                return obclsPosiblesClientes.setAdministrarPosibleaClientes(obclsPosiblesClientesModels,inOpcion);
            }
            catch(Exception ex) { throw ex; }
        }
    }
}