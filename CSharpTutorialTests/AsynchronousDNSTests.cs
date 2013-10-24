using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTutorial;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpTutorial.Tests
{
    [TestClass()]
    public class AsynchronousDNSTests
    {
        [TestMethod()]
        public void GetHostAsyncTest()
        {
            Assert.AreEqual(
                "Main Thread\nFinish End Method\nBeginMethodCallback: State localhost\n", 
                new AsynchronousDNS().GetHostAsync().ToString());
        }
    }
}
