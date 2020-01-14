using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Net3Practise
{
    internal class Rectangle
    {
        public int Length { get;}
        public int Width { get;}

        internal Rectangle(int length, int width) => (Length, Width) = (length, width);
    }

    internal class Circle
    {
        public int Radius { get; set; }

        internal Circle(int radius) => Radius = radius;
    }

    internal class SwitchExpressionSample
    {
        internal static string DisplayShapeInfo(object shape) =>
            shape switch
            {
                Rectangle r => r switch
                {
                    _ when r.Length == r.Width => "Square",
                    _ => "",
                },
                Circle c => $"Circle has {c.Radius} radius",
                _ => "unknown"
            };
    }
}
