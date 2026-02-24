using System.Linq;
namespace StringTask
{
    public class Logic
    {
        public static char[] MakeAlphabetSentence(string sentence)
        {
            sentence = sentence.Replace(" ", "");
            char[] alphabetSentence = new char[100];
            for (int i = 0; i < sentence.Length; i++)
            {
                alphabetSentence[i] = sentence[i];
            }
            alphabetSentence = alphabetSentence.Distinct().ToArray();
            return alphabetSentence.SkipLast(1).ToArray();
        }
        public static int[] MakeAlphabetCounter(string sentence, char[] alphabetSentence)
        {
            int[] alphabetcounter = new int[alphabetSentence.Length];
            for (int i = 0; i < alphabetSentence.Length; i++)
            {
                alphabetcounter[i] = sentence.Count(alphabetSentence[i]);
            }
            return alphabetcounter;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string sentence = Console.ReadLine();
            char[] alphabetSentence = Logic.MakeAlphabetSentence(sentence);
            int[] alphabetcounter = Logic.MakeAlphabetCounter(sentence, alphabetSentence);

            for (int i = 0; i < alphabetSentence.Length; i++)
            {
                Console.WriteLine(alphabetSentence[i]  + " " + alphabetcounter[i] * 100 / sentence.Length + "%");
            }

        }
    }
}
