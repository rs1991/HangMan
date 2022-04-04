using System;

namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SecretWord;
            int RightLetters = 0, WrongLetters = 0, Lives = 6;
            List<char> GuessedLetters = new List<char>();
            string RightWord = "";


            Console.WriteLine("-------------------");
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("-------------------");

            var random = new Random();

            List<string> words = new List<string>();
            words.Add("latte");
            words.Add("funny");
            words.Add("class");
            words.Add("chill");
            words.Add("blessing");
            words.Add("pleasure");

            int index = random.Next(words.Count);
            SecretWord = words[index];

            int SecretWordLength = SecretWord.Length;

            while (WrongLetters != 6)
            {
                Console.Write("Guess a letter: ");
                char UserGuess = Console.ReadLine()[0];
                GuessedLetters.Add(UserGuess);

                if (SecretWord.Contains(UserGuess))
                {
                    RightLetters++;
                }
                else
                {
                    WrongLetters++;
                    DrawHangman(WrongLetters);
                }


                Console.WriteLine("Letters guessed so far: ");
                foreach (char letter in GuessedLetters)
                {
                    Console.Write(letter + " ");
                }

                Console.WriteLine("\nYou current progress: ");
                RightWord = "";
                foreach (char c in SecretWord)
                {
                    if (GuessedLetters.Contains(c))
                    {
                        Console.Write(c + " ");
                        RightWord = RightWord + c;
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                if (SecretWord == RightWord)
                {
                    Console.WriteLine("\nYou win!");
                    Console.WriteLine("---------------------");
                    Console.WriteLine($"\nThe word was: {SecretWord}");
                }
                if (WrongLetters == Lives)
                {
                    Console.WriteLine("\nYou lose!");
                    Console.WriteLine("---------------------");
                    Console.WriteLine($"\nThe correct word was: {SecretWord}");
                }
            }
            Console.WriteLine("Thanks for playing :)");
            Console.ReadKey();
        }

        //Draws out the hangman
        static void DrawHangman(int Wrong)
        {
            if (Wrong == 0)
            {
                Console.WriteLine(" ");
            }
            if (Wrong == 1)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("        | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");
            }
            if (Wrong == 2)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("  |     | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");
            }
            if (Wrong == 3)
            {

                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("//|     | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");

            }
            if (Wrong == 4)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("//|\\   | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");
            }
            if (Wrong == 5)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("//|\\   | ");
                Console.WriteLine("  |     | ");
                Console.WriteLine("//      | ");
                Console.WriteLine("   ====== ");

            }
            if (Wrong == 6)
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
    }
}