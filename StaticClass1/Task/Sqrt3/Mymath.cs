using System;

namespace Sqrt3
{
    public static class Mymath
    {
        static public decimal Sqrt3(this int num)
        {
            return (decimal)Math.Pow(num, 0.333333333333333333);
        }
    }
}
