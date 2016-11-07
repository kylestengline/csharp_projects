using System;

namespace WhileLoops
{
  public class Program
  {
    public static void Main(string[] args)
    {
      /*typically it's better to use a while loop when you don't know ahead of time, how many times you're going to do an iteration
      var i = 0;
      while (i <= 10)
      {
        if (i % 2 == 0)
          System.Console.WriteLine(i);
          i++;
      }*/

      
      /*while (true)
      {
        System.Console.Write("Type your name: ");
        var input = Console.ReadLine();

        //program ends if enter key is pressed
        if (String.IsNullOrWhiteSpace(input))
          break;

        System.Console.WriteLine("@Echo: " + input);
      }*/
      
      while (true)
      {
        System.Console.Write("Type your name: ");
        var input = Console.ReadLine();

        //program ends if enter key is pressed
        if (!String.IsNullOrWhiteSpace(input))
        {
          System.Console.WriteLine("@Echo: " + input);
          //with continue, the loop will jump back to the beginning after you type your name.
          continue;
        }
          break;
      }
    }
  }
}
