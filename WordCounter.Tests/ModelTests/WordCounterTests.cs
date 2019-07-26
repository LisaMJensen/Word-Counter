using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class ClassNameTest
    {
        [TestMethod]
        public void WordCounter_IsWord_Word()
        {
            CounterClass newCounterClass = new CounterClass("word", "");
            Assert.AreEqual(typeof(CounterClass), newCounterClass.GetType());
        }

        [TestMethod]
        public void GetWord_ReturnWord_WordString()
        {
            string inputWord = "word";
            CounterClass newCounterClass = new CounterClass(inputWord, "");
            string result = newCounterClass.GetWord();
            Assert.AreEqual(inputWord, result);
        }

        [TestMethod]
        public void GetSentence_ReturnSentence_SentenceString()
        {
            string inputSentence = "This is a sentence.";
            CounterClass newCounterClass = new CounterClass("", inputSentence);
            string result = newCounterClass.GetSentence();
            Assert.AreEqual(inputSentence, result);
        }
    }
}