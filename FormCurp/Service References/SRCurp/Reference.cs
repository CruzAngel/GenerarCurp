﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18034
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormCurp.SRCurp {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRCurp.DatosCurpSoap")]
    public interface DatosCurpSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento apellidopa del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CurpImp", ReplyAction="*")]
        FormCurp.SRCurp.CurpImpResponse CurpImp(FormCurp.SRCurp.CurpImpRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CurpImp", ReplyAction="*")]
        System.Threading.Tasks.Task<FormCurp.SRCurp.CurpImpResponse> CurpImpAsync(FormCurp.SRCurp.CurpImpRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurpImpRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurpImp", Namespace="http://tempuri.org/", Order=0)]
        public FormCurp.SRCurp.CurpImpRequestBody Body;
        
        public CurpImpRequest() {
        }
        
        public CurpImpRequest(FormCurp.SRCurp.CurpImpRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CurpImpRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string apellidopa;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string apellidoma;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string nombres;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ano;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string mes;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string dia;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string sexo;
        
        public CurpImpRequestBody() {
        }
        
        public CurpImpRequestBody(string apellidopa, string apellidoma, string nombres, string ano, string mes, string dia, string sexo) {
            this.apellidopa = apellidopa;
            this.apellidoma = apellidoma;
            this.nombres = nombres;
            this.ano = ano;
            this.mes = mes;
            this.dia = dia;
            this.sexo = sexo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurpImpResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurpImpResponse", Namespace="http://tempuri.org/", Order=0)]
        public FormCurp.SRCurp.CurpImpResponseBody Body;
        
        public CurpImpResponse() {
        }
        
        public CurpImpResponse(FormCurp.SRCurp.CurpImpResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CurpImpResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CurpImpResult;
        
        public CurpImpResponseBody() {
        }
        
        public CurpImpResponseBody(string CurpImpResult) {
            this.CurpImpResult = CurpImpResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DatosCurpSoapChannel : FormCurp.SRCurp.DatosCurpSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DatosCurpSoapClient : System.ServiceModel.ClientBase<FormCurp.SRCurp.DatosCurpSoap>, FormCurp.SRCurp.DatosCurpSoap {
        
        public DatosCurpSoapClient() {
        }
        
        public DatosCurpSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DatosCurpSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatosCurpSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatosCurpSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FormCurp.SRCurp.CurpImpResponse FormCurp.SRCurp.DatosCurpSoap.CurpImp(FormCurp.SRCurp.CurpImpRequest request) {
            return base.Channel.CurpImp(request);
        }
        
        public string CurpImp(string apellidopa, string apellidoma, string nombres, string ano, string mes, string dia, string sexo) {
            FormCurp.SRCurp.CurpImpRequest inValue = new FormCurp.SRCurp.CurpImpRequest();
            inValue.Body = new FormCurp.SRCurp.CurpImpRequestBody();
            inValue.Body.apellidopa = apellidopa;
            inValue.Body.apellidoma = apellidoma;
            inValue.Body.nombres = nombres;
            inValue.Body.ano = ano;
            inValue.Body.mes = mes;
            inValue.Body.dia = dia;
            inValue.Body.sexo = sexo;
            FormCurp.SRCurp.CurpImpResponse retVal = ((FormCurp.SRCurp.DatosCurpSoap)(this)).CurpImp(inValue);
            return retVal.Body.CurpImpResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FormCurp.SRCurp.CurpImpResponse> FormCurp.SRCurp.DatosCurpSoap.CurpImpAsync(FormCurp.SRCurp.CurpImpRequest request) {
            return base.Channel.CurpImpAsync(request);
        }
        
        public System.Threading.Tasks.Task<FormCurp.SRCurp.CurpImpResponse> CurpImpAsync(string apellidopa, string apellidoma, string nombres, string ano, string mes, string dia, string sexo) {
            FormCurp.SRCurp.CurpImpRequest inValue = new FormCurp.SRCurp.CurpImpRequest();
            inValue.Body = new FormCurp.SRCurp.CurpImpRequestBody();
            inValue.Body.apellidopa = apellidopa;
            inValue.Body.apellidoma = apellidoma;
            inValue.Body.nombres = nombres;
            inValue.Body.ano = ano;
            inValue.Body.mes = mes;
            inValue.Body.dia = dia;
            inValue.Body.sexo = sexo;
            return ((FormCurp.SRCurp.DatosCurpSoap)(this)).CurpImpAsync(inValue);
        }
    }
}
