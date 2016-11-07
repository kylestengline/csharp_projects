using System;

namespace Foreach
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var name = "John Smith";
      /*for (var i = 0; i < name.Length; i++)
      {
        System.Console.WriteLine(name[i]);
      }*/
      
      //here we don't have to set a variable and compare it to something.Length and we also don't have to increment.
      //so whenever we have a enumerable object, it's much easier to iterate over using a foreach.
      /*foreach (var character in name)
      {
        System.Console.WriteLine(character);
      }*/

      //intializing a new array with object initialization syntax
      //we have to instantiate arrays with the new operators
      var numbers = new int[] {1, 2, 3, 4};

      foreach (var number in numbers)
      {
        System.Console.WriteLine(number);
      }
    }
  }
}
