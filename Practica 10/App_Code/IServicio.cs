using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Acceso;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicio" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IServicio
{
    [OperationContract]
    List<computadoras> Seleccionar();

    [OperationContract]
    bool Actualizar(computadoras datos);

    [OperationContract]
    bool Eliminar(computadoras datos);

    [OperationContract]
    computadoras Insertar(computadoras datos);

}
