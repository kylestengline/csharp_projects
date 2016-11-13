using System;
//need this when we're making lists.
using System.Collections.Generic;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //Likes feature
      while(true)
      {
        System.Console.WriteLine("\nEnter a name: ");
        var input = Console.ReadLine();
        var names = new List<string>();
        names.Add(input);
        
        if (!String.IsNullOrWhiteSpace(input));
        {
          var countNames = names.Count;
          if (countNames >= 2)
          {
            System.Console.WriteLine(names +" and "+names+"liked your post.");
          }
          continue;
        } 
        System.Console.WriteLine(names);
        break;
      }

      //Reverse Name in array
      System.Console.WriteLine("Enter your name: ");
      var name = "Harold";
      //var name = Console.ReadLine();
      char[] arrName = name.ToCharArray();
      Array.Reverse(arrName);
      System.Console.WriteLine(arrName);
    }
  }
}