using System;

namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[] numbers = new int[3] 
            //short hand for the above:
            var numbers = new int[3];
            numbers[0] = 1;

            System.Console.WriteLine(numbers[0]);
            System.Console.WriteLine(numbers[1]);
            System.Console.WriteLine(numbers[2]);
            
            //declaring array and setting the size
            var flags = new bool[3];
            flags[0] = true;
            
            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]);
            System.Console.WriteLine(flags[2]);
            
/*Object Initialization Syntax means to supply values for the each element of the array*/
            var names = new string[3] {"Jack", "John", "Mary"};
        }
    }
}
