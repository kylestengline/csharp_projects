using System;

namespace ConditionalExercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      String a;
      Console.WriteLine("Please enter a number between 1 and 10...");
      a = Console.ReadLine();
      int b = Convert.ToInt32(a);
      
      if (b > 10 && b < 1)
      {
        Console.WriteLine("Invalid Number");
      }
      else
      {
        Console.WriteLine("Valid Number");
      }
    }
  }
}
