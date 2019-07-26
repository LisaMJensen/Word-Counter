using System;

namespace WordCounter.Models
{

    public class RepeatCounter
    {
        public string Word { get; set; }
        public string Sentence { get; set; }


        public RepeatCounter(string inputWord, string inputSentence)
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
        public bool ValidInputCheck(string input)
        {
            if (string.IsNullOrEmpty(Word) && string.IsNullOrEmpty(Sentence))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int WordCount()
        {
            int count = 0;
            string toLowerCaseWord = Word.ToLower();
            string toLowerCaseSentence = Sentence.ToLower();
            string[] sentenceWords = toLowerCaseSentence.Split(' ', '.', ',', '?', '!', '/', ';', ':', '"');
            foreach (string invidualWords in sentenceWords)
            {
                if (toLowerCaseWord == invidualWords)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
