using System;

namespace HangMan
{
    internal class Program
    {

        static void drawHangman(int guesses)
        {
            if (guesses == 0)
            {
                Console.WriteLine(" ");
            }
            if (guesses == 1)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("        | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");
            }
            if (guesses == 2)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("  |     | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");
            }
            if (guesses == 3)
            {

                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("//|     | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");

            }
            if (guesses == 4)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("//|\\   | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");
            }
            if (guesses == 5)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("//|\\   | ");
                Console.WriteLine("  |     | ");
                Console.WriteLine("//      | ");
                Console.WriteLine("   ====== ");

            }
            if (guesses == 6)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("//|\\   | ");
                Console.WriteLine("  |     | ");
                Console.WriteLine("// \\   | ");
                Console.WriteLine("   ====== ");
            }
        }

        static void printWord(string secretWord, string letter)
        {

            var random = new Random();
            List<string> words = new List<string>();
            words.Add("Other");
            words.Add("About");
            words.Add("Faith");
            words.Add("Maybe");
            words.Add("Clown");

            int index = random.Next(words.Count);
            Console.WriteLine(words[index]);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("-------------------");

            Console.WriteLine("Guess the secret word");
            string letter = Console.ReadLine();

            Console.ReadKey();
        }
    }
}