using System;

namespace RandomClass
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //generating a list of up to 10 random numbers
      var random = new Random();

      //password can only be 10 char long
      const int passwordLength = 10;
      
      //looping over the length of the password and making it a char instead of an int.
      var buffer = new char[passwordLength];
      for (var i = 0; i < passwordLength; i++)
      //generating random chars for our password
        buffer[i] = (char)('a' + random.Next(0, 26));
        
        //intitializing password as a new string 
        var password = new string(buffer);
        System.Console.WriteLine(password);
        //System.Console.WriteLine(random.Next(1, 10));
        //System.Console.WriteLine((char)('a' + random.Next(0, 26));
    }
  }
}
