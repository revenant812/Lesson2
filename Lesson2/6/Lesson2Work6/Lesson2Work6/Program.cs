using System;

namespace Lesson2Work6
{
    class Program
    {
        enum DayWeek
        {
            Понедельник = 0b_1000000,
            Вторник = 0b_0100000,
            Среда = 0b_0010000,
            Четверг = 0b_0001000,
            Пятница = 0b_0000100,
            Суббота = 0b_0000010,
            Воскресенье = 0b_0000001,
        }
        static void Main(string[] args)
        {
            DayWeek Office1 = DayWeek.Вторник | DayWeek.Среда | DayWeek.Четверг | DayWeek.Пятница;
            DayWeek Office2 = DayWeek.Понедельник | DayWeek.Вторник | DayWeek.Среда | DayWeek.Четверг | DayWeek.Пятница | DayWeek.Суббота | DayWeek.Воскресенье;
            Console.Write("Введите офис который Вам нужен; ");
            string Office = Console.ReadLine();
            if(string.IsNullOrEmpty(Office))
            {
                Console.WriteLine("День недели введен не верно!!!");
            }
            else
            {
                switch (Office)
                {
                    case "Офис1:":
                       DayWeek resul1 = DayWeek.Понедельник & DayWeek;
                        break;
                       
                 


                }
            }
                
           

        }
    }
}
