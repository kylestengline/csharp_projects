using System;

namespace Types
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            System.Console.WriteLine(number);
            //number = 1
            
            //making a new person aged 20.
            var person = new Person() {Age = 20};
            //add 10 to persons age
            MakeOld(person);
            //display age of person.
            System.Console.WriteLine(person.Age);
            //prints 30.
        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}

        /*
        public static void Main(string[] args)
        {
            Reference types Example 1:
            var a = 10;
            var b = a;
            b++;
            System.Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            //prints a: 10, b: 11
            /* when you copy a value type to a diff var, a copy of that value is taken and stored in that var. That's why we call them value types. 
            
            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            System.Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
            //prints array1[0]: 0, array2[0]: 0 
        }
            */