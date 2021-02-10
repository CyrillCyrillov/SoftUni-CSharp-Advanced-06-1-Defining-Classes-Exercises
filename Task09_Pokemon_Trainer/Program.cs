using System;
using System.Linq;
using System.Collections.Generic;

namespace Task09_Pokemon_Trainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> allTraniers = new List<Trainer>();

            string comand = null;
            while ((comand = Console.ReadLine().ToUpper()) != "TOURNAMENT")
            {
                string[] nextTranierInfo = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                if(nextTranierInfo[0].ToUpper() == "TOURNAMENT")
                {
                    break;
                }

                /*
                    {trainerName} -> nextTranierInfo[0]
                    {pokemonName} -> nextTranierInfo[1]
                    {pokemonElement} -> nextTranierInfo[2]
                    {pokemonHealth} -> nextTranierInfo[3]
                 */

                Pokemon nextPokemon = new Pokemon(nextTranierInfo[1], nextTranierInfo[2], int.Parse(nextTranierInfo[3]));

                if(allTraniers.FirstOrDefault(n => n.Name == nextTranierInfo[0]) != null )
                {
                    allTraniers.FirstOrDefault(n => n.Name == nextTranierInfo[0]).PokemonColection.Add(nextPokemon);
                }
                else
                {
                    Trainer newTrainer = new Trainer(nextTranierInfo[0]);
                    allTraniers.Add(newTrainer);
                    allTraniers.n
                }





            }


            Console.WriteLine("Hello World!");
        }
    }
}
