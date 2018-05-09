using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class RandomSelector : Player
    {
        private string name;
        private Roshambo roshamboValue;

        public string Name { get => name; set => name = value; }
        public Roshambo RoshamboValue { get => roshamboValue; set => roshamboValue = value; }

        public RandomSelector()
        {
            Name = "Rando";
        }

        public override Roshambo generateRoShambo()
        {
            Random rnd = new Random();
            int ro = rnd.Next(0, 2);
            return (Roshambo)ro;

            //if(ro == 1)
            //{
            //    return Roshambo.rock;
            //}
            //else if ( ro == 2)
            //{
            //    return Roshambo.paper;
            //}
            //else if (ro == 3)
            //{
            //    return Roshambo.scissors;
            //}
            //return Roshambo.rock;
        }
    }
}
