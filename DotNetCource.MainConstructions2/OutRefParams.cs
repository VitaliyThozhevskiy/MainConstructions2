using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCource.MainConstructions2
{
    public static class OutRefParams
    {
        public static int Add(int x, int y)
        {
            int ans = x + y;
            return ans;
        }
        public static int Set(ref int x)
        {
            x = 10;
            return x;
        }
        public static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        public static void SwapStrings(ref string si, ref string s2)
        {
            string tempStr = si;
            si = s2;
            s2 = tempStr;
        }

        public static ref string SampleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }

        public static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;

            if (values.Length == 0)
                return sum;

            for (int i = 0; i < values.Length; i++)
                sum += values[i];

            return (sum / values.Length);
        }

        public static void UseAdd()
        {
            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
        }
    }
}
