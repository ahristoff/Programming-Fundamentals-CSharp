using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();

            var com = Console.ReadLine();

            while (com != "End")
            {
                var car = com.Split(' ').ToList();
                string type = car[0].ToLower();
                string model = car[car.Count - 3];
                string color = car[car.Count - 2].ToLower();
                int horsePower = int.Parse(car[car.Count - 1]);

                var currCar = new Car()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    HorsePower = horsePower
                };

                cars.Add(currCar);

                com = Console.ReadLine();
            }

            var com1 = Console.ReadLine();
            var cars1 = new List<string>();

            while (com1 != "Close the Catalogue")
            {
                cars1.Add(com1);

                com1 = Console.ReadLine();
            }

            var sumHorsePowerCars = 0;
            var sumHorsePowerTrucks = 0;

            foreach (var x in cars.OrderBy(s => s.Type).ThenBy(g => g.Model))
            {
                foreach (var y in cars1)
                {
                    if (y == x.Model)
                    {
                        Console.WriteLine("Type: {0}", x.Type.Substring(0, 1).ToUpper() + x.Type.Substring(1, x.Type.Length - 1).ToLower());

                        Console.WriteLine("Model: {0}", x.Model.Substring(0, 1).ToUpper() + x.Model.Substring(1, x.Model.Length - 1).ToLower());

                        Console.WriteLine("Color: {0}", x.Color);

                        Console.WriteLine("Horsepower: {0}", x.HorsePower);
                    }
                }
            }
            double sumCars = 0;
            double sumTrucks = 0;

            foreach (var x in cars)
            {
                if (x.Type == "car".ToLower())
                {
                    sumHorsePowerCars += x.HorsePower;
                    sumCars++;
                }

                if (x.Type == "truck".ToLower())
                {
                    sumHorsePowerTrucks += x.HorsePower;
                    sumTrucks++;
                }
            }

            sumTrucks = (sumTrucks == 0.0) ? 1.0 : sumTrucks;
            sumCars = (sumCars == 0.0) ? 1.0 : sumCars;

            Console.WriteLine("Cars have average horsepower of: {0:f2}.", sumHorsePowerCars / sumCars);
            Console.WriteLine("Trucks have average horsepower of: {0:f2}.", sumHorsePowerTrucks / sumTrucks);
        }
    }
}
