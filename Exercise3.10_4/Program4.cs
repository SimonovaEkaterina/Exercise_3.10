using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Exercise3._10_4
{
    internal class Program4
    {
        static void Main(string[] args)
        //Наименьший элемент в последовательности
        {
            int age;
            int min = int.MaxValue;
            int i = 1;
            int ageS = 0;

            WriteLine("Введите длину последовательности:");
            age = int.Parse(ReadLine());

            while(i <= age)
            {
                i++;
                WriteLine("Ваедите следующее число:");
                ageS = int.Parse(ReadLine());
                
                    if (ageS < min)
                    {
                        min = ageS; 
                    }
            }

            WriteLine($"MIN число{min}");
            ReadLine();
        }
    }
}
