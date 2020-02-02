using System;
using System.Collections.Generic;
using System.Text;

namespace OtherLanguageSample
{
    class StaticLocalDemo
    {
        private string Field = "initial-value";
        public void Run()
        {
            var state = "42";
            DoSomethingWithState();
            DoSomethingWithField();

            Console.WriteLine($"state: {state}");
            Console.WriteLine($"Field: {Field}");

            string DoSomethingWithState()
            {
                return state = "99";
            }

            string DoSomethingWithField()
            {
                return Field = "modified!";
            }
        }
    }
}
