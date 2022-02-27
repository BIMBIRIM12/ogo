using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   public class AvgString
    {
        static void Main(string[] args)
        {
            StringOperations();
        }

        public static void StringOperations()
        {
            string strng = GetValueFromUser("Please enter suggestion");
            var calculate = new Calculate();
            char [] punctuation = calculate.Punctuation(strng);
            string[] words = calculate.StringWords(strng, punctuation);
            int [] lengths = calculate.StringLengthWords(words);
            var avg = calculate.StringAvg(lengths);
        }
        private static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        
    }
}


