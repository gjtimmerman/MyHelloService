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
            MyCallbackClass mcc = new MyCallbackClass();
            DuplexChannelFactory<MyHelloService.IHello> cf = new DuplexChannelFactory<MyHelloService.IHello>(new InstanceContext(mcc),"MyClientConfig");
            MyHelloService.IHello proxy = cf.CreateChannel();
            proxy.SayHello("World!");
            Console.ReadLine();
            ((ICommunicationObject)proxy).Close();
          
        }
    }
    class MyCallbackClass : MyHelloService.IHelloBack
    {
        public void SayHelloBack(string result)
        {
            Console.WriteLine(result);
        }
    }
}
