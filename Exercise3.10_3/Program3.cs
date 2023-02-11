using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._10_3
{
    internal class Program3
    {
        static void Main(string[] args)
        //Проверка простого числа
        {
            int del = 2;                    // Делитель
            bool flag = false;
            WriteLine("Введите число:");
            int age = int.Parse(ReadLine());

            while (del < age)
            {
                flag = (age % del == 0);
                if (flag == true)
                {                    
                    break;
                }
                del++;
            }
            if (flag == true)
            
                WriteLine($"Число {age} не простое");
            
            else
            
                WriteLine($"Число {age} простое");
            
        }
    }
}
