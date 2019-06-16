using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.Dominio;
using WCFServices.Errores;

namespace WCFServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISolicitudes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISolicitudes
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Solicitud CrearSolicitud(Solicitud SolicitudACrear);
        [OperationContract]
        Solicitud ObtenerSolicitud(int Nu_Solicitud);
        [OperationContract]
        Solicitud ModificarSolicitud(Solicitud SolicitudAModificar);
        [OperationContract]
        void EliminarSolicitud(int Nu_Solicitud);
        [OperationContract]
        List<Solicitud> ListarSolicitudes();
    }
}
