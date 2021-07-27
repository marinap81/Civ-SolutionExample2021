using System;
using ProjectPersonClasses;
using ProjectCarClass;

namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Jon";
            p1.Id = 12345;

            System.Console.WriteLine(p1.Name);

            Car car1 = new Car();
            car1.Rego = "abc123";

            System.Console.WriteLine(car1.Rego);
        }
    }
}
