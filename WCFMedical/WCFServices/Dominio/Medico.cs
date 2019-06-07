using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServices.Dominio
{
    [DataContract]
    public class Medico
    {
        [DataMember]
        public int Dni { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string ApellidoPaterno { get; set; }
        [DataMember]
        public string ApellidoMaterno { get; set; }
        [DataMember]
        public string Sexo { get; set; }
        [DataMember]
        public int Edad { get; set; }
        [DataMember]
        public string Especialidad { get; set; }
        [DataMember]
        public string Correo { get; set; }
    }
}