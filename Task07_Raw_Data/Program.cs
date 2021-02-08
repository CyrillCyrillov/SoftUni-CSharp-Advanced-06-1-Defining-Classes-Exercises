using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int carNumbers = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 1; i <= carNumbers; i++)
            {
                string[] nextData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                Engine engine = new Engine();
                Cargo cargo = new Cargo();
                List<Tire> tires = new List<Tire>();

                string model = nextData[0];
                engine.Speed = int.Parse(nextData[1]);
                engine.Power = int.Parse(nextData[2]);
                cargo.Weigth = int.Parse(nextData[3]);
                cargo.Type = nextData[4];

                for (int i = 5; i <= 12; i+=2)
                {
                    Tire tire = new Tire();
                    tire.Presure = double.Parse(nextData[i]);
                    tire.Age = int.Parse(nextData[i + 1]);
                    tires.Add(tire);
                }

                Car car = new Car(model, engine, cargo, tires.ToArray());
                cars.Add(car);
            }

            string onlyOneComand = Console.ReadLine();

            switch (onlyOneComand.ToUpper())
            {
                case "FRAGILE":
                    ShowFragile(cars);
                    break;

                case "FLAMABILE":
                    ShowFlamabile(cars);
                    break;
                
                default:
                    break;
            }

            //Console.WriteLine("Hello World!");
        }

        static void ShowFlamabile(List<Car> cars)
        {
            foreach (var car in cars)
            {
                if (car.Engine.Power > 250)
                    Console.WriteLine($"{car.Model}");
            }
        }
    }

        static void ShowFragile(List<Car> cars)
        {
            foreach (var car in cars)
            {
                string model = string.Empty;
                foreach (var tire in car.Tires)
                {

                    if (tire.Presure < 1 && car.Model != model)
                    {
                        model = car.Model;
                        Console.WriteLine($"{car.Model}");
                    }
                }

            }
        }
    }
}
