using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArray = {5,10,4,20,12,-11};
            int sum = 9;
            printPairs(inputArray, sum);
        }

        private static int MAX = 100; // Max size of Hashmap

        private static void printPairs(int[] inputArray, int sum)
        {
            // Declares and initializes the whole array as false
            bool[] falseArray = new bool[MAX];

            for (int i = 0; i < inputArray.Length; ++i)
            {
                int temp = sum - inputArray[i];

                // checking for condition
                if (temp >= 0 && falseArray[temp])
                {
                    Console.WriteLine("Pair with given sum " + sum + " is (" + inputArray[i] + ", " + temp + ")");
                }
                falseArray[inputArray[i]] = true;
            }
        }

    }
}
