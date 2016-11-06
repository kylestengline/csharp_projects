using System;

namespace Conditionals
{
  public class Program
  {
    public static void Main(string[] args)
    {

      //Switch Case Statement
      var season = Season.Autumn;
      switch (season)
      {
        //If autumn and summer had the same message, we can put the case statements on top of each other like so.
        case Season.Autumn:
        case Season.Summer:
          Console.WriteLine("We've got a promotion");
          break;
          
        default:
          Console.WriteLine("I don't understand that season.");
          break;
      }
      
     //Basic if/else 
     /* int hour = 10;

      if (hour > 0 && hour < 12)
      {
        Console.WriteLine("It's Morning.");
      }
      else if (hour >= 12 && hour < 18)
      {
        Console.WriteLine("It's Afternoon.");
      }
      else 
      {
        Console.WriteLine("It's Evening.");
      }*/
      
      //Condition Statment for short if /else
      
      //bool isGoldCustomer = true;

      //if/else 
      /*float price;
      if (isGoldCustomer)
        price = 19.95f;
      else
        price = 29.95f;*/

      //conditional statement similar to ternary operator. We seperate conditions with a ? and the : is similar to an else. After ? it's: if isGoldCustomer is true then price is 19.95 :(else) price is 29.95
      //shortcut for if/else
      
      //float price = (isGoldCustomer) ? 19.95f : 29.95f;
      //Console.WriteLine(price);

      
      
    }
  }
}
