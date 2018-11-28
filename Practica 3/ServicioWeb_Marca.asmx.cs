using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoADatos;
using Logica;

namespace ServiciosWeb
{
    /// <summary>
    /// Descripción breve de ServicioWeb_Marca
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb_Marca : System.Web.Services.WebService
    {

        Logica_Marca logica = new Logica_Marca();

        [WebMethod]
        public List<marca> SeleccionarMarcas() => logica.SeleccionarMarcas();

        [WebMethod]
        public List<marca> SeleccionarMarcasModelos() => logica.SeleccionarMarcaModelos();
        [WebMethod]
        public List<marca> SeleccionarMarcaModelosLinq() => logica.SeleccionarMarcaModelosLinq();
        [WebMethod]
        public DTO_Marca SeleccionarMarcaModelosID_DTO(int idMarca) => logica.SeleccionarMarcaModelosID_DTO(idMarca);

        [WebMethod]
        public marca InsertarMarca(marca nuevo) => logica.InsertarMarca(nuevo);
        [WebMethod]
        public bool ActualizarMarca(marca actualizar) => logica.ActualizarMarca(actualizar);
        [WebMethod]
        public bool EliminarMarca(marca eliminar) => logica.EliminarMarca(eliminar);
    }
}
