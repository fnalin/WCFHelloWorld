using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFHelloWorld.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var proxy = new ServiceReference1.Service1Client())
            {
                Console.WriteLine(proxy.GetData(1999));
            }

            Console.ReadLine();
            
        }
    }
}
