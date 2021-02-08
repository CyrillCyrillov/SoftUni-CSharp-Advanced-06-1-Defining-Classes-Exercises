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

                Engine nextEngine = new Engine();
                Cargo nextCargo = new Cargo();
                List<Tire> tires = new List<Tire>();

                string model = nextData[0];
                nextEngine.Speed = int.Parse(nextData[1]);
                nextEngine.Power = int.Parse(nextData[2]);
                nextCargo.Weigth = int.Parse(nextData[3]);
                nextCargo.Type = nextData[4];

                for (int j = 5; j <= 12; j+=2)
                {
                    Tire nextTire = new Tire();
                    nextTire.Presure = double.Parse(nextData[j]);
                    nextTire.Age = int.Parse(nextData[j + 1]);
                    tires.Add(nextTire);
                }

                Car car = new Car(model, nextEngine, nextCargo, tires.ToArray());
                cars.Add(car);
            }

            string onlyOneComand = Console.ReadLine();

            switch (onlyOneComand.ToUpper())
            {
                case "FRAGILE":
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
                    break;

                case "FLAMABLE":
                    foreach (var car in cars)
                    {
                        if (car.Engine.Power > 250)
                            Console.WriteLine($"{car.Model}");
                    }
                    break;
                
                default:
                    break;
            }

            //Console.WriteLine("Hello World!");
        }

    }
}
