using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise3._10_5
{
    internal class Program5
    {
        static void Main(string[] args)
        //Игра «Угадай число»
        {
            Random rand = new Random();
            int userNamber = 0;
            string f = "";
            

            Write("Введите число:");
            userNamber = int.Parse(ReadLine());
            int rNamber = rand.Next(0 , userNamber);
            WriteLine($"угадайте число от 0 до {userNamber}:");

            //bool c = true;
            do
            {
                WriteLine("введите число");
                f = ReadLine();
                if (f == string.Empty)
                {
                    userNamber = 0;
                    WriteLine($"Проиграл, загаданное число: {rNamber}");
                    break;
                }
                else
                    userNamber = int.Parse(f);
                if (userNamber == rNamber)
                {
                    WriteLine($"Поздравляю. число угадано {userNamber}");
                    break;
                }
                else if (userNamber > rNamber)
                {
                    WriteLine($"Мимо, меньше: {userNamber}");

                }
                else if (userNamber < rNamber)
                {
                    WriteLine($"Мимо, больше: {userNamber}");
                    

                }

            }

            while (true);
        }
    }
}
