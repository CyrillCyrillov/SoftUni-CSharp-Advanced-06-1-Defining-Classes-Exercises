using System;
using System.Collections.Generic;
using System.Text;

namespace Task09_Pokemon_Trainer
{
    public class Pokemon
    {
        /*
            Name
            Element
            Health

         */

        private string name;
        private string element;
        private int health;

        public string Name { get => name; set => name = value; }
        public string Element { get => element; set => element = value; }
        public int Health { get => health; set => health = value; }

        public Pokemon( string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }

    }
}
