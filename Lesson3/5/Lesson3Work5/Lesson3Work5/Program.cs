using System;

namespace Lesson3Work5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "AABFDSBATTTSAW";
            string str2 = "WBFDSAATWSTTTSAQ";

            string result = string.Empty;
            string result1 = string.Empty;
            
            //char[] array1 = str2.ToCharArray();
            
            int count  = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;

            //Определение размера массива первой строки
            for (int y = 0; y < str1.Length; y++)
            {
                for (int i = y; i < str1.Length; i++)
                {                   
                    count = count + 1;
                    result = result + str1[i];
                    //Console.WriteLine(result);
                }
                result = string.Empty;
            }
            //Console.WriteLine(count);
            
            //Создание массива всех вариантов первой строки
            string[] ArrayStr = new string[count];
                        
            //Заполнение массива первой строки всеми комбинациями 
            for (int y = 0; y < str1.Length; y++)
            {
                for (int i = y; i < str1.Length; i++)
                {
                    result = result + str1[i];
                    ArrayStr[count1] = result;
                    //Console.WriteLine(ArrayStr[count1]);
                    count1 = count1 + 1;                    
                    //return;
                }
                //return;
                result = string.Empty;
            }

            
            //Определение размера массива второй строки
            for (int y = 0; y < str2.Length; y++)
            {
                for (int i = y; i < str2.Length; i++)
                {
                    count2 = count2 + 1;
                    result1 = result1 + str2[i];
                    
                }
                result1 = string.Empty;
            }
            //Console.WriteLine(count2);

            //Создание массива всех вариантов второй строки
            string[] ArrayStr1 = new string[count2];

            //Заполнение массива второй строки всеми комбинациями 
            for (int y = 0; y < str2.Length; y++)
            {
                for (int i = y; i < str2.Length; i++)
                {
                    result1 = result1 + str2[i];
                    ArrayStr1[count3] = result1;
                    //Console.WriteLine(ArrayStr1[count3]);
                    count3 = count3 + 1;
                }
                result1 = string.Empty;
            }
            
            //нахождение количества совпадений в строках
            foreach (string f in ArrayStr)
            {
                foreach (string a in ArrayStr1)
                {
                    if(f == a)
                    {
                        
                        int len = f.Length;
                        count5 = count5 + 1;
                        //Console.WriteLine(f);
                    }
                }
                

            }
            int[] CountLen = new int[count5];

            foreach (string f in ArrayStr)
            {
                foreach (string a in ArrayStr1)
                {
                    if (f == a)
                    {
                        int len = f.Length;
                        CountLen[count6] = len;
                        //Console.WriteLine(CountLen[count6]);
                        count6 = count6 + 1;
                    }
                }
                
            }

            string[] CountString = new string[count5];

            foreach (string f in ArrayStr)
            {
                foreach (string a in ArrayStr1)
                {
                    if (f == a)
                    {
                        
                        
                        CountString[count7] = f;
                        //Console.WriteLine(CountString[count7]);
                        count7 = count7 + 1;
                    }
                }
                
            }

            int maxValue = CountLen[0];
            
            for (int i = 0; i < CountLen.Length; i++)
            {
                
                if(CountLen[i] > maxValue)
                {
                    maxValue = CountLen[i];
                }
                
            }
            //Console.WriteLine(maxValue);
            int indexMax = Array.IndexOf(CountLen, maxValue);
            //Console.WriteLine(indexMax);
            Console.WriteLine(CountString[indexMax]);
        }   
         
        void MaxSubStr(string str1, string str2)
        {

        }


    }
}
