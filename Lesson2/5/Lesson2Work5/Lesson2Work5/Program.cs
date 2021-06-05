using System;

namespace Lesson2Work5
{
    class Program
    {
        enum WinterMonth
        {
            Декабрь = 0b_001,
            Январь = 0b_010,
            Февраль = 0b_100,
        }
        enum temp 
        { 
            
        }

        static void Main(string[] args)
        {
            int check1;
            int check2;
            int check3;
            Console.Write("Введите порядковый номер месяца: ");
            string NumberMonth = Console.ReadLine();
            Console.Write("Введите максимальную температуру: ");
            string MaxTemp = Console.ReadLine();
            Console.Write("Введите минимальную температуру: ");
            string MinTemp = Console.ReadLine();
            bool result1 = int.TryParse(NumberMonth, out check1);
            bool result2 = int.TryParse(MaxTemp, out check2);
            bool result3 = int.TryParse(MinTemp, out check3);
            if (result1 && result2 && result3)
            {
                Console.Write("удача");
            }
            else
            {
                Console.Write("Введите целое число!!!");
            }
             
              

            
            
            
        
        }
    }
}
