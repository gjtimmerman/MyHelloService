using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHelloClientProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHelloNamespace.HelloClient hc = new MyHelloNamespace.HelloClient();
            Console.WriteLine(hc.SayHello("World"));
            hc.Close();
        }
    }
}
