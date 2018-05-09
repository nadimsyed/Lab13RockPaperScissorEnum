using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {
            //TODO: Go through and validate
            //TODO: Add names look at lab
            UserSelector userSelector = new UserSelector();

            RockSelector rockSelector = new RockSelector();

            RandomSelector randomSelector = new RandomSelector();

            int tieCounter = 0;
            int winCounter = 0;
            int lossCounter = 0;


            //rockSelector.generateRoShambo();
            bool truth = true;
            while (truth)
            {
                Console.WriteLine("Do you want to play against rock or random?");
                string input = Console.ReadLine().ToLower();

                if (!Validator.IntChecker(input))
                {
                    if (input == "rock")
                    {
                        Roshambo roshambo = userSelector.generateRoShambo();
                        Roshambo rock = rockSelector.generateRoShambo();
                        //TODO: make validator class and validate in userSelector
                        if ((rock.CompareTo(roshambo)) == 0)
                        {
                            Console.WriteLine($"{userSelector.Name} chose {roshambo}");
                            Console.WriteLine($"{rockSelector.Name} chose {rock}");
                            Console.WriteLine("Tie!");
                            tieCounter++;
                        }
                        else
                        {
                            if (roshambo == Roshambo.paper)
                            {
                                Console.WriteLine($"{userSelector.Name} chose {roshambo}");
                                Console.WriteLine($"{rockSelector.Name} chose {rock}");
                                Console.WriteLine("You Win!");
                                winCounter++;
                            }
                            else if (roshambo == Roshambo.scissors)
                            {
                                Console.WriteLine($"{userSelector.Name} chose {roshambo}");
                                Console.WriteLine($"{rockSelector.Name} chose {rock}");
                                Console.WriteLine("You Lose!");
                                lossCounter++;
                            }
                        }
                    }
                    else if (input == "random")
                    {
                        Roshambo rando = randomSelector.generateRoShambo();
                        Roshambo roshambo = userSelector.generateRoShambo();

                        if ((rando.CompareTo(roshambo)) == 0)
                        {
                            Console.WriteLine($"{userSelector.Name} chose {roshambo}");
                            Console.WriteLine($"{rockSelector.Name} chose {rando}");
                            Console.WriteLine("Tie!");
                            tieCounter++;
                        }
                        else
                        {
                            if (rando == Roshambo.rock)
                            {
                                if (roshambo == Roshambo.paper)
                                {
                                    Console.WriteLine($"{userSelector.Name} chose {roshambo}");
                                    Console.WriteLine($"{rockSelector.Name} chose {rando}");
                                    Console.WriteLine("You Win!");
                                    winCounter++;
                                }
                                else if (roshambo == Roshambo.scissors)
                                {
                                    Console.WriteLine($"{userSelector.Name} chose {roshambo}");
                                    Console.WriteLine($"{rockSelector.Name} chose {rando}");
                                    Console.WriteLine("You Lose!");
                                    lossCounter++;
                                }
                            }
                            else if (rando == Roshambo.paper)
                            {
                                if (roshambo == Roshambo.scissors)
                                {
                                    Console.WriteLine($"{userSelector.Name} chose {roshambo}");
                                    Console.WriteLine($"{rockSelector.Name} chose {rando}");
                                    Console.WriteLine("You Win!");
                                    winCounter++;
                                }
                                else if (roshambo == Roshambo.rock)
                                {
                                    Console.WriteLine($"{userSelector.Name} chose {roshambo}");
                                    Console.WriteLine($"{rockSelector.Name} chose {rando}");
                                    Console.WriteLine("You Lose!");
                                    lossCounter++;
                                }
                            }
                            else if (rando == Roshambo.scissors)
                            {
                                if (roshambo == Roshambo.rock)
                                {
                                    Console.WriteLine($"{userSelector.Name} chose {roshambo}");
                                    Console.WriteLine($"{rockSelector.Name} chose {rando}");
                                    Console.WriteLine("You Win!");
                                    winCounter++;
                                }
                                else if (roshambo == Roshambo.paper)
                                {
                                    Console.WriteLine($"{userSelector.Name} chose {roshambo}");
                                    Console.WriteLine($"{rockSelector.Name} chose {rando}");
                                    Console.WriteLine("You Lose!");
                                    lossCounter++;
                                }
                            }
                        }
                    } 
                }
                else
                {
                    Console.WriteLine("Invalid input, we'll restart");
                    continue;
                }
                truth = Continue();
            }
            Console.WriteLine($"The amount of Wins during this session was {winCounter}.");
            Console.WriteLine($"The amount of Losses during this session was {lossCounter}.");
            Console.WriteLine($"The amount of Ties during this session was {tieCounter}.");
        }
        public static bool Continue()
        {
            while (true)
            {
                Console.Write("\t\t\t\t\t\tContinue? (y/n): ");

                string jump = Console.ReadLine().ToUpper();

                if (jump == "N")
                {
                    return false;
                }
                else if (jump == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Input was not \"y\" or \"n\"! Please try again!");
                    continue;
                }
            }
        }
    }
}
