using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string a = "Excellent product.|Such a great product.|I always use that product.|Best product of its category.|Exceptional product.|I can’t live without this product.";
            var phrases = a.Split('|');

            string b = "Now I feel good.|I have succeeded with this product.|Makes miracles. I am happy of the results!|I cannot believe but now I feel awesome.|Try it yourself, I am very satisfied.|I feel great!";
            var events = b.Split('|');

            string c = "Diana|Petya|Stella|Elena|Katya|Iva|Annie|Eva";
            var author = c.Split('|');

            string d = "Burgas|Sofia|Plovdiv|Varna|Ruse";
            var cities = d.Split('|');

            var rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                var ranPhrases = rnd.Next(0, phrases.Length);
                string randomPhrases = phrases[ranPhrases];

                var ranEvents = rnd.Next(0, events.Length);
                var randomEvents = events[ranEvents];

                var ranAuthor = rnd.Next(0, author.Length);
                var randomAuthor = author[ranAuthor];

                var ranCities = rnd.Next(0, cities.Length);
                var randomCities = cities[ranCities];

                Console.WriteLine("{0} {1} {2} - {3}", randomPhrases, randomEvents, randomAuthor, randomCities);
            }         
        }
    }
}
