using System;

namespace Lesson2Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальную температуру: ");
            string maxT = Console.ReadLine();
            if (string.IsNullOrEmpty(maxT))
            {
                Console.WriteLine("Вы не ввели значение максимальной температуры, программа прекращает работу!");
                return;                
            }
            Console.Write("Введите минимальную температуру: ");
            string minT = Console.ReadLine();
            if (string.IsNullOrEmpty(minT))
            {
                Console.WriteLine("Вы не ввели значение минимальной температуры, программа прекращает работу!");
                return;
            }
            double max = Convert.ToDouble(maxT);
            double min = Convert.ToDouble(minT);           
            double result = (max + min) / 2;
            Console.Write("Среднесуточная температура: " + result);
        }
    }
}
