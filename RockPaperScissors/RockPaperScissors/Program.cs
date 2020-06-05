using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock-paper-scissors");
            bool isRunning = true;
            int playerCounter = 0;
            int computerCounter = 0;
            int drawCounter = 0;
            while (isRunning)
            {
                Console.WriteLine("Choose :");
                Console.WriteLine("1) Play");
                Console.WriteLine("2) Stats");
                Console.WriteLine("3) Exit");
                bool menuOperator = int.TryParse(Console.ReadLine(), out int menuOperatorParsed);
                if (menuOperator)
                {
                    string victor = "";
                    if (menuOperatorParsed == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Choose :");
                        Console.WriteLine("1) Rock");
                        Console.WriteLine("2) Paper");
                        Console.WriteLine("3) Scissors");
                        bool gameOperator = int.TryParse(Console.ReadLine(), out int gameOperatorParsed);
                        if (gameOperator)
                        {
                            Random random = new Random();
                            int computerChoice = random.Next(1, 4);
                            if (gameOperatorParsed == computerChoice)
                            {
                                drawCounter++;
                                victor = "It's a Draw";
                            }
                            else if (gameOperatorParsed == 1 && computerChoice == 2)
                            {
                                computerCounter++;
                                victor = "Computer wins!";
                            }
                            else if (gameOperatorParsed == 1 && computerChoice == 3)
                            {
                                playerCounter++;
                                victor = "Player wins!";
                            }
                            else if (gameOperatorParsed == 2 && computerChoice == 1)
                            {
                                playerCounter++;
                                victor = "Player wins!";
                            }
                            else if (gameOperatorParsed == 2 && computerChoice == 3)
                            {
                                computerCounter++;
                                victor = "Computer wins!";
                            }
                            else if (gameOperatorParsed == 3 && computerChoice == 1)
                            {
                                computerCounter++;
                                victor = "Computer wins!";
                            }
                            else if (gameOperatorParsed == 3 && computerChoice == 2)
                            {
                                playerCounter++;
                                victor = "Player wins!";
                            }
                            Console.WriteLine($"{victor} || Player choice:{gameOperatorParsed} || Computer choice:{computerChoice}");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else if (menuOperatorParsed == 2)
                    {
                        Console.Clear();
                        double totalCount = playerCounter + drawCounter + computerCounter;
                        if (totalCount == 0)
                        {
                            Console.WriteLine("There are no games played yet.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"Stats: Player: {playerCounter} wins {(playerCounter / totalCount) * 100}% || Draw: {drawCounter} {(drawCounter / totalCount) * 100}% || Computer: {computerCounter} {(computerCounter / totalCount) * 100}%");
                            Console.ReadLine();
                        }
                    }
                    else if (menuOperatorParsed == 3)
                    {
                        Console.Clear();
                        isRunning = false;
                    }
                }
            }
        }
    }
}