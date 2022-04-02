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
            
            char delim = ',';

            string RightWord = String.Join(delim, GuessedLetters);


            Console.WriteLine("-------------------");
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("-------------------");

            // Picks a random word from the list
            var random = new Random();

            List<string> words = new List<string>();
            words.Add("latte");
            words.Add("funny");
            words.Add("class");
            words.Add("chill");
            words.Add("bless");
            words.Add("pleasure");

            int index = random.Next(words.Count);
            SecretWord = words[index];

            int SecretWordLength = SecretWord.Length;

            while (WrongLetters != 6 && RightLetters != SecretWordLength)
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


                if (SecretWord==RightWord)
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("\nThe word was: {0}", SecretWord);
                }
                if (WrongLetters == Lives)
                {
                    Console.WriteLine("You lose!");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("\nThe correct word was: {0}", SecretWord);
                }

                Console.WriteLine("Letters guessed so far: ");
                foreach (char letter in GuessedLetters)
                {
                    Console.WriteLine(letter + " ");
                }

                Console.WriteLine("You current progress: ");
                foreach (char c in SecretWord)
                {
                    if (GuessedLetters.Contains(c))
                    {
                        Console.Write(c + " ");
                    }
                    else
                    {
                        Console.Write("-");
                    }
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