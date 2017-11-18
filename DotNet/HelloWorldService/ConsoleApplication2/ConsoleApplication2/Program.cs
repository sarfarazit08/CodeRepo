using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public void ReturnValue(int numberFromUser)
        {
            string[] arr = new string[] { "4", "10", "11", "-9", "8", "-6", "5" };
            int pair;
            int index = 0;
            string[] arrToreturn = new string[(arr.Length / 2)];

            for (int i = 0; i < arr.Length; i++)
            {
                pair = Convert.ToInt32(arr[i]);
                for (int j = (i + 1); j < arr.Length; j++)
                {
                    if ((pair + Convert.ToInt32(arr[j]) == numberFromUser))
                    {
                        arrToreturn[index] = "{ " + pair + " " + arr[j] + " }";
                        index++;
                    }
                }
            }

            Console.WriteLine("The possible pairs are");
            for (int y = 0; y < arrToreturn.Length; y++)
            {
                Console.WriteLine(arrToreturn[y]);
            }
        }

        static void Main(string[] args)
        {
            Program prg = new Program();
            Console.WriteLine("Enter a number");
            int numberFromUser = Convert.ToInt32(Console.ReadLine());
            prg.ReturnValue(numberFromUser);
        }
    }
}
