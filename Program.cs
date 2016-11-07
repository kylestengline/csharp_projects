using System;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //print numbers 1 - 100, divisible by 3 with no remainder.
      for (var i = 1; i < 100; i++)
      {
        if (i % 3 == 0)
          System.Console.WriteLine(i);
      }

      //Write a program that continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
      /*while (true)
      {
        System.Console.Write("\nGive me a number:");
        var input = Convert.ToInt32(System.Console.ReadLine());
        var sum = input + input;

        if (input == null)
          System.Console.WriteLine(sum);
          break;
      }*/

      //Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
      //System.Console.Write("\nGive me a number:");
      var theNumber = "5";
      var numberInput = Convert.ToInt32(int.Parse(theNumber));
      var numberOutput = numberInput;
      
      //need the minus 1 so theNumber won't times itself by itself first, but instead start multiplying at theNumber subtracted by one. In this case, 5 - 1 = 4, so it will start multiplying 5 * 4 * 3 * etc..
      for (var i = numberInput - 1; i >= 1; i--)
      {
       numberOutput = numberOutput * i;
      }
      System.Console.WriteLine(numberInput+ "! = " +numberOutput);

      //program picks random number and if that number is correct display success message.
      var random = new Random();
      var number = random.Next(1, 10);

      while(number != 4)
      {
        if (number == 4)
        {
          System.Console.WriteLine("You win");
          break;
        }
        else
          System.Console.WriteLine("You Lost");
      }
    }
  }
}
