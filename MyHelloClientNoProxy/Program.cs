using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyHelloClientNoProxy
{
    class Program
    {
        static void Main(string[] args)
        {

            ChannelFactory<MyHelloService.IHello> cf = new ChannelFactory<MyHelloService.IHello>("MyClientConfig");
            MyHelloService.IHello proxy = cf.CreateChannel();
            Console.WriteLine(proxy.SayHello("World!"));
            Console.WriteLine(proxy.SayHello("World!"));
            Console.WriteLine(proxy.SayHello("World!"));
            ((ICommunicationObject)proxy).Close();
          
        }
    }
}
