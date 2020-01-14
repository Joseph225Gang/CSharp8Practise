using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Net3Practise
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        internal Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        internal void Deconstruct(out string firstName, out string lastName)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
        }
    }

    internal static class PositionalPatternSample
    {
        internal static bool IsInSeventhGradeMath(Student s)
        {
            return s is (_,"Math");
        }

    }
}
