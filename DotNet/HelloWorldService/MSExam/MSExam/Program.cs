using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSExam
{
    class Program
    {

        public bool isJumbledNumber(int number)
        {
            while (number % 10 != 0 && number.ToString().Length > 1)
            {
                int digit1 = number % 10; // first digit in reverse order
                int digit2 = (number / 10) % 10; // (n/10) gives previous digit
                if (Math.Abs(digit2 - digit1) > 1 && digit2 != 0)
                    return false;
                number /= 10;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string unicodeString = "This is text a unicode text.";

            // Create two different encodings.
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            Random rnd = new Random();
            rnd.Next(unicodeString.Length);           
            

            // Convert the string into a byte array.
            byte[] unicodeBytes = unicode.GetBytes(unicodeString);

            // Perform the conversion from one encoding to the other.
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            // Convert the new byte[] into a char[] and then into a string.
            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];

            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);

            // Display the strings created before and after the conversion.
            Console.WriteLine("Original string: {0}", unicodeString);
            Console.WriteLine("Ascii converted string: {0}", asciiString);

            



            Program obj = new Program();
            Console.WriteLine(obj.isJumbledNumber(125323));

            foreach (int i in obj.GetIntArray(12534))
            {
                Console.WriteLine(i);
            }



            Console.ReadLine();
        }

        public bool findJumble(int num)
        {
            bool result = false;

            num = 1232;

            string s = num.ToString();


            return result;
        }

        public int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();



            return listOfInts.ToArray();
        }

    }



}
