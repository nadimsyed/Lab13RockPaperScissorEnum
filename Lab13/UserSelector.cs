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
            Console.Write("What is your name?: ");
            string nam = Console.ReadLine();

            if (!Validator.IntChecker(nam))
            {
                Name = nam;
            }
        }

        public override Roshambo generateRoShambo()
        {
            //Do below code in main, then pass in string. Validate string before bringing it in.
            //Nevermind, can't pass in string since abstract class didnt have argument in method
            
            Console.Write("Which do you select? Rock(1), paper(2),  or scissors(3). Please enter 1-3: ");
            string input = Console.ReadLine();
            //TODO: Make a validator class that does the int validation for me instead of here. Validate before being
            //      passed in.
            
            if (Validator.IntChecker(input))
            {
                int number = int.Parse(input);
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
            }
            return Roshambo.rock;
        }

    }   
}
