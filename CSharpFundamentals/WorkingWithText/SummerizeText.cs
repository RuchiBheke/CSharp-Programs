using System;
using System.Collections.Generic;

namespace CSharpFundamentals.WorkingWithText
{
    public class SummerizeText
    {
        public void SummerizeTexts()
        {
            var sentence = "This is goinig to be a really really really really long text.";
            const int maxLength = 20;
            if (sentence.Length <maxLength)
                Console.WriteLine(sentence);
            var words = sentence.Split(' ');
            //Console.WriteLine(string.Join(",",words));
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            var summary = String.Join(" ", summaryWords)+ "...";
            Console.WriteLine(summary);

        }
    }
}


