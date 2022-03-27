using System;

namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SecretWord;
            int RightLetters = 0, Counter = 0, WrongGuesses = 0, NoGuesses =0;
            char UserGuess;
            List<char> GuessedLetters = new List<char>();
            List<char> RightWord = new List<char>();

            Console.WriteLine("-------------------");
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("-------------------");

            // Picks a random word from the list
            var random = new Random();

            List<string> words = new List<string>();
            words.Add("Hang");
            words.Add("About");
            words.Add("Faith");
            words.Add("Maybe");
            words.Add("Tape");

            int index = random.Next(words.Count);
            SecretWord = words[index];

            int SecretWordLength = SecretWord.Length;

            while (WrongGuesses != 6 && RightLetters != SecretWordLength)
            {
                Console.Write("Guess a letter: ");
                UserGuess = Console.ReadLine()[0];
                GuessedLetters.Add(UserGuess);

                Console.Write("Letters guessed so far: ");
                foreach (char letter in GuessedLetters)
                {
                    Console.Write(letter + " ");
                }

                foreach (char c in SecretWord)
                {
                    if (SecretWord.Contains(UserGuess))
                    {
                        Console.Write(c + " ");
                        RightLetters++;
                        RightWord.Add(UserGuess);
                    }
                    else
                    {
                        Console.Write(" ");
                        WrongGuesses++;
                    }
                    Counter++;   
                }
                NoGuesses++;
                if(NoGuesses == 6)
                {
                    break;
                }

            }

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


//while game is not game over
//get the guessed letter
//check if the guessed letter is in the secret word
//keep track of wrongGuesses
//deopending on that do dofferent outputs