using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class AsynchronousDNS
    {
        public String GetHostAsync()
        {
            var buffer = new StringBuilder();

            var address = "localhost";
            var result = Dns.BeginGetHostEntry(
                address,
                r =>
                {
                    buffer.AppendFormat("BeginMethodCallback: State {0}\n", r.AsyncState);
                },
                address);

            buffer.AppendFormat("Main Thread\n");

            // Make the async things sync
            var entry = Dns.EndGetHostEntry(result);
            buffer.AppendFormat("Finish End Method\n");

            // Wait the call back to run
            Thread.Sleep(10);
            return buffer.ToString();
        }
    }
}
