using System.Diagnostics.Tracing;

namespace Hang_Man_Lite_Project_8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            bool done_ = false;
            Random generator = new Random();           
            string displayWord = "";
            string randomWord;
            int incorrectGuesses;
            string input;
            string input_;           
            List<string> usedLetters = new List<string>() { "" };          
            List<string> words = new List<string>() {"POTATO", "TREEHOUSE", "GRASS", "SANDWICH"};
            incorrectGuesses = 0;
            while (!done_)
            {
                incorrectGuesses = 0;
                displayWord = "";
                usedLetters.Clear();
                randomWord = (words[generator.Next(0, words.Count - 1)]);
                for (int i = 0; i < randomWord.Length; i++)
                {
                    displayWord += "-";
                }                
                done = false;
                Console.Clear();
                while (!done)
                {
                    Console.WriteLine("-HangMan-Lite-Game-");
                    Console.WriteLine(" -----------------");
                    Console.WriteLine("");
                    if (incorrectGuesses == 0)
                    {
                        DrawStickMen(0);
                    }
                    else if (incorrectGuesses == 1)
                    {
                        DrawStickMen(1);
                    }
                    else if (incorrectGuesses == 2)
                    {
                        DrawStickMen(2);
                    }
                    else if (incorrectGuesses == 3)
                    {
                        DrawStickMen(3);
                    }
                    else if (incorrectGuesses == 4)
                    {
                        DrawStickMen(4);
                        Console.WriteLine("Oh no you lost!");                      
                        Console.ReadLine();                       
                        done = true;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("(If you want to quit type /)");
                    Console.WriteLine("Guess a letter:");
                    Console.WriteLine(displayWord);
                    input = Console.ReadLine().ToUpper();                   
                    if (usedLetters.Contains(input))
                    {
                        Console.WriteLine("You already used that letter: Try Again");
                    }
                    else if (input == "/")
                    {
                        done = true;
                    }
                    else if (randomWord.IndexOf(input) == -1)
                    {
                        incorrectGuesses += 1;
                        usedLetters.Add(input);
                    }
                    else
                    {  
                        displayWord = displayWord.Remove(randomWord.IndexOf(input), 1);
                        displayWord = displayWord.Insert(randomWord.IndexOf(input), input);      
                        usedLetters.Add(input);
                    }
                    
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter to Continue:");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("  (Yes)             (No)  ");
                input_ = Console.ReadLine().ToUpper();
                if (input_ == "YES")
                {
                    //
                }
                else
                {
                    done_ = true;
                }
            }
        }
        public static void DrawStickMen(int i)
        {
            if (i == 0)
            {
                Console.WriteLine(" +---+");
                Console.WriteLine(" |   |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine(" =========");
            }
            else if (i == 1)
            {
                Console.WriteLine(" +---+");
                Console.WriteLine(" |   |");
                Console.WriteLine(" O   |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine(" =========");
            }
            else if (i == 2)
            {
                Console.WriteLine(" +---+");
                Console.WriteLine(" |   |");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine(" =========");
            }
            else if (i == 3)
            {
                Console.WriteLine(" +---+");
                Console.WriteLine(" |   |");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("/ \\  |");
                Console.WriteLine("     |");
                Console.WriteLine(" =========");
            }
            else if (i == 4) 
            { 
                Console.WriteLine(" +---+");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("\\O/  |");
                Console.WriteLine(" |   |");
                Console.WriteLine("/ \\  |");
                Console.WriteLine(" =========");
            }
        }
    }
}