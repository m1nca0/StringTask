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
        public void Test1MakeAlphabetSentence()
        {
            string sentence = "hello world";



            char[] alphabetSentence = Logic.MakeAlphabetSentence(sentence);
            
            char[] compareArray = new char[] { 'h', 'e', 'l', 'o', 'w', 'r', 'd'};
            Assert.That(compareArray, Is.EqualTo(alphabetSentence));
        }
    }
}
