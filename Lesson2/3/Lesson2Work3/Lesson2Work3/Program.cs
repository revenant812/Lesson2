using System;

namespace Lesson2Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Check;
            Console.Write("Введите число: ");
            string Count = Console.ReadLine();
            if (string.IsNullOrEmpty(Count))
            {
                Console.Write("Не введено значение");
            }
            else
            {
                bool resultBool = int.TryParse(Count, out Check);
                if (resultBool)
                {
                    int ConvertCount = Convert.ToInt32(Count);
                    int result = ConvertCount % 2;

                    if (result == 0)
                    {
                        Console.WriteLine("Число четное");
                    }
                    else
                    {
                        Console.WriteLine("Число не четное");
                    }
                }
                else
                {
                    Console.Write("Ошибка. Введите целое число!");
                }
            }
            
            
        }
    }
}
