using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //int localPort;
            //String remoteAddress;
            //int remotePort;
            //while (true)
            //{
            //    Console.WriteLine("Local Port to listener: ");
            //    if (Int32.TryParse(Console.ReadLine().Trim(), out localPort) && localPort < 65535 && localPort > 1024)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Failed to parse local port, it must be a number less than 65535");
            //}
            //Console.WriteLine("Remote Address to forward: ");
            //remoteAddress = Console.ReadLine().Trim();
            //while (true)
            //{
            //    Console.WriteLine("Remote Port to forward: ");
            //    if (Int32.TryParse(Console.ReadLine().Trim(), out remotePort) && remotePort < 65535 && remotePort > 1024)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Failed to parse Remote port, it must be a number less than 65535");
            //}
            Console.WriteLine("Start forwarding [localhost:7612 => 10.172.140.229:7519] ...");
            new UdpForward().Start(7612, "10.172.140.229", 7519);
        }
    }
}
