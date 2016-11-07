using System;

namespace ConditionalExercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Display valid or invalid number depending on number input
      public void Numbers()
      {
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
      }
      
       //Display max between two numbers
      public void Max()
      {
        Console.Write("\nPick A number: ");
        var first = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nPick Another number: ");
        var second = Convert.ToInt32(Console.ReadLine());

        var max = (first > second) ? first : second;
        Console.WriteLine("Max: " + max);
        
      }

      public void Image()
      {
        Console.Write("\nHeight of Image: ");
        var height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nWidth of Image: ");
        var width = Convert.ToInt32(Console.ReadLine());
        
        var orientation = (width > height) ? "Landscape" : "Portrait";
      }  

      public void Camera()
      {
        Console.Write("\nEnter Speed Limit: ");
        var speedLimit = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nEnter the speed of the car: ");
        var carSpeed = Convert.ToInt32(Console.ReadLine());

        var demerits = 0;
        if (carSpeed < speedLimit)
        {
          Console.WriteLine("OK");
        }
         else
        {
          //setting points at 5 for violation
          const int kmPerDemeritPoint = 5;
          //subtract carSpeed with limt then divide.
          var demeritPoints = (carSpeed - speedLimit)/kmPerDemeritPoint;
          if (demeritPoints > 12)
              Console.WriteLine("License Suspended");
          else
              Console.WriteLine("Demerit points: " + demeritPoints);
        } 
      }
    }
  }
}