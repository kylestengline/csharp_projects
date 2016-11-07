using System;

namespace ForLoops
{
  public class Program
  {
    public static void Main(string[] args)
    {
      for (var i = 1; i <= 10; i++)
      {
        if (i % 2 == 0)
        {
          System.Console.WriteLine(i);
        }
      }
      for (var i = 10; i >= 1; i--)
      {
        if (i % 2 ==0)
        {
          System.Console.WriteLine(i);
        }
      }
    }
  }
}
