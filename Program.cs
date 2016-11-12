using System;
using System.Collections;

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
      while (true)
      {
        System.Console.Write("\nGive me a number: ");
        var input = Convert.ToInt32(System.Console.ReadLine());
        var sum = input + input;

        if (input == null)
          System.Console.WriteLine(sum);
          break;
      }

      //Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
      //System.Console.Write("\nGive me a number:");
      var theNumber = "5";
      var numberInput = Convert.ToInt32(int.Parse(theNumber));
      var numberOutput = numberInput;
      
      //need the minus 1 so theNumber won't times itself by itself first, but instead start multiplying at theNumber subtracted by one. In this case, 5 - 1 = 4, so it will start multiplying theNumber * 4 * 3 * etc..
      for (var i = numberInput - 1; i >= 1; i--)
      {
       numberOutput = numberOutput * i;
      }
      System.Console.WriteLine(numberInput+ "! = " +numberOutput);

      //program picks random number and if that number is correct display success message.
      var number = new Random().Next(1, 10);

      Console.WriteLine("Secret is " + number);
      for (var i = 0; i < 4; i++)
      {
        Console.Write("Guess the secret number: ");
        var guess = Convert.ToInt32(Console.ReadLine());

        if (guess == number)
        {
          Console.WriteLine("You won!");
          return;
        }
      }

      Console.WriteLine("You lost!");
        
      //user enters series of numbers and you find the largest. EX: 1, 7, 3, 4: 7 is highest.
      Console.Write("Enter a few of your favorite numbers: ");
      var input = Console.ReadLine();

      var numbers = input.Split(',');

      // Assume the first number is the max 
      var max = Convert.ToInt32(numbers[0]);

      foreach (var str in numbers)
      {
          var number = Convert.ToInt32(str);
          if (number > max)
              max = number;
      }

      Console.WriteLine("Max is " + max);
    }
  }
}
