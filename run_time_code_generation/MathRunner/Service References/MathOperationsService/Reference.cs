// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MathRunner.MathOperationsService {
    
}


[System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org/", ConfigurationName="IMathOperationsService")]
public interface IMathOperationsService {
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathOperationsService/Increment", ReplyAction="http://tempuri.org/IMathOperationsService/IncrementResponse")]
    int Increment(int n);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathOperationsService/Decrement", ReplyAction="http://tempuri.org/IMathOperationsService/DecrementResponse")]
    int Decrement(int n);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathOperationsService/SquareRoot", ReplyAction="http://tempuri.org/IMathOperationsService/SquareRootResponse")]
    double SquareRoot(double x);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathOperationsService/Timeout", ReplyAction="http://tempuri.org/IMathOperationsService/TimeoutResponse")]
    void Timeout(System.TimeSpan time);
}

public interface IMathOperationsServiceChannel : IMathOperationsService, System.ServiceModel.IClientChannel {
}

public class MathOperationsServiceClient : System.ServiceModel.ClientBase<IMathOperationsService>, IMathOperationsService {
    
    public MathOperationsServiceClient() {
    }
    
    public MathOperationsServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName) {
    }
    
    public MathOperationsServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
    }
    
    public MathOperationsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
    }
    
    public MathOperationsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpoint) : 
            base(binding, endpoint) {
    }
    
    public int Increment(int n) {
        return base.Channel.Increment(n);
    }
    
    public int Decrement(int n) {
        return base.Channel.Decrement(n);
    }
    
    public double SquareRoot(double x) {
        return base.Channel.SquareRoot(x);
    }
    
    public void Timeout(System.TimeSpan time) {
        base.Channel.Timeout(time);
    }
}
