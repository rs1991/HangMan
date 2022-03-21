using System;

namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SecretWord, GuessedLetters;
            int wrongGuesses = 0, AmountGuesses = 0, RightLetters = 0;
           

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
            GuessedLetters = Console.ReadLine();


            foreach (char c in SecretWord)
            {
                if (GuessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    RightLetters++;
                }
                else
                {
                    Console.Write(" ");
                }
                wrongGuesses++;
            }

            int SecretWordLength = SecretWord.Length;

            while (wrongGuesses != 6 && RightLetters != SecretWordLength)
            {
                Console.Write("Guess a letter: ");
                GuessedLetters = Console.ReadLine();
                AmountGuesses++;
            }
            if (SecretWord.Contains(GuessedLetters))
            {
                Console.Write(GuessedLetters);
                RightLetters++;
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