using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3._10
{
    internal class Program_1
    {
        static void Main(string[] args)
        //Приложение по определению чётного или нечётного числа
        {
            byte age = 0;
            
            WriteLine("Введите число от 0 до 255: ");
            age = byte.Parse(ReadLine());

            if (age % 2 == 0)
            { 
                WriteLine($"Число: {age}, четное."); 
            }
            else
            {
                WriteLine($"Число: {age}, нечетное"); 
            }

            ReadLine();
        }
    }
}
