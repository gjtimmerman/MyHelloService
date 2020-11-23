using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyHelloService
{
    public class HelloImpl : IHello
    {
        public string SayHello(string prompt)
        {
            string ret = string.Format($"Hello: {prompt}");
            Console.WriteLine(ret);
            return ret;
        }


    }
}
