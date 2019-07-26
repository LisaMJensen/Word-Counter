using System;
using WordCounter.Models;

namespace WordCounter
{
    class WordCounter
    {
        static void Main()
        {
            Welcome();
            Console.WriteLine("Please enter a word.");
            string Word = Console.ReadLine();
            Console.WriteLine("Please enter a sentence that uses that word at least once.");
            string Sentence = Console.ReadLine();
            CounterClass NeedsCount = new CounterClass(Word, Sentence);
            Console.WriteLine("Your sentence contains the word " + Word + " " + NeedsCount.WordCount() + " times.");

        }

        static void Welcome()
        {
            Console.WriteLine("Welcome to the Word Counter!");
        }
    }
}
