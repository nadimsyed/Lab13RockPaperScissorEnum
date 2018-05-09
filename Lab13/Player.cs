using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    abstract class Player
    {
        private string name;
        private Roshambo roshamboValue;

        abstract public Roshambo generateRoShambo();

    }
}
