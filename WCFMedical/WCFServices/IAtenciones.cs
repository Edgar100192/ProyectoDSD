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
    [ServiceContract]
    public interface IAtenciones
    {
        [FaultContract(typeof(RepetidoException))]

        [OperationContract]
        Atencion CrearAtencion(Atencion atencionACrear);

        [OperationContract]
        Atencion ObtenerAtencion(int NunAtencion);

        [OperationContract]
        Atencion ModificarAtencion(Atencion atencionAModificar);

        [OperationContract]
        void EliminarAtencion(int NunAtencion);

        [OperationContract]
        List<Atencion> ListarAtenciones();

    }
}