
namespace StringTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string sentence = Console.ReadLine();
            char[] alphabetSentence = new char[15];
            int[] alphabetcounter = new int[15];
            for (int i = 0; i < sentence.Length; i++)
            {
                alphabetSentence[i] = sentence[i];
            }
            for (int i = 0; i < sentence.Length; i++)
            {
                alphabetcounter[i] = sentence.Count(alphabetSentence[i]);

            }

        }
    }
}
