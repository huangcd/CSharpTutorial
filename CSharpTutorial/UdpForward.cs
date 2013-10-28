using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class UdpForward
    {
        public void Start(int localPort, String rawRemoteAddress, int remotePort)
        {
            var listener = new UdpClient(localPort);
            var localEndPoint = new IPEndPoint(IPAddress.Any, localPort);
            var remoteAddress = Dns.GetHostAddresses(rawRemoteAddress).First(addr => addr.AddressFamily == AddressFamily.InterNetwork);
            var remoteEndPoint = new IPEndPoint(remoteAddress, remotePort);
            var remoteSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            while (true)
            {
                try
                {
                    var bytes = listener.Receive(ref localEndPoint);
                    var byteSend = remoteSocket.SendTo(bytes, remoteEndPoint);
                    Console.WriteLine(String.Format("{1}\tBytes receive: {0:40}\tTotal bytes send: {2}", String.Join(",", bytes.Select(b => b.ToString("X"))), DateTime.Now, byteSend));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
