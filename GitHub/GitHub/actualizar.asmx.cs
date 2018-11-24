using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace GitHub
{
    /// <summary>
    /// Descripción breve de actualizar
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class actualizar : System.Web.Services.WebService
    {

        [WebMethod]
        public string Ejecutar()
        {
            Process.Start("d:/Documents/Visual Studio 2015/Projects/GitHub/GitHub/actualizar.bat");
            return "Se ha actualizado Correctamente";
        }
    }
}
