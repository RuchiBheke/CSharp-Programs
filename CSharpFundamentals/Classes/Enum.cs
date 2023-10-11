using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Classes
{   
    public enum ShippingMethod
    {   
        Express = 3,
        RegularAirMall = 1,
        RegisteredAirMail = 2
        
    }
    class Enum
    {
        public void Run()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            Console.WriteLine(method);

            //Parsing- change string into different type
            var method1 = "Express";
            Console.WriteLine(method1);
            //Emun(System class).(static methods)
            var shippingMethod = System.Enum.Parse(typeof(ShippingMethod), method1);
            Console.WriteLine(shippingMethod);

        }
        public void ReferenceType()
        {
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0]=0;
            Console.WriteLine(array1[0]);
        }
    }
  
}
