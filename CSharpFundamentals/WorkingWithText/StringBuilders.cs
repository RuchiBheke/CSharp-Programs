using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.WorkingWithText
{
    class StringBuilders
    {
        public void Stringbuilder()
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);
            //StringBuilder only provides methods for fast and efficient manipulation of strings. It doesn't have any methods to search in strings. If you need to search in a string that you're building using a StringBuilder, you need to cover it to a string first: builder.ToString().IndexOf('M').

        }

    }
}
