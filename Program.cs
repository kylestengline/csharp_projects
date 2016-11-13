using System;
//need this when we're making lists.
using System.Collections.Generic;

namespace ArrayListExercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //Likes feature
      public void Exercise1()
      {
        var names = new List<string>();
        while(true)
        {
          System.Console.WriteLine("\nEnter a name: ");
          var input = Console.ReadLine();
          names.Add(input);
          
          if (String.IsNullOrWhiteSpace(input));
            break;
            names.Add(input);
        }
            
        var countNames = names.Count;
        if (countNames >= 2)
        {
          System.Console.WriteLine("{0}, {1}, and {2}others like your post", names[0], names[1], countNames - 2);
        }
        else if (countNames == 2)
          System.Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
        else if (countNames == 1)
          System.Console.WriteLine("{0} like your post", names[0]);
        else
          System.Console.WriteLine();
      }


      public void Exercise2()
      {
        
      //Reverse Name in array
        System.Console.WriteLine("Enter your name: ");
        var name = "Harold";
        //var name = Console.ReadLine();
        var arrName = new char[name.Length];
        for (var i = name.Length; i > 0; i--)
          arrName[name.Length - i] = name[i - 1];
          
        var revName = new string(arrName);
        System.Console.WriteLine(revName);
      }

      
      //User enters 5 numbers. If number was previously entered display error and retry. After successful entries of 5 numbers, sort and display them on console.

      public void Exercise3()
      {
        var arrNum = new List<int>(5);

        while (arrNum.Count <= 5)
        {
          System.Console.Write("Enter 5 numbers: ");
          var numbers = Convert.ToInt32(Console.ReadLine());
          if (arrNum.Contains(numbers))
          {
            System.Console.WriteLine("Enter in a number you haven't choosen already: " +numbers);
            continue;
          }
          arrNum.Add(numbers);
        }
        arrNum.Sort();

        foreach(var num in arrNum)
          System.Console.WriteLine(num);
      }

      //Continuosly enter a number or type quit to exit. Numbers may be duplicates, but display only unique ones.
      public void Exercise4()
      {
        var listNum = new List<int>();
        
        while (true)
        {
          System.Console.WriteLine("Enter a Number: ");
          var theNumbers = Console.ReadLine();
          if (theNumbers.ToLower() == "quit")
            break;
            
          listNum.Add(Convert.ToInt32(theNumbers));
        }
        //HashSet gives us the unique numbers only.
        var unique_numbers = new HashSet<int>(listNum); 
        foreach (var uni in unique_numbers)
          System.Console.WriteLine("Your Unique Numbers: " +uni);
      }

    /* Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list. */
      public void Exercise5()
      {
        string[] elements;
        while (true)
        {
          Console.Write("Enter a list of comma-separated numbers: ");
          var input = Console.ReadLine();

          if (!String.IsNullOrWhiteSpace(input))
          {
            elements = input.Split(',');
            if (elements.Length >= 5)
              break;
          }

          Console.WriteLine("Invalid List");
        }

        var numbers = new List<int>();
        foreach (var number in elements)
          numbers.Add(Convert.ToInt32(number));

        var smallests = new List<int>();
        while (smallests.Count < 3)
        {
          // Assume the first number is the smallest
          var min = numbers[0];
          foreach (var number in numbers)
          {
            if (number < min)
              min = number;
          }
          smallests.Add(min);

          numbers.Remove(min);
        }

        Console.WriteLine("The 3 smallest numbers are: ");
        foreach (var number in smallests)
          Console.WriteLine(number);
      }
    }
  }
}