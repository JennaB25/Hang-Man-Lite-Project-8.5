using System.Diagnostics.Tracing;

namespace Hang_Man_Lite_Project_8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string word;
            string displayWord;
            int incorrectGuesses;
            string input;
            word = " COMPUTER";
            displayWord = "--------";
            incorrectGuesses = 0;
            while (!done)
            {              
                Console.WriteLine("-HangMan-Lite-Game-");
                Console.WriteLine(" -----------------");               
                Console.WriteLine("");
                if (incorrectGuesses == 0)
                {
                    Console.WriteLine(" +---+");
                    Console.WriteLine(" |   |");
                    Console.WriteLine("     |");
                    Console.WriteLine("     |");
                    Console.WriteLine("     |");
                    Console.WriteLine("     |");
                    Console.WriteLine(" =========");
                }
                else if (incorrectGuesses == 1)
                {
                    Console.WriteLine(" +---+");
                    Console.WriteLine(" |   |");
                    Console.WriteLine(" O   |");
                    Console.WriteLine("     |");
                    Console.WriteLine("     |");
                    Console.WriteLine("     |");
                    Console.WriteLine(" =========");
                }
                else if (incorrectGuesses == 2)
                {
                    Console.WriteLine(" +---+");
                    Console.WriteLine(" |   |");
                    Console.WriteLine(" O   |");
                    Console.WriteLine("/|\\  |");
                    Console.WriteLine("     |");
                    Console.WriteLine("     |");
                    Console.WriteLine(" =========");
                }
                else if (incorrectGuesses == 3)
                {
                    Console.WriteLine(" +---+");
                    Console.WriteLine(" |   |");
                    Console.WriteLine(" O   |");
                    Console.WriteLine("/|\\  |");
                    Console.WriteLine("/ \\  |");
                    Console.WriteLine("     |");
                    Console.WriteLine(" =========");
                }
                Console.WriteLine("");              
                Console.WriteLine("Guess a letter:");
                Console.WriteLine(displayWord);
                input = Console.ReadLine().ToUpper();
                if (input ==  "Q")
                {
                    done = true;
                }
                if (input == word.Substring(1, 1))
                {
                    displayWord.Replace(displayWord.Substring(1, 1), word.Substring(1, 1));
                }
                else if (input == word.Substring(2, 2))
                {
                    displayWord.Replace(displayWord.Substring(2, 2), word.Substring(2, 2));
                }               
                else
                {
                    incorrectGuesses += 1;
                }                                  
                
            }
        }
    }
}