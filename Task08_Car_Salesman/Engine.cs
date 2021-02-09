using System;
using System.Collections.Generic;
using System.Text;

namespace Task08_Car_Salesman
{
    public class Engine
    {
        /*
        Model
        Power
        Displacement
        Efficiency
        */

        private string model;
        private string power;
        private string displacement = "n/a";
        private string efficiency = "n/a";

        public string Model { get => model; set => model = value; }
        public string Power { get => power; set => power = value; }
        public string Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }

    }
}
