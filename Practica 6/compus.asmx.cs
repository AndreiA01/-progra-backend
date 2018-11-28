using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoADatos;
using Logica;

namespace WEB
{
    /// <summary>
    /// Descripción breve de compus
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class compus : System.Web.Services.WebService
    {
        Logica_Compus logica = new Logica_Compus();

        [WebMethod]
        public List<computadoras> SeleccionarCompusMantenimientos() => logica.SeleccionarCompusMantenimiento();
    }
}
