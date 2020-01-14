using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Net3Practise
{
    internal  enum Color
    {
        Unknown,
        Red,
        Blue,
        Green,
        Purple,
        Orange,
        Brown,
        Yellow
    }

    internal class TuplePatternSample
    {
        internal static Color GetColor(Color c1, Color c2)
        {
            return (c1, c2) switch
            {
                (Color.Red,Color.Blue) => Color.Purple,
                (Color.Red, Color.Green) => Color.Purple,
                (_,_) when c1 == c2 => c1 
            };
        }
    }
}
