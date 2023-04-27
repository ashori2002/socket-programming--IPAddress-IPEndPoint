using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace socket_programming_IPAddress___IPEndPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPAddress testIP = IPAddress.Parse("127.0.0.1");
            int port = 2002;


            Console.WriteLine($"IPAddress: {testIP}");

            IPEndPoint testIPEP =new IPEndPoint(testIP, port);


            Console.WriteLine($"testIPEP: {testIPEP}");
            Console.WriteLine($"testIPEP.Address: {testIPEP.Address}");
            Console.WriteLine($"testIPEP.Port: {testIPEP.Port}");
            Console.WriteLine($"testIPEP.AddressFamily: {testIPEP.AddressFamily}");




            Console.ReadKey();
        }
    }
}
