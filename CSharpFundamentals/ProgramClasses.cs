using CSharpFundamentals.ArrayAndList;
using CSharpFundamentals.Classes;
using CSharpFundamentals.WorkingWithDates;
using System;
using CSharpFundamentals.WorkingWithText;
using CSharpFundamentals.DataTables;
using System.Data;

namespace CSharpFundamentals
{
    public static class ProgramClasses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person.FirstName = "Ruchi";
            Person.LastName = "Bheke";
            Person.Introduce();

            //Calculation calculator = new Calculation();
            //Console.WriteLine(calculator.Add(3, 5));

            //ArrayDemo arr = new ArrayDemo();
            //arr.Arrayy();
            //arr.BoolArray();
            //arr.StringArray();

            //StringClass strcls = new StringClass();
            //strcls.StringMethod();

            //Classes.Enum enn = new Classes.Enum();
            //enn.Run();
            //enn.ReferenceType();

            //StringLearning str = new StringLearning();
            //str.Exp();

            //ArrayListClass arr1 = new ArrayListClass();
            //arr1.ArrayMethod();
            //arr1.ListMethod();

            //Dates date = new Dates();
            //date.Datetime();

            DataTable dt = DataTableSort.DataTables();
            string sortvalue = Console.WriteLine("Enter sort value: ");
            Console.WriteLine(DataTableSort.PrinDataTable(dt));

            DataTable dtSort = DataTableSort.ToSort(dt, sortvalue);
            Console.WriteLine();
        }

    }
    static class Person
    {
        public static string FirstName;
        public static string LastName;
        public static void Introduce()
            {
                Console.WriteLine("Hi, My name is "+ FirstName+" " +LastName);
            }
    }

}
