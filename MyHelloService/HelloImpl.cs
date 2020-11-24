using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel;

namespace MyHelloService
{
    [ServiceBehavior(Namespace = "urn:www-infosupport-com:KC:Demos")]

    public class HelloImpl : IHello
    {
        public void SayHello(string prompt)
        {
             string ret = string.Format($"Hello: {prompt}");
            Console.WriteLine(ret);
            //            return ret;
            IHelloBack clientProxy = OperationContext.Current.GetCallbackChannel<IHelloBack>();
            clientProxy.SayHelloBack(ret);
        }


    }
}
