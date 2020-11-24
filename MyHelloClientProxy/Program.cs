using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyHelloClientProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCallbackClass mcc = new MyCallbackClass();
            MyHelloNamespace.HelloClient hc = new MyHelloNamespace.HelloClient(new InstanceContext(mcc));
            hc.SayHello("World");
            Console.ReadLine();
            hc.Close();
        }
    }
    class MyCallbackClass : MyHelloNamespace.IHelloCallback
    {
        public void SayHelloBack(string result)
        {
            Console.WriteLine(result);
        }
    }
}
