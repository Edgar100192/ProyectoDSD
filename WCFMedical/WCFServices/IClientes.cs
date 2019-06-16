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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IClientes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClientes
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Cliente CrearCliente(Cliente clienteACrear);

        [OperationContract]
        Cliente ObtenerCliente(int cod_cliente);

        [OperationContract]
        List<Cliente> ListarClientes();
    }
}
