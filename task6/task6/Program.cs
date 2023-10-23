using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите несколько чисел через пробек: ");

            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            double sum = 0;
            foreach (string number in numbers)
            {
                if (double.TryParse(number, out double parsedNumber))
                {
                    sum += parsedNumber;
                }
                else 
                {
                    Console.WriteLine("Ошибка.");
                }
            }
            Console.WriteLine($"Сумма введенных чисел: {sum}");
            Console.ReadKey();  
        }
    }
}
