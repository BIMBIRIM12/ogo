﻿using System;

namespace BMI
{
    class Program
    {
        


         static void Main()
        {
            Console.WriteLine("Привет, я могу посчитать индекс массы твоего тела и из этого сделать твой диагноз ");
            Console.WriteLine("Пожалуйста введи свой вес (кг)");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста введи свой рост (м)");
            double height = double.Parse(Console.ReadLine());
            Program t = new Program();
            double bmi=0;
            string category = "";
            Result( weight , height , ref  bmi);
            Category(bmi, ref category);
            Console.WriteLine("Ваш рост: " + height + "\n Ваш вес: " + weight + "\n Ваш индекс масссы тела: " + bmi + "\n Ваш диагноз: " + category + "\n Хорошего дня! ");

            
           



        }
        static void Result (  double weight,  double height, ref double bmi)
        {
            double w = weight;
            double h = height;
             bmi = w / Math.Pow(h, 2);
            
           
            
            
        }
        static void Category (double bmi, ref string category)
        {
            double b = bmi;
             
            if (bmi <16)
            {
                category = "Выраженный дефицит массы тела";
            }
            else if ( bmi >= 16 && bmi <= 18.5)
            {
                category = "Недостаточная масса тела";

            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                category = "Всё в норме";
            }
            else if (bmi >= 25 && bmi <=30)
            {
                category = "1-ая степень ожирения";
            }
            else if (bmi >=30 && bmi <=35)
            {
                category = "2-ая степень ожирения";
            }
            else 
            {
                category = "3-ая степень ожирения";
                
            }
            
           
        }

    }
}

