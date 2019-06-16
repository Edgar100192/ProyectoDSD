using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.Dominio;
using WCFServices.Errores;
using WCFServices.Persistencia;

namespace WCFServices
{
    public class Clientes : IClientes
    {
        private ClienteDAO clienteDAO = new ClienteDAO();
        public Cliente CrearCliente(Cliente clienteACrear)
        {
            if (clienteDAO.Obtener(clienteACrear.cod_cliente) != null)
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        Codigo = "101",
                        Descripcion = "Cliente creado"
                    },
                    new FaultReason("Error al crear cliente"));
            }
            return clienteDAO.Crear(clienteACrear);
        }

        public Cliente ObtenerCliente(int cod_cliente)
        {
            return clienteDAO.Obtener(cod_cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return clienteDAO.Listar();
        }
    }
}

