using System;


namespace Bmi
{
    class Program
    {
        
         static void Main()
        {
            BmiCalculator();
        }

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

        private static double ToDouble (string value)
        {
            return double.Parse(value);
        }

        private static string GetValueFromUser (string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();       
        }       
    }
}

