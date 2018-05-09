using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class UserSelector : Player
    {
        private string name;
        private Roshambo roshamboValue;

        public string Name { get => name; set => name = value; }
        public Roshambo RoshamboValue { get => roshamboValue; set => roshamboValue = value; }

        public UserSelector()
        {
            while (true)
            {
                Console.Write("What is your name?: ");
                string nam = Console.ReadLine();

                if (!Validator.IntChecker(nam) && !Validator.SpaceEnterChecker(nam))
                {
                    Name = nam;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a name below!\n\n");
                    continue;
                }
            }
        }

        public override Roshambo generateRoShambo()
        {
            Roshambo blah;
            while (true)
            {
                Console.Write("Which do you select? Rock(1), paper(2),  or scissors(3). Please enter 1-3: ");
                string input = Console.ReadLine();
                if (Validator.IntChecker(input))
                {
                    int number = int.Parse(input);
                    blah = (Roshambo)number-1;
                    if (number == 1)
                    {
                        return Roshambo.rock;
                    }
                    else if (number == 2)
                    {
                        return Roshambo.paper;
                    }
                    else if (number == 3)
                    {
                        return Roshambo.scissors;
                    }
                    else if (number <= 0 || number > 3)
                    {
                        Console.WriteLine("\n\nNot a number in range! Let's try again.\n");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("\n\nNot a number! Let's try again.\n");
                    continue;
                }

            }
        }

    }   
}
