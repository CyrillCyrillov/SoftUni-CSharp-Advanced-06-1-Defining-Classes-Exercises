using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> myFamily = new List<Person>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string[] nextLineData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                Person nextPerson = new Person(nextLineData[0], int.Parse(nextLineData[1]));

                myFamily.Add(nextPerson);
            }

            foreach (var person in myFamily.OrderBy(n => n.Name))
            {
                if(person.Age > 30)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}
