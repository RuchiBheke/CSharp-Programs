using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Classes
{
    public class ArrayDemo
    {
        public void Arrayy()
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
        }
        public void BoolArray()
        {
            bool[] value = new bool[4];
            value[0]= true;
            Console.WriteLine(value[0]);
            Console.WriteLine(value[1]);
            Console.WriteLine(value[3]);
        }
        public void StringArray()
        {
            var names = new string[3] { "Ruchi", "Bheke","" };
            Console.WriteLine(names[0], names[1], names[2]);
        }
    }
}
