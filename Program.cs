using System;

namespace Enums
{
//Because enum is a new type we need to define it at the namespace level.
    public enum ShippingMethod
    //always set values as it is convention. 
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //prints 3
            
            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId); //prints Express
            
            System.Console.WriteLine(method.ToString()); //prints Express
            
            //This is how you convert or parse a string to a enum.
            var methodName = "Express";
            /* first setting var then casting because parse returns an object and we need an enum. This is why we need to cast */
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            System.Console.WriteLine(shippingMethod);
        }
    }
}
