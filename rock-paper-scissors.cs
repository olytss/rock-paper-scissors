using System.ComponentModel;
using System.Threading;

class program
{
    internal class meow
    {
        

        static private void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("                                              Rock-Paper-Scissors Game!            ");
            string PlayAgain;
            Console.WriteLine("git test")
            do
            {
                string[] Possibilities = ["✂️ Scissors", "🏔️ Rock", "📃 Paper"];

                Random random = new Random();
                int random1 = random.Next(0, 3);
                string answer = Possibilities[random1];




                Console.WriteLine();
                Console.WriteLine("You can pick out of ✂️ Scissors, 🏔️ Rock and 📃 Paper. What would you choose?");
                string userAnswer1 = Console.ReadLine();
               string userAnswer = userAnswer1.ToLower();


                if (userAnswer == "Scissors" || userAnswer == "s")
                {
                    if (answer == "✂️ Scissors")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your answer is ✂️ Scissors and the opponent's is {answer}");
                        
                        Console.WriteLine("Its a tie!");

                    }
                    if (answer == "🏔️ Rock")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your answer is ✂️ Scissors and the opponent's is {answer}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You loose!");
                        Console.ResetColor();
                    }
                    if (answer == "📃 Paper")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your answer is ✂️ Scissors and the opponent's is {answer}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won!");
                        Console.ResetColor();

                    }
                }
                if (userAnswer == "Rock" || userAnswer == "r")
                {
                    if (answer == "✂️ Scissors")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your answer is 🏔️ Rock and the opponent's is {answer}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won!");
                        Console.ResetColor();

                    }
                    if (answer == "🏔️ Rock")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your answer is 🏔️ Rock and the opponent's is {answer}");
                        Console.WriteLine("Its a tie!");
                    }
                    if (answer == "📃 Paper")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your answer is 🏔️ Rock and the opponent's is {answer}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You loose!");
                        Console.ResetColor();
                    }
                }
                if (userAnswer == "Paper" || userAnswer == "p")
                {
                    if (answer == "✂️ Scissors")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your answer is 📃 Paper and the opponent's is {answer}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You loose!");
                        Console.ResetColor();

                    }
                    if (answer == "🏔️ Rock")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your answer is 📃 Paper and the opponent's is {answer}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won!");
                        Console.ResetColor();
                    }
                    if (answer == "📃 Paper")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your answer is 📃 Paper and the opponent's is {answer}");
                      
                        Console.WriteLine("Its a tie!");
                        
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to play again?");
                
                Console.Write("Enter - Yes");
                Console.Write("          n - No");
                Console.WriteLine() ;
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine();
                PlayAgain = Console.ReadLine();


            } while (PlayAgain == "");
        }
    }

}