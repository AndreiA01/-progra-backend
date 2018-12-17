using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aceso;
using Datos;

namespace Logica
{
    public class Serializador
    {
        Querys datos = new Querys();

        public List<personas> SeleccionarTodas() => datos.SelecAll();
        public bool ActualizarPersona(personas persona) => datos.Actualizar(persona);
        public bool EliminarPersona(personas persona) => datos.Eliminar(persona);
        public personas InsertarPersona(personas persona) => datos.Insertar(persona);
    }
}
