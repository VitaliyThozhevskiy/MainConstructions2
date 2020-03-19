using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCource.MainConstructions2
{
    public static class MethodsOverloading
    {
        public static int Add(int x, int y)
        {
            return Add();
            //local function
            int Add() { return x + y; }
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static long Add(long x, long y)
        {
            return x + y;
        }
    }
}