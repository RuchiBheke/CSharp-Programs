using System;
using System.Collections.Generic;

namespace CSharpFundamentals.Oops
{
    public class Classes
    {
        //A class is simply building block of a application.
        // anatomy of classes is Data and Behaviour.

        //object is instance of a class
        // we use Pascal Case in C#
        // instance member: accessible from an object
        // static member : accessible from the class, we dont have to create an instance or object of method in order to call

        public int Id;
        public string Name;
        public List<Order> Orders;
        // note once we declare any type of list, its thumb rule to initialised that list an empty object, otherwise we would get an null reference exception.

        public void Introduce(string to) 
        {
            Console.WriteLine("Hi {0}, I am {1} and my id is {2}", to, Name, Id);
        }
        // a constructor has exact same name as a class..
        // constructor dont have any return typeNOT EVEN VOID.
        // there will be always default constrcutor generated for class by intermmedate language.

        public Classes(string name) : this()
        {
            this.Name = name;
        }
        // Constructure Overloading : method with same name and different signatures - return type, number of parameters, 
        public Classes(string name, int id) : this(name)
        {
            this.Id = id;
        }

        public Classes() 
        {
            Orders = new List<Order>();
        }

        //Note: We use constructor in C# before object initializers were used. Obj initialization helps to reduce creating number of constructors.
    }
}

