using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program 
{
    /// <summary>
    /// принимается введённая пользователем строка,
    /// создаётся массив, включающий в себя все пробелы и знаки препинания меж словам
    /// строка разбивается по одному слову и заносится в массив, где каждое 1 слово = 1 элементу массива,
    /// затем создаётся массив, содержащий в себе количество символов, которое включает каждое слово, и выводится
    /// и в конце считается среднее значение массива и выводится в консоль
    /// </summary>    
    public class Calculate
    {
        /// <summary>
        /// создаётся массив символов, который включает в себя все пробелы и знаки препинания между словами
        /// </summary>
        /// <param name="strng"> принимается введённую пользователем строка </param>
        /// <returns> возвращает массив с пробелами и знаками препинания, содержащимся во введённой пользователем строке </returns>        
        public char[] Punctuation(string strng)
        {
            int arraySize = strng.Length;
            char[] punctuation = new char[arraySize];           
            for (int i = 0;i<strng.Length;i++)
            {
                if(char.IsWhiteSpace(strng[i]) || char.IsPunctuation(strng[i]))
                {
                    punctuation[i] = strng[i];
                }
            }                                                             
             return punctuation;
        }
        /// <summary>
        /// разбивает введённую пользователем строку на подстроки по одному слову и заносит это в массив
        /// </summary>
        /// <param name="strng"> принимает введённую пользователем строку </param>
        /// <param name="punctuation"> принимает массив с разделительными знаками, по которым будет делиться строка</param>
        /// <returns> возвращается массив слов </returns>
        public string [] StringWords(string strng, char[] punctuation)
        {
            string[] words = strng.Split(punctuation);                                                                       
            return words;
        } 
        /// <summary>
        /// Создаёт массив, содержащий в себе длину каждого из слов, исключая нулевые значения длины
        /// </summary>
        /// <param name="words"> принимает массив слов </param>
        /// <returns> возвращает массив длин слов </returns>
        public int[] StringLengthWords(string[] words)
        { 
            int lengthWord;
            int[] lengths = new int[words.Length];
            for(int i = 0; i< words.Length;i++)
            {
                if (words[i].Length != 0)
                {
                    lengthWord = words[i].Length;
                    lengths[i] = lengthWord;
                    Console.WriteLine(lengths[i]);
                }                
            }
            return lengths;          
        }
        /// <summary>
        /// Высчитывает среднее значение массива
        /// </summary>
        /// <param name="lengths"> принимает массив длин слов </param>
        /// <returns> возвращает среднее значение массива </returns>
        public double StringAvg(int [] lengths)
        {
            double avg = lengths.Average();
            Console.WriteLine("Среднее количество букв в слове по строке = " + avg);
            return avg;
        }
    }
}
