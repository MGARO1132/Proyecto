using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Proyecto.web.Views.Tareas
{
    public partial class Tareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Controllers.TareasController obTareasController = new Controllers.TareasController();
                DataSet dsConsultarEstadoTareas = obTareasController.getConsultarEstadoTareasController();
                DataSet dsConsultarPrioridad = obTareasController.getConsultarPrioridadController();

                //Asigno origen de datos

                ddlEstadoTarea.DataSource = dsConsultarEstadoTareas;
                ddlEstadoTarea.DataTextField = "estaDescripcion";//lo que se muestra
                ddlEstadoTarea.DataValueField = "estaCodigo";//lo que equivale
                ddlEstadoTarea.DataBind();//acepte los cambios


                ddlPrioridad.DataSource = dsConsultarPrioridad;
                ddlPrioridad.DataTextField = "prioDesripcion";//lo que se muestra
                ddlPrioridad.DataValueField = "prioCodigo";//lo que equivale
                ddlPrioridad.DataBind();//acepte los cambios

            }

        }
    }
}