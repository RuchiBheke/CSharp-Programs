using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var program = new Program();
            program.Name="Ruchi";
            program.Introduce();
        }
        public string Name;
        public void Introduce()
        {
            Console.WriteLine("My Name is " + Name);
        }

       

    }
}
