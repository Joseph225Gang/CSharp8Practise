using System;
using System.Linq;

namespace CSharp8Net3Practise
{
    /// <summary>
    /// C# 8.0 and .NET Core 3.0
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region Pattern Matching
            DoTupleExpressionDemo();
            DoSwitchExpressionDemo();
            DoPositionPatternSampleDemo();
            DoPropertyPatternDemo();
            #endregion

            #region Indices and Ranges
            var numbers = Enumerable.Range(0, 10).ToArray();
            var copy = numbers[0..^0];
            var allButFirst = numbers[1..];
            var lastItemRange = numbers[^1..];
            var lastItem = numbers[^1];
            var lastThree = numbers[^3];

            Index middle = 4;
            Index threeFromEnd = ^3;
            Range customRange = middle..threeFromEnd;
            var custom = numbers[customRange];

            Console.WriteLine($"numbers: {string.Join(", ", numbers)}");
            Console.WriteLine($"copy: {string.Join(", ", copy)}");
            Console.WriteLine($"allButFirst: {string.Join(", ", allButFirst)}");
            Console.WriteLine($"lastItemRange: {string.Join(", ", lastItemRange)}");
            Console.WriteLine($"lastItem: {lastItem}");
            Console.WriteLine($"lastThree: {string.Join(", ", lastThree)}");
            Console.WriteLine($"customRange: {customRange}");
            Console.WriteLine($"custom: {string.Join(", ", custom)}");
            #endregion

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
