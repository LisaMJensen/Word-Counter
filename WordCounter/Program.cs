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
            Console.WriteLine("Your sentence contains the word " + Word + " " + NeedsCount.WordCount() + " time(s).");

        }

        static void Welcome()
        {
            Console.WriteLine(@" __      __          _    ___              _           ");
            Console.WriteLine(@" \ \    / /__ _ _ __| |  / __|___ _  _ _ _| |_ ___ _ _ ");
            Console.WriteLine(@"  \ \/\/ / _ \ '_/ _` | | (__/ _ \ || | ' \  _/ -_) '_|");
            Console.WriteLine(@"   \_/\_/\___/_| \__,_|  \___\___/\_,_|_||_\__\___|_| ");
        }
    }
}
