using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program80
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество набранных очков: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int score) && score >= 0)
            {
                string medal;

                if (score >= 5000)
                    medal = "Золотая";
                else if (score >= 2500)      // покрывает диапазон 2500–4999
                    medal = "Серебряная";
                else if (score >= 1000)      // покрывает диапазон 1000–2499
                    medal = "Бронзовая";
                else
                    medal = "Без медали";

                Console.WriteLine($"Медаль: {medal}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите неотрицательное целое число.");
            }
        }
    }
}