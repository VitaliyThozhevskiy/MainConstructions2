using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCource.MainConstructions2
{
    public static class OptionalAndNamedParams
    {
        public static void EnterLogData(string message, string owner)
        {
            Console.Beep();
            Console.WriteLine("Error: { 0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

        //error
        //public static void EnterLogData(string message, string owner = "Programmer", DateTime timestamp = DateTime.Now)
        //{
        //    Console.Beep();
        //    Console.WriteLine("Error: {0}", message);
        //    Console.WriteLine("Owner of Error: {0}", owner);
        //    Console.WriteLine("Time of Error: {0}", timestamp);
        //}
    }
}
