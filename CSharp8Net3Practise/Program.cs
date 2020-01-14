using System;

namespace CSharp8Net3Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTupleExpressionDemo();
            DoSwitchExpressionDemo();
            DoPositionPatternSampleDemo();
            DoPropertyPatternDemo();
            Console.WriteLine("Hello World!");
        }

        static void DoTupleExpressionDemo()
        {
            Console.WriteLine($"{TuplePatternSample.GetColor(Color.Blue, Color.Blue)}");
            Console.WriteLine($"{TuplePatternSample.GetColor(Color.Red, Color.Blue)}");
        }

        static void DoSwitchExpressionDemo()
        {
            var shape = new Rectangle(5, 5);
            Console.WriteLine($"{SwitchExpressionSample.DisplayShapeInfo(shape)}");
        }

        static void DoPositionPatternSampleDemo()
        {
            var student = new Student("Hi", "Math");
            Console.WriteLine($"{PropertyPatternSample.IsUsBasedWithUkManager(student)}");
        }

        static void DoPropertyPatternDemo()
        {
            var ukManager = new Employee
            {
                FristName = "David",
                LastName = "Smith",
                Region = "UK"
            };

            var employee = new Employee
            {
                FristName = "John",
                LastName = "Doe",
                Region = "US",
                ReportTo = ukManager
            };

            var result = PropertyPatternSample.IsUsBasedWithUkManager(employee);

            Console.WriteLine($"{employee.FristName} is US-based with UK-manager? {result}");
        }
    }
}
