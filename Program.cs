using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankDeposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money;
            int years;
            int percent;

            Console.WriteLine("Введите сумму первого вклада.");
            money = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите длительность вклада в годах.");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите годовую процентную ставку.");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine($"В {i+1} год накоплений у вас {money} рублей");
                Console.ReadKey();
            }
        }
    }
}
