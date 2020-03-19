using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCource.MainConstructions2
{
    public static class Structs
    {
        public static void Show()
        {
            Point myPoint;
            //myPoint.Display();
            //myPoint.Increment();
            //myPoint.Display();

            //default ctor
            Point pi = new Point();
            pi.Display();
        }

        public static void ValueReferenceDifference()
        {
            Point myPoint;
            PointRef p1 = new PointRef(){X=10, Y=10};
            PointRef p2 = p1;
            p1.Display();
            p2.Display();
            p1.X = 100;
            Console.WriteLine("\n=> Changed pl.X\n");
            p1.Display();
            p2.Display();
        }

    }

    struct Point : IDisposable
    {
        int X;
        int Y;

        public void Increment()
        {
            X++;
            Y++;
        }

        public void Decrement()
        {
            X--;
            Y--;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

        public void Dispose()
        {
            X = 0;
            Y = 0;
        }
    }

    class PointRef
    {
        public int X;
        public int Y;

        public void Increment()
        {
            X++;
            Y++;
        }

        public void Decrement()
        {
            X--;
            Y--;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
}
