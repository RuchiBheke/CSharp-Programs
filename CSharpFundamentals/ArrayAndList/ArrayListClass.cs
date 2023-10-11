using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.ArrayAndList
{
    public class ArrayListClass
    {
        public void ArrayMethod()
        {   
            //array- fixed length
            //Length
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 56, 6 };
            Console.WriteLine("1 Length: "+ numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 56);
            Console.WriteLine("2 "+index);

            //Clear()
            Array.Clear(numbers, 0, 4);
            foreach (var c in numbers)
                Console.WriteLine("3 "+c);

            //copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("\n4 "+"Effect of copy(): ");
            foreach (var e in another)
                Console.Write(" "+e);
        }

        public void ListMethod()
        {
            //List- dynamic size
            var nums = new List<int>() { 34, 45, 56, 67, 89 };

            //Add(), AddRange(), Remove(), RemoveAt(), IndexOf(), Contains(), Count
            nums.AddRange(new int[4] { 1, 2, 3, 4});
            Console.WriteLine("5 ");
            foreach (var r in nums)
                Console.Write(" "+r);

        }
    }
}
