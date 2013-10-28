using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Date
    {
        public static int DayPassed(String rawDate)
        {
            var date = DateTime.Parse(rawDate);
            var today = DateTime.Now;
            var timespan = today - date;
            return (int) timespan.TotalDays;
        }
    }
}
