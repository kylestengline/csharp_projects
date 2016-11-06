using System;

namespace ConditionalExercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      System.Console.Write("Please enter a number between 1 and 10: ");
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

      /*double a, b;
      Console.WriteLine("Please Choose Two Numbers...: ");*/
      
      
    }
  }
}
