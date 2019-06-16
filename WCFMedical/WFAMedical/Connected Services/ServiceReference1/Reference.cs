﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFAMedical.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMedicos")]
    public interface IMedicos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicos/CrearMedico", ReplyAction="http://tempuri.org/IMedicos/CrearMedicoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFServices.Errores.RepetidoException), Action="http://tempuri.org/IMedicos/CrearMedicoRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WCFServices.Errores")]
        WCFServices.Dominio.Medico CrearMedico(WCFServices.Dominio.Medico medicoACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicos/CrearMedico", ReplyAction="http://tempuri.org/IMedicos/CrearMedicoResponse")]
        System.Threading.Tasks.Task<WCFServices.Dominio.Medico> CrearMedicoAsync(WCFServices.Dominio.Medico medicoACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicos/ObtenerMedico", ReplyAction="http://tempuri.org/IMedicos/ObtenerMedicoResponse")]
        WCFServices.Dominio.Medico ObtenerMedico(int dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicos/ObtenerMedico", ReplyAction="http://tempuri.org/IMedicos/ObtenerMedicoResponse")]
        System.Threading.Tasks.Task<WCFServices.Dominio.Medico> ObtenerMedicoAsync(int dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicos/ListarMedicos", ReplyAction="http://tempuri.org/IMedicos/ListarMedicosResponse")]
        WCFServices.Dominio.Medico[] ListarMedicos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicos/ListarMedicos", ReplyAction="http://tempuri.org/IMedicos/ListarMedicosResponse")]
        System.Threading.Tasks.Task<WCFServices.Dominio.Medico[]> ListarMedicosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMedicosChannel : WFAMedical.ServiceReference1.IMedicos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MedicosClient : System.ServiceModel.ClientBase<WFAMedical.ServiceReference1.IMedicos>, WFAMedical.ServiceReference1.IMedicos {
        
        public MedicosClient() {
        }
        
        public MedicosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MedicosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MedicosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MedicosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFServices.Dominio.Medico CrearMedico(WCFServices.Dominio.Medico medicoACrear) {
            return base.Channel.CrearMedico(medicoACrear);
        }
        
        public System.Threading.Tasks.Task<WCFServices.Dominio.Medico> CrearMedicoAsync(WCFServices.Dominio.Medico medicoACrear) {
            return base.Channel.CrearMedicoAsync(medicoACrear);
        }
        
        public WCFServices.Dominio.Medico ObtenerMedico(int dni) {
            return base.Channel.ObtenerMedico(dni);
        }
        
        public System.Threading.Tasks.Task<WCFServices.Dominio.Medico> ObtenerMedicoAsync(int dni) {
            return base.Channel.ObtenerMedicoAsync(dni);
        }
        
        public WCFServices.Dominio.Medico[] ListarMedicos() {
            return base.Channel.ListarMedicos();
        }
        
        public System.Threading.Tasks.Task<WCFServices.Dominio.Medico[]> ListarMedicosAsync() {
            return base.Channel.ListarMedicosAsync();
        }
    }
}