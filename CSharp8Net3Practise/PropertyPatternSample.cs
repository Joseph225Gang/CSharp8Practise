using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Net3Practise
{
    internal class Employee
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Region { get; set; }
        public Employee ReportTo { get; set; }
    }

    public static class PropertyPatternSample
    {
        public static bool IsUsBasedWithUkManager(object o)
        {
            return o is Employee e &&
                   e is { Region: "US", ReportTo: { Region: "UK" } };
        }
    }
}
