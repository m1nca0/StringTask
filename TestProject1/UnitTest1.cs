using System.Linq;
using StringTask;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMakeAlphabetSentence()
        {
            string sentence = "hello world";



            char[] alphabetSentence = Logic.MakeAlphabetSentence(sentence);
            
            char[] compareArray = new char[] { 'h', 'e', 'l', 'o', 'w', 'r', 'd'};
            Assert.That(compareArray, Is.EqualTo(alphabetSentence));
        }

        [Test]
        public void TestMakeAlphabetCounter()
        {
            string sentence = "hello world";

            char[] alphabetSentence = Logic.MakeAlphabetSentence(sentence);

            int[] alphabetcounter = Logic.MakeAlphabetCounter(sentence, alphabetSentence);

            int[] compareArray = new int[] { 1, 1, 3, 2, 1, 1, 1 };
            Assert.That(compareArray, Is.EqualTo(alphabetcounter));
        }
    }
}
