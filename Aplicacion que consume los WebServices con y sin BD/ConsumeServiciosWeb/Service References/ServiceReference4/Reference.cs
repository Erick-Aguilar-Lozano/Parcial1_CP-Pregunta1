﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace $safeprojectname$.ServiceReference4 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webserviceconbd.mycompany.com/", ConfigurationName="ServiceReference4.webServiceJAVA")]
    public interface webServiceJAVA {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento name del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://webserviceconbd.mycompany.com/webServiceJAVA/helloRequest", ReplyAction="http://webserviceconbd.mycompany.com/webServiceJAVA/helloResponse")]
        $safeprojectname$.ServiceReference4.helloResponse hello($safeprojectname$.ServiceReference4.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webserviceconbd.mycompany.com/webServiceJAVA/helloRequest", ReplyAction="http://webserviceconbd.mycompany.com/webServiceJAVA/helloResponse")]
        System.Threading.Tasks.Task<$safeprojectname$.ServiceReference4.helloResponse> helloAsync($safeprojectname$.ServiceReference4.helloRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento return del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://webserviceconbd.mycompany.com/webServiceJAVA/retornaUsuarioRequest", ReplyAction="http://webserviceconbd.mycompany.com/webServiceJAVA/retornaUsuarioResponse")]
        $safeprojectname$.ServiceReference4.retornaUsuarioResponse retornaUsuario($safeprojectname$.ServiceReference4.retornaUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webserviceconbd.mycompany.com/webServiceJAVA/retornaUsuarioRequest", ReplyAction="http://webserviceconbd.mycompany.com/webServiceJAVA/retornaUsuarioResponse")]
        System.Threading.Tasks.Task<$safeprojectname$.ServiceReference4.retornaUsuarioResponse> retornaUsuarioAsync($safeprojectname$.ServiceReference4.retornaUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hello", Namespace="http://webserviceconbd.mycompany.com/", Order=0)]
        public $safeprojectname$.ServiceReference4.helloRequestBody Body;
        
        public helloRequest() {
        }
        
        public helloRequest($safeprojectname$.ServiceReference4.helloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public helloRequestBody() {
        }
        
        public helloRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="helloResponse", Namespace="http://webserviceconbd.mycompany.com/", Order=0)]
        public $safeprojectname$.ServiceReference4.helloResponseBody Body;
        
        public helloResponse() {
        }
        
        public helloResponse($safeprojectname$.ServiceReference4.helloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public helloResponseBody() {
        }
        
        public helloResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class retornaUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="retornaUsuario", Namespace="http://webserviceconbd.mycompany.com/", Order=0)]
        public $safeprojectname$.ServiceReference4.retornaUsuarioRequestBody Body;
        
        public retornaUsuarioRequest() {
        }
        
        public retornaUsuarioRequest($safeprojectname$.ServiceReference4.retornaUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class retornaUsuarioRequestBody {
        
        public retornaUsuarioRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class retornaUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="retornaUsuarioResponse", Namespace="http://webserviceconbd.mycompany.com/", Order=0)]
        public $safeprojectname$.ServiceReference4.retornaUsuarioResponseBody Body;
        
        public retornaUsuarioResponse() {
        }
        
        public retornaUsuarioResponse($safeprojectname$.ServiceReference4.retornaUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class retornaUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public retornaUsuarioResponseBody() {
        }
        
        public retornaUsuarioResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface webServiceJAVAChannel : $safeprojectname$.ServiceReference4.webServiceJAVA, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class webServiceJAVAClient : System.ServiceModel.ClientBase<$safeprojectname$.ServiceReference4.webServiceJAVA>, $safeprojectname$.ServiceReference4.webServiceJAVA {
        
        public webServiceJAVAClient() {
        }
        
        public webServiceJAVAClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public webServiceJAVAClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public webServiceJAVAClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public webServiceJAVAClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        $safeprojectname$.ServiceReference4.helloResponse $safeprojectname$.ServiceReference4.webServiceJAVA.hello($safeprojectname$.ServiceReference4.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            $safeprojectname$.ServiceReference4.helloRequest inValue = new $safeprojectname$.ServiceReference4.helloRequest();
            inValue.Body = new $safeprojectname$.ServiceReference4.helloRequestBody();
            inValue.Body.name = name;
            $safeprojectname$.ServiceReference4.helloResponse retVal = (($safeprojectname$.ServiceReference4.webServiceJAVA)(this)).hello(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<$safeprojectname$.ServiceReference4.helloResponse> $safeprojectname$.ServiceReference4.webServiceJAVA.helloAsync($safeprojectname$.ServiceReference4.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<$safeprojectname$.ServiceReference4.helloResponse> helloAsync(string name) {
            $safeprojectname$.ServiceReference4.helloRequest inValue = new $safeprojectname$.ServiceReference4.helloRequest();
            inValue.Body = new $safeprojectname$.ServiceReference4.helloRequestBody();
            inValue.Body.name = name;
            return (($safeprojectname$.ServiceReference4.webServiceJAVA)(this)).helloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        $safeprojectname$.ServiceReference4.retornaUsuarioResponse $safeprojectname$.ServiceReference4.webServiceJAVA.retornaUsuario($safeprojectname$.ServiceReference4.retornaUsuarioRequest request) {
            return base.Channel.retornaUsuario(request);
        }
        
        public string retornaUsuario() {
            $safeprojectname$.ServiceReference4.retornaUsuarioRequest inValue = new $safeprojectname$.ServiceReference4.retornaUsuarioRequest();
            inValue.Body = new $safeprojectname$.ServiceReference4.retornaUsuarioRequestBody();
            $safeprojectname$.ServiceReference4.retornaUsuarioResponse retVal = (($safeprojectname$.ServiceReference4.webServiceJAVA)(this)).retornaUsuario(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<$safeprojectname$.ServiceReference4.retornaUsuarioResponse> $safeprojectname$.ServiceReference4.webServiceJAVA.retornaUsuarioAsync($safeprojectname$.ServiceReference4.retornaUsuarioRequest request) {
            return base.Channel.retornaUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<$safeprojectname$.ServiceReference4.retornaUsuarioResponse> retornaUsuarioAsync() {
            $safeprojectname$.ServiceReference4.retornaUsuarioRequest inValue = new $safeprojectname$.ServiceReference4.retornaUsuarioRequest();
            inValue.Body = new $safeprojectname$.ServiceReference4.retornaUsuarioRequestBody();
            return (($safeprojectname$.ServiceReference4.webServiceJAVA)(this)).retornaUsuarioAsync(inValue);
        }
    }
}