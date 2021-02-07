using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.Age = 20;
            personOne.Name = "Pesho";

            Person personTwo = new Person() { Name = "Gosho", Age = 18 };
            //personTwo.Name = "Gosho";
            //personTwo.Age = 18;

            Person personThree = new Person()
            {
                Age = 43,
                Name = "Stamat"
            };
            //personThree.Name = "Stamat";
            //personThree.Age = 43;
            
            //Console.WriteLine("Hello World!");
        }
    }
}
