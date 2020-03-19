using System;

namespace DotNetCource.MainConstructions2
{
    public static class SystemArray
    {
        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            string[] gothicBands = {"Tones on Tail", "Bauhaus", "Sisters of Mercy"};
            Console.WriteLine("->Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine();
        }
    }
}