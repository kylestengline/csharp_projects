using System;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var numbers = new[] { 3, 7, 9, 2, 14, 6 };

      //Length - returns size of array.
      System.Console.WriteLine("Length");
      System.Console.WriteLine("Length: " + numbers.Length);

      //IndexOf() gets the index for the number you pass in.
      System.Console.WriteLine("IndexOf()");
      var index = Array.IndexOf(numbers, 9); //prints 2 because the index of the number 9 is 2.
      System.Console.WriteLine("Index of 9: " + index);

      //Clear() will clear elements in the array. We pass in the name of the array with the index we want to start at and end with.
      System.Console.WriteLine("Clear()");
      Array.Clear(numbers, 0, 2);
      foreach(var n in numbers)
        System.Console.WriteLine(n);
        //prints the first 2 numbers in numbers as 0

        //Copy() will copy an array. It takes 3 parametes. 1. source array 2. destination. 3. number of elements we would like to copy.
      System.Console.WriteLine("Copy()");
      int[] another = new int[3];
      Array.Copy(numbers, another, 3);

      foreach(var num in another)
        System.Console.WriteLine(num);

      //Sort()
      System.Console.WriteLine("Sort()");
      Array.Sort(numbers);

      foreach(var n in numbers)
        System.Console.WriteLine(n);

      //Reverse()
      System.Console.WriteLine("Reverse()");
      
      Array.Reverse(numbers);
      foreach(var num in numbers)
        System.Console.WriteLine(num);
    }
  }
}
//Keep in mind that certain methods can only be called on array classes and others can only be called objects. See IndexOf compared to Length