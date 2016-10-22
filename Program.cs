using System;

namespace TypeConversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
        //Explicit type conversion

            //int i = 1000;
            //must explicitly state casting if there's a chance for data loss.
            //byte b = (byte) i;
            //Console.WriteLine(b);
            
            //Non-Compatible Types
            try
            {
                //var number = "1234";
                //byte b = Convert.ToByte(number);
               // Console.WriteLine(b);
                
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }
        }
    }
}
