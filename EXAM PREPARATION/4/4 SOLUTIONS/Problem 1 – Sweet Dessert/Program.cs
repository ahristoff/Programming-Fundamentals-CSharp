using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            long gast = long.Parse(Console.ReadLine());
            decimal priceOfBananas = decimal.Parse(Console.ReadLine());
            decimal priceOfEgg = decimal.Parse(Console.ReadLine());
            decimal priceOfBerries = decimal.Parse(Console.ReadLine());

            var numOfDessert = Math.Ceiling((decimal)(gast / 6.0));

            var needMoney = ((2 * priceOfBananas) + (4 * priceOfEgg) + ((decimal)0.2 * priceOfBerries)) * numOfDessert;

            if (needMoney <= cash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", needMoney);
            }

            else if (needMoney > cash)
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", needMoney - cash);
            }
        }
    }
}
