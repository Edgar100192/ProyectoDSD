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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Medicos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Medicos.svc o Medicos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Medicos : IMedicos
    {
        private MedicoDAO medicoDAO = new MedicoDAO();
        public Medico CrearMedico(Medico medicoACrear)
        {
            if (medicoDAO.Obtener(medicoACrear.Dni) !=null) // Ya existe
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        Codigo = "101",
                        Descripcion = "El medico ya existe"
                    },
                    new FaultReason("Error al intentar creación"));
            }
            return medicoDAO.Crear(medicoACrear);
        }

        public Medico ObtenerMedico(int dni)
        {
            return medicoDAO.Obtener(dni);
        }
        
        public List<Medico> ListarMedicos()
        {
            return medicoDAO.Listar();
        }
    }
}
