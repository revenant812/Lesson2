using System;

namespace Lesson2Work5
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
            int check1;
            double check2;
            double check3;
            double result;            
            int jan = 0;
            int feb = 0;
            int dec = 0;
            double max = 0;
            double min = 0;
            
            Console.Write("Введите порядковый номер месяца: ");
            string NumberMonth = Console.ReadLine();
            
            if (string.IsNullOrEmpty(NumberMonth))
            {
                Console.Write("Значение не введено!!!");
            }
            else
            {
                bool CheckConvert = int.TryParse(NumberMonth, out check1);
                if (CheckConvert && check1 > 0)
                {
                    int NumberMonthInt = Convert.ToInt32(NumberMonth);
                    switch (NumberMonthInt)
                    {
                        case 1:
                            Console.WriteLine("Текущий месяц: " + listMonth.Январь);
                            jan++;
                            break;
                        case 2:
                            Console.WriteLine("Текущий месяц: " + listMonth.Февраль);
                            feb++;
                            break;
                        case 3:
                            Console.Write("Текущий месяц: " + listMonth.Март);
                            return;
                        case 4:
                            Console.Write("Текущий месяц: " + listMonth.Апрель);
                            return;
                        case 5:
                            Console.Write("Текущий месяц: " + listMonth.Май);
                            return;
                        case 6:
                            Console.Write("Текущий месяц: " + listMonth.Июнь);
                            return;
                        case 7:
                            Console.Write("Текущий месяц: " + listMonth.Июль);
                            return;
                        case 8:
                            Console.Write("Текущий месяц: " + listMonth.Август);
                            return;
                        case 9:
                            Console.Write("Текущий месяц: " + listMonth.Сентябрь);
                            return;
                        case 10:
                            Console.Write("Текущий месяц: " + listMonth.Октябрь);
                            return;
                        case 11:
                            Console.Write("Текущий месяц: " + listMonth.Ноябрь);
                            return;
                        case 12:
                            Console.WriteLine("Текущий месяц: " + listMonth.Декабрь);
                            dec++;
                            break;
                    }
                }
                else
                {
                    Console.Write("Введено не верное значение!");
                    return;
                }
            }
            
            Console.Write("Введите максимальную температуру: ");
            string MaxTemp = Console.ReadLine();
            
            if (string.IsNullOrEmpty(MaxTemp))
            {
                Console.WriteLine("Вы не ввели значение максимальной температуры, программа прекращает работу!");
                return;
            }
            else
            {
                bool checkMaxT = double.TryParse(MaxTemp, out check2);
                if (checkMaxT)
                {
                    max = Convert.ToDouble(MaxTemp);
                }
                else
                {
                    Console.WriteLine("Введено не верное значение!");
                    return;
                }
            }

            Console.Write("Введите минимальную температуру: ");
            string MinTemp = Console.ReadLine();
            
            if (string.IsNullOrEmpty(MinTemp))
            {
                Console.WriteLine("Вы не ввели значение минимальной температуры, программа прекращает работу!");
                return;
            }
            else
            {
                bool checkMinT = double.TryParse(MinTemp, out check3);
                if (checkMinT)
                {
                    min = Convert.ToDouble(MinTemp);
                }
                else
                {
                    Console.WriteLine("Введено не верное значение!");
                    return;
                }
            }
            
            result = (max + min) / 2;
            Console.WriteLine("Среднее значение температуры: " + result);
            if ((jan == 1 || feb == 1 || dec == 1) && result > 0)
            {
                Console.Write("Дождливая зима");
            }
        }
    }
}
