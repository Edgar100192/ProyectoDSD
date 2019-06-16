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
    public class Atenciones : IAtenciones
    {
        private AtencionDAO AtencionDAO = new AtencionDAO();
        public Atencion CrearAtencion(Atencion atencionACrear)
        {
            if (AtencionDAO.Obtener(atencionACrear.NunAtencion) != null) // Ya existe
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        Codigo = "101",
                        Descripcion = "La atencion ya existe"
                    },
                    new FaultReason("Error al intentar creación"));
            }
            return AtencionDAO.Crear(atencionACrear);
        }

        public Atencion ObtenerAtencion(int NunAtencion)
        {
            return AtencionDAO.Obtener(NunAtencion);
        }

        public Atencion ModificarAtencion(Atencion atencionAModificar)
        {
            return AtencionDAO.Modificar(atencionAModificar);
        }

        public void EliminarAtencion(int NunAtencion)
        {
            AtencionDAO.Eliminar(NunAtencion);
        }
        public List<Atencion> ListarAtenciones()
        {
            return AtencionDAO.Listar();
        }

    }
}
