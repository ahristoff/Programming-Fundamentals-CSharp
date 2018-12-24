using System;

namespace Problem_7._Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();

            int countIngredients = 0;

            while (ingredient != "Bake!")
            {

                Console.WriteLine("Adding ingredient {0}.", ingredient);

                countIngredients++;

                ingredient = Console.ReadLine();
            }

            Console.WriteLine("Preparing cake with {0} ingredients.", countIngredients);
        }
    }
}
