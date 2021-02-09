using System;
using System.Linq;
using System.Collections.Generic;

namespace Task08_Car_Salesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int engineNumbers = int.Parse(Console.ReadLine());
            List<Engine> avalibleEngines = new List<Engine>();


            for (int i = 1; i <= engineNumbers; i++)
            {
                string[] nextEngineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                /*
                Model -> nextEngineInfo[0]
                Power -> nextEngineInfo[1]
                Displacement -> nextEngineInfo[2] !!! IF have
                Efficiency -> nextEngineInfo[3] !! IF have
                */

                Engine nextEngine = new Engine();
                nextEngine.Model = nextEngineInfo[0];
                nextEngine.Power = nextEngineInfo[1];

                if(nextEngineInfo.Length == 3)
                {
                    if(char.IsDigit(nextEngineInfo[2], 0))
                    {
                        nextEngine.Displacement = nextEngineInfo[2];
                    }
                    else
                    {
                        nextEngine.Efficiency = nextEngineInfo[2];
                    }
                }
                if (nextEngineInfo.Length == 4)
                {
                    nextEngine.Displacement = nextEngineInfo[2];
                    nextEngine.Efficiency = nextEngineInfo[3];
                }

                avalibleEngines.Add(nextEngine);
            }


            int carsNumber = int.Parse(Console.ReadLine());
            List<Car> listCars = new List<Car>();

            for (int i = 1; i <= carsNumber; i++)
            {
                string[] nextCarInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                /*
                    Model -> nextCarInfo[0]
                    Engine -> nextCarInfo[1]
                    Weight -> nextCarInfo[2] !!! IF have 
                    Color -> nextCarInfo[3] !!! IF have

                 */

                Car nextCar = new Car();

                nextCar.Model = nextCarInfo[0];
                nextCar.Engine = avalibleEngines.Where(n => n.Model == nextCarInfo[1]).FirstOrDefault();

                if(nextCarInfo.Length == 3)
                {
                    if (char.IsDigit(nextCarInfo[2], 0))
                    {
                        nextCar.Weight = nextCarInfo[2];
                    }
                    else
                    {
                        nextCar.Color = nextCarInfo[2];
                    }

                }
                
                if(nextCarInfo.Length == 4)
                {
                    nextCar.Weight = nextCarInfo[2];
                    nextCar.Color = nextCarInfo[3];
                }

                listCars.Add(nextCar);

            }

            foreach (Car everyCar in listCars)
            {
                Console.WriteLine($"{everyCar.Model}:");
                Console.WriteLine($"  {everyCar.Engine.Model}:");
                Console.WriteLine($"    Power: {everyCar.Engine.Power}");
                Console.WriteLine($"    Displacement: {everyCar.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {everyCar.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {everyCar.Weight}");
                Console.WriteLine($"  Color: {everyCar.Color}");
            }


            //Console.WriteLine("Hello World!");
        }
    }
}
