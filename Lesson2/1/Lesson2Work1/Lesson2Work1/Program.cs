﻿using System;

namespace Lesson2Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            double check1;
            double check2;            
            Console.Write("Введите максимальную температуру: ");
            string maxT = Console.ReadLine();
            if (string.IsNullOrEmpty(maxT))
            {
                Console.WriteLine("Вы не ввели значение максимальной температуры, программа прекращает работу!");
                return;                
            }
            else
            {
                bool checkMaxT = double.TryParse(maxT, out check1);
                if (checkMaxT)
                {
                    double max = Convert.ToDouble(maxT);
                }
                else
                {
                    Console.WriteLine("Введено не верное значение!");
                }
            }
            
            
            
            
            
            
            Console.Write("Введите минимальную температуру: ");
            string minT = Console.ReadLine();
            if (string.IsNullOrEmpty(minT))
            {
                Console.WriteLine("Вы не ввели значение минимальной температуры, программа прекращает работу!");
                return;
            }
            
            bool checkMinT = double.TryParse(minT, out check2);

            


            
            double min = Convert.ToDouble(minT);           
            double result = (max + min) / 2;
            Console.Write("Среднесуточная температура: " + result);
        }
    }
}
