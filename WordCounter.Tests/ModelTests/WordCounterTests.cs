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
            RepeatCounter newRepeatCounter = new RepeatCounter("word", "");
            Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
        }

        [TestMethod]
        public void GetWord_ReturnWord_WordString()
        {
            string inputWord = "word";
            RepeatCounter newRepeatCounter = new RepeatCounter(inputWord, "");
            string result = newRepeatCounter.GetWord();
            Assert.AreEqual(inputWord, result);
        }

        [TestMethod]
        public void GetSentence_ReturnSentence_SentenceString()
        {
            string inputSentence = "This is a sentence.";
            RepeatCounter newRepeatCounter = new RepeatCounter("", inputSentence);
            string result = newRepeatCounter.GetSentence();
            Assert.AreEqual(inputSentence, result);
        }
    }
}
