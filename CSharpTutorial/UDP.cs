using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class UDP
    {
        public static void SendViaUDP()
        {
            IPAddress address = IPAddress.Parse("10.172.140.229");
            IPEndPoint endPoint = new IPEndPoint(address, 8001);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            var datas = File.ReadAllLines(@"C:\Users\chhuang\Desktop\messageByte.txt")
                            .Select(line => line.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(str => (byte)((int.Parse(str) + 256) % 256)).ToArray())
                            .ToArray();
                         
            int index = 0;
            while (true)
            {
                Thread.Sleep(1000);
                socket.SendTo(datas[index % datas.Length], endPoint);
                index++;
            }
        }
    }
}
