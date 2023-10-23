using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madul1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ваше имя: ");
            string fullName = Console.ReadLine();
            Console.WriteLine($"Приветствую тебя,{fullName}!");
            Console.ReadKey();
        }
        
    }
}
