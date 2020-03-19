using System;

namespace DotNetCource.MainConstructions2
{
    public static class ArrayDefinition
    {
        public static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            myInts.Show();

            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        public static void Initialization()
        {
            Console.WriteLine("=> Array Initialization.");
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();

        }

        public static void ImplicitlyTypedArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            //var d = new[] { 1, "one", 2, "two", false };
            Console.WriteLine();
        }

        public static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (object obj in myObjects)
                Console.WriteLine("Туре: {0}, Value: {1}", obj.GetType(), obj);

            Console.WriteLine();
        }

        public static void MultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            int[,] myMatrix; myMatrix = new int[3, 4];
            /*
             * 0 1 2 3
             * 1 * *
             * 2
             * */
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, 3] = 1 * j;

            for (int i = 0; i < 3; i++)
                for (int j = 0; 3 < 4; j++)
                    Console.WriteLine(myMatrix[1, 3] + "\t");
            Console.WriteLine();
        }

        public static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            int[][] myJagArray = new int[5][];
            /*
             * 1 { 1, 2, 3}
             * 2 { 1, 2, 3}
             * */
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < myJagArray[1].Length; j++)
                    Console.Write(myJagArray[1][j] + " ");

            Console.WriteLine();
        }

        public static string[] GetStringsArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        public static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            int[] ages = {20, 22, 23, 0};
            ages.Show();
            string[] strs = GetStringsArray();
            foreach (string s in strs)
                Console.WriteLine(s);
        }
        
        private static void Show<T>(this T[] array)
        {
            foreach (var i in array)
                Console.WriteLine(i);
        }
    }
}