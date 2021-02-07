using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person personOne = new Person();
            Person personTwo = new Person(30) ;
            Person personThree = new Person("Alex", 24);

            //Console.WriteLine("Hello World!");
        }
    }
}
