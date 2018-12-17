using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Aceso;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IService" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{
    [OperationContract]
    List<personas> Seleccionar();

    [OperationContract]
    bool Actualizar(personas datos);

    [OperationContract]
    bool Eliminar(personas datos);

    [OperationContract]
    personas Insertar(personas datos);
}
