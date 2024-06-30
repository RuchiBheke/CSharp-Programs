using CSharpFundamentals.ArrayAndList;
using CSharpFundamentals.Classes;
using CSharpFundamentals.WorkingWithDates;
using System;
using CSharpFundamentals.WorkingWithText;
using CSharpFundamentals.DataTables;
using System.Data;
using System.Collections.Generic;
using CSharpFundamentals.Working_with_Files;
using CSharpFundamentals.Oops;

namespace CSharpFundamentals
{
    public static class MainClasses
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
            //str.Currency();
            //str.StringDemo();

            //ArrayListClass arr1 = new ArrayListClass();
            //arr1.ArrayMethod();
            //arr1.ListMethod();

            //Dates date = new Dates();
            //date.Datetime();

            //DataTable dt = DataTableSort.DataTables();
            //Console.WriteLine("Enter sort value: ");
            //var sortvalue = Console.ReadLine();
            //List<InvestorData> invlist = new List<InvestorData>();
            //invlist =  DataTableSort.ConvertDtToList(dt);
            //DataTableSort.PrinDataTable(dt);
            //Console.WriteLine("\n-----------------------------Sorted Values-------------------------------\n");
            //List<InvestorData> invlistsort = DataTableSort.ToSort(invlist, sortvalue);
            //DataTableSort.PrintList(invlistsort);
            //Console.WriteLine();
            //DataTable dt = DataTableSort.DataTables();
            //string sortvalue = Console.WriteLine("Enter sort value: ");
            //Console.WriteLine(DataTableSort.PrinDataTable(dt));

            //DataTable dtSort = DataTableSort.ToSort(dt, sortvalue);
            //Console.WriteLine();

            //SummerizeText sumtext = new SummerizeText();
            //sumtext.SummerizeTexts();

            StringBuilders str = new StringBuilders();
            str.Stringbuilder();

            //FileAndFileInfo fileobj = new FileAndFileInfo();
            //fileobj.FileInfoAndFile();
            //fileobj.DirectoryAndDirectoryPath();
            //fileobj.PathDemo();
                
            var person = new Oops.Classes();
            // Since now we define a constructor for the Classes class we need to pass Name parameter in constuctor call itself.
            person.Name = "Mosh";
            person.Id = 4;
            person.Introduce("Ruchi");

            var order = new Oops.Order();
            person.Orders.Add(order);

            var book = new Book{Isbn ="1111", Title = "C# Advanced"};
            var numbers = new List();
            numbers.Add(10);

            var books = new BookList();
            books.Add(book);
        
            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
        }

    }
    static class Person
    {
        public static string FirstName;
        public static string LastName;
        public static void Introduce()
            {
                Console.WriteLine("Hi, My name is "+ FirstName +" "+LastName);
            }
    }

}
