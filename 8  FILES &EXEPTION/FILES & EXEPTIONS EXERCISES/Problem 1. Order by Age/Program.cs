using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem_1.Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            var com = Console.ReadLine();

            while (com != "End")
            {
                var person = com.Split().ToList();

                string name = person[0];
                string id = person[1];
                int age = int.Parse(person[2]);

                var currPerson = new Person()
                {
                    Name = name,
                    ID = id,
                    Age = age
                };

                persons.Add(currPerson);

                com = Console.ReadLine();
            }

            var result = persons.OrderBy(g => g.Age).ToList();
           
            foreach (var x in result)
            {
                Console.WriteLine("{0} with ID: {1} is {2} years old.", x.Name, x.ID, x.Age);
            }
        }
    }
}

