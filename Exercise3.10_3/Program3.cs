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
            int age = 0;
            int i = 2;
            
            WriteLine("Введите число:");
            age = int.Parse(ReadLine());

            while (i <= age)
            {
                if (age % i == 0 && age % age == 0)
                {
                    WriteLine($"Число {age} не простое");
                    break;
                }
                else
                {
                    WriteLine($"Число {age} простое");
                    break;
                }
            }
            WriteLine();
        }
    }
}
