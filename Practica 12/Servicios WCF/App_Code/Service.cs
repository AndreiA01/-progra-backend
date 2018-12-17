using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Aceso;
using Logica;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "Service" en el código, en svc y en el archivo de configuración a la vez.
public class Service : IService
{
    Serializador logica = new Serializador();
    public List<personas> Seleccionar()
    {
        return logica.SeleccionarTodas();
    }

    public bool Actualizar(personas datos)
    {
        return logica.ActualizarPersona(datos);
    }

    public bool Eliminar(personas datos)
    {
        return logica.EliminarPersona(datos);
    }

    public personas Insertar(personas datos)
    {
        return logica.InsertarPersona(datos);
    }
}
