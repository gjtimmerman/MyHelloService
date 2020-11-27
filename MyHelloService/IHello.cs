using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyHelloService
{
    [ServiceContract(Namespace = "urn:www-infosupport-com:KC:Demos",SessionMode = SessionMode.Required)]
    public interface IHello
    {
        [OperationContract]
//        [FaultContract(typeof(HelloFault))]
        string SayHello(string prompt);

    }
    [ServiceContract(Namespace = "urn:www-infosupport-com:KC:Demos")]
    public interface IHelloBack
    {
        [OperationContract(IsOneWay = true)]
        void SayHelloBack(string result);
    }
    [DataContract(Namespace = "urn:www-infosupport-com:KC:Demos")]
    public class HelloFault
    {
        [DataMember]
        public string ErrorMessage { get; set; }
    }

}
