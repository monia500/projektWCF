﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IKalkulator")]
    public interface IKalkulator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKalkulator/dodaj", ReplyAction="http://tempuri.org/IKalkulator/dodajResponse")]
        int dodaj(int wartosc1, int wartosc2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKalkulator/dodaj", ReplyAction="http://tempuri.org/IKalkulator/dodajResponse")]
        System.Threading.Tasks.Task<int> dodajAsync(int wartosc1, int wartosc2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKalkulatorChannel : Klient.ServiceReference1.IKalkulator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KalkulatorClient : System.ServiceModel.ClientBase<Klient.ServiceReference1.IKalkulator>, Klient.ServiceReference1.IKalkulator {
        
        public KalkulatorClient() {
        }
        
        public KalkulatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KalkulatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KalkulatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KalkulatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int dodaj(int wartosc1, int wartosc2) {
            return base.Channel.dodaj(wartosc1, wartosc2);
        }
        
        public System.Threading.Tasks.Task<int> dodajAsync(int wartosc1, int wartosc2) {
            return base.Channel.dodajAsync(wartosc1, wartosc2);
        }
    }
}
