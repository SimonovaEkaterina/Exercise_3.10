using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3._10
{
    internal class Program_2
    {
        static void Main(string[] args)
        //Программа подсчёта суммы карт в игре «21»
        {
            {
                int age;
                int Value = 0;

                WriteLine("Добро пожаловать в игру 21! Сколько карт у Вас на руках?: ");
                age = int.Parse(ReadLine());
                WriteLine("Введите наминал имеющихся у Вас карт:");

                for (int i = 0; i < age; i++)
                {
                    WriteLine("Введие следующий наминал:");
                    string ageS = ReadLine();
                    switch (ageS)
                    { 
                        case "6":
                            Value += int.Parse(ageS);
                            break;
                        case "7":
                            Value += int.Parse(ageS);
                            break;
                        case "8":
                            Value += int.Parse(ageS);
                            break;
                        case "9":
                            Value += int.Parse(ageS);
                            break;
                        case "10":
                            Value += int.Parse(ageS);
                            break;
                        case "J":
                            Value += 10;
                            break;
                        case "D":
                            Value += 10;
                            break;
                        case "K":
                            Value += 10;
                            break;
                        case "T":
                            Value += 10;
                            break;
                        default:
                            WriteLine("Такого наминала нет!");
                            break;
                    }                     
                }
                WriteLine($"Сумма имеющихся карт:{Value}");
                ReadLine();
            }
        }
    }
}
