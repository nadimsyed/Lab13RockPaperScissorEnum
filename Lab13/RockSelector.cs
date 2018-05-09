using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class RockSelector : Player
    {
        private string name;
        private Roshambo roshamboValue;

        public string Name { get => name; set => name = value; }
        public Roshambo RoshamboValue { get => roshamboValue; set => roshamboValue = value; }

        public RockSelector()
        {
            Name = "Dwayne Johnson";
        }

        public override Roshambo generateRoShambo()
        {
            return Roshambo.rock;
        }
    }
}
