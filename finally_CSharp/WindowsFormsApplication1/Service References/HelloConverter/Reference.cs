﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.HelloConverter {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://com/", ConfigurationName="HelloConverter.HelloWorld")]
    public interface HelloWorld {
        
        // CODEGEN: Generating message contract since element name arg0 from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://com/HelloWorld/sayHelloWorldFromRequest", ReplyAction="http://com/HelloWorld/sayHelloWorldFromResponse")]
        WindowsFormsApplication1.HelloConverter.sayHelloWorldFromResponse sayHelloWorldFrom(WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://com/HelloWorld/sayHelloWorldFromRequest", ReplyAction="http://com/HelloWorld/sayHelloWorldFromResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.HelloConverter.sayHelloWorldFromResponse> sayHelloWorldFromAsync(WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sayHelloWorldFromRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sayHelloWorldFrom", Namespace="http://com/", Order=0)]
        public WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequestBody Body;
        
        public sayHelloWorldFromRequest() {
        }
        
        public sayHelloWorldFromRequest(WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class sayHelloWorldFromRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string arg0;
        
        public sayHelloWorldFromRequestBody() {
        }
        
        public sayHelloWorldFromRequestBody(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sayHelloWorldFromResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sayHelloWorldFromResponse", Namespace="http://com/", Order=0)]
        public WindowsFormsApplication1.HelloConverter.sayHelloWorldFromResponseBody Body;
        
        public sayHelloWorldFromResponse() {
        }
        
        public sayHelloWorldFromResponse(WindowsFormsApplication1.HelloConverter.sayHelloWorldFromResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class sayHelloWorldFromResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public sayHelloWorldFromResponseBody() {
        }
        
        public sayHelloWorldFromResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HelloWorldChannel : WindowsFormsApplication1.HelloConverter.HelloWorld, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.HelloConverter.HelloWorld>, WindowsFormsApplication1.HelloConverter.HelloWorld {
        
        public HelloWorldClient() {
        }
        
        public HelloWorldClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.HelloConverter.sayHelloWorldFromResponse WindowsFormsApplication1.HelloConverter.HelloWorld.sayHelloWorldFrom(WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequest request) {
            return base.Channel.sayHelloWorldFrom(request);
        }
        
        public string sayHelloWorldFrom(string arg0) {
            WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequest inValue = new WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequest();
            inValue.Body = new WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequestBody();
            inValue.Body.arg0 = arg0;
            WindowsFormsApplication1.HelloConverter.sayHelloWorldFromResponse retVal = ((WindowsFormsApplication1.HelloConverter.HelloWorld)(this)).sayHelloWorldFrom(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication1.HelloConverter.sayHelloWorldFromResponse> WindowsFormsApplication1.HelloConverter.HelloWorld.sayHelloWorldFromAsync(WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequest request) {
            return base.Channel.sayHelloWorldFromAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.HelloConverter.sayHelloWorldFromResponse> sayHelloWorldFromAsync(string arg0) {
            WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequest inValue = new WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequest();
            inValue.Body = new WindowsFormsApplication1.HelloConverter.sayHelloWorldFromRequestBody();
            inValue.Body.arg0 = arg0;
            return ((WindowsFormsApplication1.HelloConverter.HelloWorld)(this)).sayHelloWorldFromAsync(inValue);
        }
    }
}
