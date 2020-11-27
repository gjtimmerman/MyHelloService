using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Threading;


namespace MyHelloService
{
    [ServiceBehavior(Namespace = "urn:www-infosupport-com:KC:Demos",InstanceContextMode = InstanceContextMode.Single,ConcurrencyMode = ConcurrencyMode.Multiple)]

    public class HelloImpl : IHello
    {
        //        [WebGet(UriTemplate="/{prompt}/{overig}",ResponseFormat = WebMessageFormat.Json)]
        private int n;
        public string SayHello(string prompt)
        {
            Interlocked.Increment(ref n);
            string ret = string.Format($"Hello: {prompt}, {n}");
            Console.WriteLine(ret);
            return ret;
        }


    }
}
