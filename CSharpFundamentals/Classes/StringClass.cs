using System;


namespace CSharpFundamentals.Classes
{
    public class StringClass
    {   
        public void StringMethod()
        {
            var firstName = "Ruchi";
            String lastName = "Bheke";


            //concate the string
            string myName = firstName+" "+lastName;

            //string format
            var fullName = string.Format("My name is {0} {1}", firstName, lastName);
            var names = new string[3] { "John", "Jack", "Marry" };

            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            //Verbatim strings
            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder1\\folder2\\filename.pdf";
            Console.WriteLine(text);
            var text1 = @"Hi John,
                           Look into the following paths
                                c:\\folder1\\folder2
                                c:\\folder1\\folder2\\filename.pdf";
            Console.WriteLine(text1);




        }
    }
}
