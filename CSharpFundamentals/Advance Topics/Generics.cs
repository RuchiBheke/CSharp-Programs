namespace CSharpFundamentals.Advance_Topics
{
    public class Generics
    {   
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }
        public Book this[int index]
        {
            get {throw new NotImplementedException(); }
        }
    
    }

    //when we use object class, it incurr to performance penalty, risk of runtime casting from int to object and then again object to int or boxing operations.
    //With genetics, we create a class once and reuse it multiple times, and it doen't have the performance penalty like with the Object here.

    //how to create a genrics class, it has parameters speicified by angle brackets, we usually call the, T as in short for template pr type. 
    public class GenericList<T>
    {   
        //
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get {throw new NotImplementedException();}
        }
    }
    public class GenericDictionary<TKey, TValue>
    {
            public void Add(TKey key, TValue value)
            {

            }
    }
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a:b;
        }
        public T Max<T>(T a, T b)
        {
            return a > b ? a:b; 
        }
    }

    // types of constarints in C#
    // where T : IComparable
    // where T : struct
    // where T : Product
    // where T : class
    // where T : new()

    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(T)
    }
}
