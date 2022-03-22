using System;

namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SecretWord, GuessedLetter;
            int wrongGuesses = 0, AmountGuesses = 0, RightLetters = 0, Lives = 6;


            Console.WriteLine("-------------------");
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("-------------------");

            var random = new Random();

            List<string> words = new List<string>();
            words.Add("Other");
            words.Add("About");
            words.Add("Faith");
            words.Add("Maybe");
            words.Add("Clown");

            int index = random.Next(words.Count);
            SecretWord = words[index];

            Console.Write("Guess a letter: ");
            GuessedLetter = Console.ReadLine();

            foreach (char c in SecretWord)
            {
                if (GuessedLetter.Contains(c))
                {
                    Console.Write(c + " ");
                    RightLetters++;
                }
                if (!GuessedLetter.Contains(c))
                {
                    Console.Write(" ");
                    wrongGuesses++;
                }

            }

            int SecretWordLength = SecretWord.Length;
            List<char> LettersGuessedByUser = new List<char>();

            while (wrongGuesses != 6 || RightLetters != SecretWordLength)
            {
                Console.Write("Guess a letter: ");
                GuessedLetter = Console.ReadLine();
                AmountGuesses++;

                foreach (char letter in LettersGuessedByUser)
                {
                    Console.WriteLine(letter + " ");
                }
            }
            if (SecretWord.Contains(GuessedLetter))
            {
                RightLetters++;
                Console.Write(GuessedLetter);
            }


            if (AmountGuesses == Lives)
            {
                Console.WriteLine("You lose!");
            }
        }


        static void DrawHangman(int wrongGuesses)
        {
            if (wrongGuesses == 0)
            {
                Console.WriteLine(" ");
            }
            if (wrongGuesses == 1)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("        | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");
            }
            if (wrongGuesses == 2)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("  |     | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");
            }
            if (wrongGuesses == 3)
            {

                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("//|     | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");

            }
            if (wrongGuesses == 4)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("//|\\   | ");
                Console.WriteLine("        | ");
                Console.WriteLine("   ====== ");
            }
            if (wrongGuesses == 5)
            {
                Console.WriteLine("  ------");
                Console.WriteLine("  |     |");
                Console.WriteLine("  O     |");
                Console.WriteLine("//|\\   | ");
                Console.WriteLine("  |     | ");
                Console.WriteLine("//      | ");
                Console.WriteLine("   ====== ");

            }
            if (wrongGuesses == 6)
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

//while game is not game over
//get the guessed letter
//check if the guessed letter is in the secret word
//keep track of wrongGuesses
//deopending on that do dofferent outputs