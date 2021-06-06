using System;
using System.Linq;

namespace Lesson2Work6
{
    class Program
    {
        static void Main(string[] args)
        {
            int check;
            Console.Write("Введите число (палиндром): ");
            string result = Console.ReadLine();
            if(string.IsNullOrEmpty(result))
            {
                Console.Write("Значение не введено, программа завершает работу");
            }
            else
            {
                bool BoolResult = int.TryParse(result, out check);
                if(BoolResult)
                {
                    int IntResult = Convert.ToInt32(result);
                    if (isPalindrom(IntResult))
                    {
                        Console.Write("Число палиндром");
                    }
                    else
                    {
                        Console.Write("Число не палиндром");
                    }
                }
            }           

            bool isPalindrom(int num)
            {
                string str = Convert.ToString(num);
                bool res = true;
                for (int n = 0; n < str.Length; n++)
                {                    
                    if (result[n] != result[result.Length - n - 1])
                    {
                        res = false;
                    }
                }
                return res;
            }            
        }
    }
}
