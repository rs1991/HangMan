using System;

namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SecretWord;
            int RightLetters = 0, WrongLetters = 0, Lives = 6, counter = 0;
            List<char> GuessedLetters = new List<char>();
            List<char> RightWord = new List<char>();


            Console.WriteLine("-------------------");
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("-------------------");

            // Picks a random word from the list
            var random = new Random();

            List<string> words = new List<string>();
            words.Add("hang");
            words.Add("about");
            words.Add("faith");
            words.Add("maybe");
            words.Add("tape");

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

                    Console.WriteLine(UserGuess + " ");
                    RightLetters++;
                    RightWord.Add(UserGuess);


                }
                else
                {
                    Console.WriteLine(" ");
                    WrongLetters++;
                    DrawHangman(WrongLetters);
                }
                counter++;


                if (RightLetters == SecretWordLength)
                {
                    Console.WriteLine("\nThe word was: {0}", SecretWord);
                    Console.WriteLine("You win!");

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