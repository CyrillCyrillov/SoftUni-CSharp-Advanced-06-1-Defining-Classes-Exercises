using System;
using System.Collections.Generic;
using System.Linq;

namespace Task06_Speed_Racing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int carNumbers = int.Parse(Console.ReadLine());

            List<Car> carsInRacing = new List<Car>();

            for (int i = 1; i <= carNumbers; i++)
            {
                string[] nextData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                //{model} -> nextData[0]
                //{fuelAmount} -> nextData[1]
                //{fuelConsumptionFor1km} -> nextData[2]

                Car nextCar = new Car()
                {
                    Model = nextData[0],
                    FuelAmount = double.Parse(nextData[1]),
                    FuelConsumptionPerKilometer = double.Parse(nextData[2])
                };

                carsInRacing.Add(nextCar);
            }

            while (true)
            {
                string[] nextComand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                /*
                 * Drive -> nextComand[0]
                 * {carModel} -> nextComand[1]
                 * {amountOfKm} -> nextComand[2]
                 * 
                 */
                  
                if(nextComand[0].ToUpper() == "END")
                {
                    break;
                }

                Car curentCar = carsInRacing.FirstOrDefault(n => n.Model == nextComand[1]);

                bool isCanDrive = curentCar.Drive(double.Parse(nextComand[2]));

                if(!isCanDrive)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (Car car in carsInRacing)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }


            //Console.WriteLine("Hello World!");
        }
    }
}
