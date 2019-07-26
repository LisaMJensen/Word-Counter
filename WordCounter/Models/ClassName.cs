using System;

namespace WordCounter.Models
{

    public class CounterClass
    {
        public string Word { get; set; }
        public string Sentence { get; set; }


        public CounterClass(string inputWord, string inputSentence)
        {
            Word = inputWord;
            Sentence = inputSentence;
        }

        public string GetWord()
        {
            return Word;
        }

        public string GetSentence()
        {
            return Sentence;
        }

        public int WordCount()
        {
            int count = 0;
            string toLowerCaseWord = Word.ToLower();
            string toLowerCaseSentence = Sentence.ToLower();
            string[] sentenceWords = toLowerCaseSentence.Split(' ', '.', ',', '?', '!', '/', ';', ':', '"');
            foreach (var element in sentenceWords)
            {
                if (toLowerCaseWord == element)
                {
                    count++;
                }
            }
            return count;
        }
    }
}