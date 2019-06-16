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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Solicitudes" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Solicitudes.svc o Solicitudes.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Solicitudes : ISolicitudes
    {
        private SolicitudDAO solicitudDAO = new SolicitudDAO();
        public Solicitud CrearSolicitud(Solicitud SolicitudACrear)
        {
            if ((solicitudDAO.Obtener(SolicitudACrear.co_Cliente) != null))
            {
                throw new FaultException<RepetidoException>(new RepetidoException()
                {
                    Codigo = "101",
                    Descripcion = "El Usuario ya Existe"
                }, new FaultReason("Error"));
            }
            return solicitudDAO.Crear(SolicitudACrear);
        }



        public void EliminarSolicitud(int Nu_Solicitud)
        {
            solicitudDAO.Eliminar(Nu_Solicitud);
        }

        public List<Solicitud> ListarSolicitudes()
        {
            return solicitudDAO.Listar();
        }

        public Solicitud ModificarSolicitud(Solicitud SolicitudAModificar)
        {
            return solicitudDAO.Modificar(SolicitudAModificar);
        }

        public Solicitud ObtenerSolicitud(int Nu_Solicitud)
        {
            return solicitudDAO.Obtener(Nu_Solicitud);
        }
    }
}
