using System;

namespace Bmi
{
    class Program
    {/// <summary>
    /// Выводит в консоль индекс массы тела и его характеристики
    /// </summary>
        
         static void Main()
        {          
            BmiCalculator();
        }
        /// <summary>
        /// Запрашивает у пользователя рост и вес, также вызывает и выводит метод с рассчётом ИМТ и его характеристику в консоль
        /// </summary>
        public static void BmiCalculator()
        {   
            var weight = ToDouble(GetValueFromUser("Введите вес:"));
            var height = ToDouble(GetValueFromUser("Введите рост:"));
            var bmiCalc = new BmiCalc();            
            var bmi = bmiCalc.Calculate(weight, height);
            var description = bmiCalc.GetDescription(bmi);           
            Console.WriteLine(bmi);
            Console.WriteLine(description);
        }
        /// <summary>
        /// Конвертирует принимаемое от пользователя значение в тип Double и возвращет его 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static double ToDouble (string value)
        {
            return double.Parse(value);
        }
        /// <summary>
        /// Запрашивает у пользователя значение роста и веса, и возвращает принятые значения
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static string GetValueFromUser (string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();       
        }       
    }
}

