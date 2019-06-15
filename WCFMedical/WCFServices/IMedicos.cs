﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using WCFServices.Dominio;
using WCFServices.Errores;
using System.ServiceModel.Web;
using System.Data;
using System.Web;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;

namespace WCFServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMedicos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMedicos
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Medico CrearMedico(Medico medicoAcrear);

        [OperationContract]
        Medico ObtenerMedico(int dni);

        [OperationContract]
        List<Medico> ListarMedicos();
    }
}
