using System;
using System.Collections.Generic;

namespace Lists
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //the int is telling you what kind of list it is. We could also say new List<String>() if we wanted.
      //We don't have to initialize the list right now. Just using it for this example.
      var numbers = new List<int>() {1, 2, 3, 4};
      numbers.Add(1);
      numbers.AddRange(new int[3] {5, 6, 7});

      foreach(var num in numbers)
        System.Console.WriteLine(num); //prints 1, 2, 3, 4, 1, 5, 6, 7

      System.Console.WriteLine("IndexOf on Lists");
      System.Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
      System.Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));


      System.Console.WriteLine("Count");
      System.Console.WriteLine("Count: " + numbers.Count);

      System.Console.WriteLine("Remove");
      for (var i = 0; i < numbers.Count; i++)
      {
        if (numbers[i] == 1)
          numbers.Remove(numbers[i]);
      }
      foreach(var num in numbers)
        System.Console.WriteLine(num);

      System.Console.WriteLine("Clear");
      
      numbers.Clear();
      System.Console.WriteLine("Count: " + numbers.Count);
    }
  }
}