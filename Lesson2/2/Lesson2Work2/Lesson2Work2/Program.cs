using System;

namespace Lesson2Work2
{
    class Program
    {
        enum listMonth
        {
            Январь,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь,
        }
        static void Main(string[] args)
        {
            int check;
            Console.Write("Введите порядковый номер текущего месяца: ");
            string NumberMonth = Console.ReadLine();
            if(string.IsNullOrEmpty(NumberMonth))
            {
                Console.Write("Значение не введено!!!");
            }
            else
            {               
                bool CheckConvert = int.TryParse(NumberMonth, out check);
                if (CheckConvert)
                {
                    int NumberMonthInt = Convert.ToInt32(NumberMonth);
                    switch (NumberMonthInt)
                    {
                        case 1:
                            Console.Write("Текущий месяц: " + listMonth.Январь);
                            break;
                        case 2:
                            Console.Write("Текущий месяц: " + listMonth.Февраль);
                            break;
                        case 3:
                            Console.Write("Текущий месяц: " + listMonth.Март);
                            break;
                        case 4:
                            Console.Write("Текущий месяц: " + listMonth.Апрель);
                            break;
                        case 5:
                            Console.Write("Текущий месяц: " + listMonth.Май);
                            break;
                        case 6:
                            Console.Write("Текущий месяц: " + listMonth.Июнь);
                            break;
                        case 7:
                            Console.Write("Текущий месяц: " + listMonth.Июль);
                            break;
                        case 8:
                            Console.Write("Текущий месяц: " + listMonth.Август);
                            break;
                        case 9:
                            Console.Write("Текущий месяц: " + listMonth.Сентябрь);
                            break;
                        case 10:
                            Console.Write("Текущий месяц: " + listMonth.Октябрь);
                            break;
                        case 11:
                            Console.Write("Текущий месяц: " + listMonth.Ноябрь);
                            break;
                        case 12:
                            Console.Write("Текущий месяц: " + listMonth.Декабрь);
                            break;
                    }
                }
                else
                {
                    Console.Write("Введено не верное значение!");
                }
            }
        }
    }
}
