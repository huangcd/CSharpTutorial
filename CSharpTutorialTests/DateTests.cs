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
    public class DateTests
    {
        [TestMethod()]
        public void DayPassedTest()
        {
            Assert.AreEqual(0, Date.DayPassed("2011-01-04"));
        }
    }
}
