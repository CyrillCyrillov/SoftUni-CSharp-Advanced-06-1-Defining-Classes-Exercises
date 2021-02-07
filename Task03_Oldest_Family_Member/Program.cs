using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Family myFamily = new Family();

            for (int i = 1; i <= number; i++)
            {
                string[] nextLineData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string curentName = nextLineData[0];
                int curentAge = int.Parse(nextLineData[1]);

                Person curentPerson = new Person(curentName, curentAge);
                myFamily.AddMemeber(curentPerson);
            }

            Person oldestMember = myFamily.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
