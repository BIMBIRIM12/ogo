using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    public class BmiCalc
    {
        public double Calculate(double weight, double height)
        {
            if (weight > 400 || weight < 10) 
            {
               Console.WriteLine("Вес должен находиться в диапозоне от 5 до 400 кг");              
            }
            if (height < 50 || height > 300) 
            {
                Console.WriteLine("Рост должен быть в диапозоне от 50 до 300 см");                          
            }
            double bmi;
            bmi = (weight * 10000 / Math.Pow(height, 2));
            return bmi;            
        }
       
        public string GetDescription (double bmi)
        {      
           string description;
            if (bmi < 16)
            {
                description = "Выраженный дефицит массы тела";
            }
            else if (bmi >= 16 && bmi <= 18.5)
            {
                description = "Недостаточная масса тела";

            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                description = "Всё в норме";
            }
            else if (bmi >= 25 && bmi <= 30)
            {
                description = "1-ая степень ожирения";
            }
            else if (bmi >= 30 && bmi <= 35)
            {
                description = "2-ая степень ожирения";
            }
            else
            {
                description = "3-ая степень ожирения";

            }           
             return description;         
        }
              
    }
}
