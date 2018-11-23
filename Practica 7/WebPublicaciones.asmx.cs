using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoADatos;
using Logica;


namespace Servicios
{
    /// <summary>
    /// Descripción breve de WebPublicaciones
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPublicaciones : System.Web.Services.WebService
    {

        LogicaPublicaciones logica = new LogicaPublicaciones();


        [WebMethod]
        public List<publicaciones> Publicaciones() => logica.SeleccionarPublicaciones();
    }
}
