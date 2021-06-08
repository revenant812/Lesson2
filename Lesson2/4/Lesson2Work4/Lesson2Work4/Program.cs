using System;

namespace Lesson2Work4
{
    class Program
    {
        static void Main(string[] args)
        {
            int INN = 6451;
            DateTime DateAndTime = new DateTime(2021, 2, 3, 21, 36, 33);
            string Fuel = "АИ-95";
            string Org = "ООО Альфа Трейд";
            int V = 50;
            double Cost = 35.20;
            double result = V * Cost;
            Console.WriteLine($"               {Org}");
            Console.WriteLine("        Добро пожаловать ! АЗС № 127");
            Console.WriteLine("           МЫ ГАРАНТИРУЕМ КАЧЕСТВО");
            Console.WriteLine("Наличный расчет");
            Console.WriteLine($"ИНН 0000{INN}");
            Console.WriteLine(DateAndTime);
            Console.WriteLine("ПРОДАЖА");
            Console.WriteLine(Fuel + " (2-ТРК)");
            Console.WriteLine("Наличный расчет");
            Console.WriteLine($"                     {V}.00 x {Cost}");
            Console.WriteLine("                         ={0:0.00}", result);
            Console.WriteLine("ИТОГ" + "                    =" + " {0:0.00}", result);
            Console.WriteLine("Наличными" + "               =" + " {0:0.00}", result);
            Console.WriteLine("Сдача" + "                      =" +  " 0.00");
            Console.WriteLine("            СПАСИБО ЗА ПОКУПКУ");
            Console.WriteLine("            СЧАСТЛИВОГО ПУТИ!");
            




        }
    }
}
