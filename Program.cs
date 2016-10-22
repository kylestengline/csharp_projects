using System;

namespace Strings
{
    class Program
    {
        public static void Main(string[] args)
        {
            var firstName = "Kyle";
            var lastName = "Wins";
            
            var fullName = firstName + " " + lastName;
            
            //An easier way to write the above:
            var myFullName = string.Format("My name is {0}{1}", firstName, lastName);
            //0 is replaced with first name while 1 is replaced by lastname.
            
            var names = new string[3] { "John", "Jill", "Jack" };
            
            // first argument of .Join is the separator then the array.
            var formattedName = string.Join(",", names);
            System.Console.WriteLine(formattedName);
            
            /* var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\\folder3";
            System.Console.WriteLine(text); */
            
            /*Another easier way to write the above:
            Similar to heredoc syntax */
            var text = @"Hi John
            Look into the following paths:
            c:\folder1\folder2
            c:\folder3\folder4";
            System.Console.WriteLine(text);
        }
    }
}
