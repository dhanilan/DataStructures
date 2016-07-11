using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// Euclid's algo with O(log N)
    /// </summary>
    public class EuclidsAlgorithm
    {
        public static int GetGCD(int a, int b) {

            var temp = a % b;
            a = b;
            b = temp;

            if (b == 0)
                return a;
            else
                return GetGCD(a, b);
        }

        public static int LCMUsingGCD(int a, int b)
        {
            var gcd = GetGCD(a, b);
            return (a / gcd) * b;
        }
    }
}
