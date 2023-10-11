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
    }
}
