using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        public class respuesta
        {
            public string resultado { get; set; }
            public string errores { get; set; }

            public string ruta { get; set; }
        }

        [WebMethod]
        public respuesta Ejecutar()
        {
            string path = Server.MapPath("");
            /*Process.Start(@path);
            return "Se ha ejecutado correctamente ";
            */
            Process process = new Process();
        
            process.StartInfo.FileName = path+"/actualizar.bat";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WorkingDirectory = path;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();

            respuesta a = new respuesta();
            a.resultado = process.StandardOutput.ReadToEnd();
            a.errores = process.StandardError.ReadToEnd();
            a.ruta = path;
            process.WaitForExit();
        
            return (a);

        }
    }
}
