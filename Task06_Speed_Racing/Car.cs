using System;
using System.Collections.Generic;
using System.Text;

namespace Task06_Speed_Racing
{
    public class Car
    {

        /*
        •	string Model
        •	double FuelAmount
        •	double FuelConsumptionPerKilometer
        •	double Travelled distance
        */

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public bool Drive(double distanceTraveled)
        {
            double neededFuel = distanceTraveled * FuelConsumptionPerKilometer;

            if(neededFuel <= FuelAmount)
            {
                TravelledDistance += distanceTraveled;
                FuelAmount -= neededFuel;                
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
