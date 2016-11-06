using System;

namespace ConditionalExercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Display valid or invalid number depending on number input
      System.Console.Write("\nPlease enter a number between 1 and 10: ");
      String a = Console.ReadLine();
      int b = Convert.ToInt32(a);
      
      if (b > 10 && b < 1)
      {
        Console.WriteLine("Invalid Number");
      }
      else
      {
        Console.WriteLine("Valid Number");
      }

       //Display max between two numbers
      Console.Write("\nPick A number: ");
      var first = Convert.ToInt32(Console.ReadLine());
      
      Console.Write("\nPick Another number: ");
      var second = Convert.ToInt32(Console.ReadLine());

      var max = (first > second) ? first : second;
      Console.WriteLine("Max: " + max);
      
      Console.Write("\nHeight of Image: ");
      var height = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("\nWidth of Image: ");
      var width = Convert.ToInt32(Console.ReadLine());

      if (width > height)
        Console.WriteLine("Landscape");
      else 
        Console.WriteLine("Portait");
    }
  }
}
