﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPNETWebApplication.ImageServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ImageServiceReference.IImageService")]
    public interface IImageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/GetCustomerImageLarge", ReplyAction="http://tempuri.org/IImageService/GetCustomerImageLargeResponse")]
        System.IO.Stream GetCustomerImageLarge(string customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/GetCustomerImageSmall", ReplyAction="http://tempuri.org/IImageService/GetCustomerImageSmallResponse")]
        System.IO.Stream GetCustomerImageSmall(string customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/GetProductImage", ReplyAction="http://tempuri.org/IImageService/GetProductImageResponse")]
        System.IO.Stream GetProductImage(string productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IImageServiceChannel : ASPNETWebApplication.ImageServiceReference.IImageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImageServiceClient : System.ServiceModel.ClientBase<ASPNETWebApplication.ImageServiceReference.IImageService>, ASPNETWebApplication.ImageServiceReference.IImageService {
        
        public ImageServiceClient() {
        }
        
        public ImageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.IO.Stream GetCustomerImageLarge(string customerId) {
            return base.Channel.GetCustomerImageLarge(customerId);
        }
        
        public System.IO.Stream GetCustomerImageSmall(string customerId) {
            return base.Channel.GetCustomerImageSmall(customerId);
        }
        
        public System.IO.Stream GetProductImage(string productId) {
            return base.Channel.GetProductImage(productId);
        }
    }
}
