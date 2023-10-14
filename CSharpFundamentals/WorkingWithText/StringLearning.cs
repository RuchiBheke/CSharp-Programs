using System;

namespace CSharpFundamentals.WorkingWithText
{
    public class StringLearning
    {
        //ToLoer(), ToUpper(), Trim(), SubString(startIndex), SubString(startIndex, length), IndexOf(), LastIndexOf(), Replace(),
        //NullChecking--> String.isNullOrEmpty(str), String.IsNullOrWhiteSpace(str), str.Split(' ')
        public void Exp()
        {
            string s = "1234";
            int i = int.Parse(s);
            int j = Convert.ToInt32(s);
            Console.WriteLine("1 "+s+" "+i+" "+j);
        }

        public void Currency()
        {
            int i = 1234;
            string s = i.ToString();
            string t = i.ToString("c");
            string u = i.ToString("c0");
        }

        public void StringDemo()
        {
            var fullName = "    Ruchi Bheke     ";
            Console.WriteLine("1 Trim: '{0}'", fullName.Trim());
            Console.WriteLine("2 ToUpper: {0}", fullName.Trim().ToUpper());
            var index = fullName.IndexOf(' ');
            var firstname = fullName.Substring(0, index);
            var lastname = fullName.Substring(index + 1);
            Console.WriteLine("3 Firstname: "+ firstname);
            Console.WriteLine("4 Lastname: "+ lastname);

            var names = fullName.Split(' ');
            Console.WriteLine("5 Firstname: " +  names[0]);
            Console.WriteLine("6 LastName: " + names[1]);
            Console.WriteLine("7 " + fullName.Replace("Ruchi", "Ruchita"));

        }
    }
}
