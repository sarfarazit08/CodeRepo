using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            
            int count = obj.GetCountOfNonConsecutiveOnes();

           List<string> lst =  obj.SortList(new List<string>()
            {
                "Sarfaraz", "Murari", "Abbas", "Chandu", "Suman"
            });

            double val = obj.value("Indian Rupee", "British Pound");


         }

        public void encodetoAscii(string unicodeString)
        {
            byte[] unicodeBytes = unicode.GetBytes(unicodeString); 
            // Perform the conversion from one encoding to the other. byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes); 
        }

        public double value(string cur1, string cur2)
        {
            double c1 = 0.0;
            double c2 = 0.0;
            Dictionary<string, double> DicObj = new Dictionary<string, double>();
            DicObj.Add("British Pound", 0.76);
            DicObj.Add("Indian Rupee", 67.98);
            DicObj.Add("Singapore Dollar", 1.36);
            DicObj.Add("Japanese Yen", 101.61);
            DicObj.Add("Chinese Yuan", 6.67);
            DicObj.Add("German Mark", 1.72);
            DicObj.Add("US Dollar", 1.00);

            if (DicObj.ContainsKey(cur1))
            {
                c1 = DicObj[cur1];
            }
            if (DicObj.ContainsKey(cur2))
            {
                c2 = DicObj[cur2];
            }

            return (c2 / c1);
        }

        //GetCountOfNonConsecutiveOnes accepts an integer array as parameter and returns the count of number that doesn't contain
        //consecutive 1
        public int GetCountOfNonConsecutiveOnes()
        {
            int[] num = { 12311, 12342, 23114, 123111, 23115611 };
            int count = 0;
            //iterating through the sequence
            foreach (int i in num)
            {

                //Converting the integer to string and then checking if the string contains two 1s in a row
                string s = i.ToString();
                bool res = s.Contains("11");

                //Incrementing the count when condition doesn't match
                if (res == false)
                    count++;
            }
            return count;
        }

        // Method SortList that returns void and accepts a List of string as input Parameter
        public List<string> SortList(List<string> objList)
        {
             

            int counter = 1;

            while (counter < objList.Count)
            {
                //Using compare function of string that returns 1 when first string comes before second string, returns 0 when strings are same and returns -1 when first string 
                //string comes after second string
                //When Compare function is returning 1 then incrementing the counter by 1.
                if (String.Compare(objList[counter], objList[counter - 1], StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    counter++;
                }
                else
                {
                    //When first string comes before second string then swaping the strings by making use of a local temp variable
                    string temp = objList[counter];

                    objList[counter] = objList[counter - 1];

                    objList[counter - 1] = temp;

                    //when counter is greater than 1 then decrementing it by 1.
                    if (counter > 1)
                    {
                        counter--;
                    }
                }
            }
            return objList;
        }
    }
}
