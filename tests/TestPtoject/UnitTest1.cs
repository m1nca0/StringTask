using StringTask;
namespace TestPtoject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SimpleMakeAlphabetSentenceTest()
    {
        string sentence = "hello world";

        char[] alphabetSentence = Logic.MakeAlphabetSentence(sentence);

        char[] compareArray = new char[] { 'h', 'e', 'l', 'o', 'w', 'r', 'd' };
        Assert.That(compareArray, Is.EqualTo(alphabetSentence));
    }

    [Test]
    public void EmptySentenceArray()
    {
        string sentence = "";

        char[] alphabetSentence = Logic.MakeAlphabetSentence(sentence);

        char[] compareArray = new char[] { };
        Assert.That(compareArray, Is.EqualTo(alphabetSentence));
    }

    [Test]
    public void MakeAlphabetCounterTest()
    {
        string sentence = "hello world";

        char[] alphabetSentence = Logic.MakeAlphabetSentence(sentence);

        int[] alphabetcounter = Logic.MakeAlphabetCounter(sentence, alphabetSentence);

        int[] compareArray = new int[] { 10, 10, 30, 20, 10, 10, 10 };
        Assert.That(compareArray, Is.EqualTo(alphabetcounter));
    }

    [Test]

    public void MakeNullAlphabetCounterTest()
    {
        var sentence = "";

        char[] alphabetSentence = Logic.MakeAlphabetSentence(sentence);

        int[] alphabetcounter = Logic.MakeAlphabetCounter(sentence, alphabetSentence);

        int[] compareArray = new int[] { };
        Assert.That(compareArray, Is.EqualTo(alphabetcounter));
    }

    [Test]
    public void MakeSameLettersAlphabetCounterTest()
    {
        var sentence = "wwww";

        char[] alphabetSentence = Logic.MakeAlphabetSentence(sentence);

        int[] alphabetcounter = Logic.MakeAlphabetCounter(sentence, alphabetSentence);

        int[] compareArray = new int[] { 100 };
        Assert.That(compareArray, Is.EqualTo(alphabetcounter));
    }
}