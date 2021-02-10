using System;
using System.Collections.Generic;
using System.Text;

namespace Task09_Pokemon_Trainer
{
    public class Trainer
    {
        /*
            Name
            Number of badges
            A collection of pokemon

         */

        private string name;
        private int badges = 0;
        private List<Pokemon> pokemonColection;

        public string Name { get => name; set => name = value; }

        public int Badges { get => badges; set => badges = value; }

        public List<Pokemon> PokemonColection { get => pokemonColection; set => pokemonColection = value; }

        public Trainer(string name)
        {
            Name = name;
        }



    }
}
