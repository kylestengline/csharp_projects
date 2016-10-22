using System;
//Using the below, this is how I can reference the methods in math
using csharp_projects.Math;

namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
