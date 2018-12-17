using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Acceso;
using Logica;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "Servicio" en el código, en svc y en el archivo de configuración a la vez.
public class Servicio : IServicio
{
    Parseo logica = new Parseo();
    public List<computadoras> Seleccionar()
    {
        return logica.SeleccionarTodas();
    }

    public bool Actualizar(computadoras datos)
    {
        return logica.ActualizarComputador(datos);
    }

    public bool Eliminar(computadoras datos)
    {
        return logica.EliminarCompu(datos);
    }

    public computadoras Insertar(computadoras datos)
    {
        return logica.InsertarComputador(datos);
    }
}
