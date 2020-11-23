using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyHelloService
{
    [ServiceContract]
    public interface IHello
    {
        [OperationContract]
        string SayHello(string prompt);

    }

}
