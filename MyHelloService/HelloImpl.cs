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
    [ServiceBehavior(Namespace = "urn:www-infosupport-com:KC:Demos",InstanceContextMode = InstanceContextMode.PerCall)]

    public class HelloImpl : IHello
    {
        //        [WebGet(UriTemplate="/{prompt}/{overig}",ResponseFormat = WebMessageFormat.Json)]
        
        public string SayHello(string prompt)
        {
            string ret = string.Format($"Hello: {prompt}");
            Console.WriteLine(ret);
            return ret;
        }


    }
}
