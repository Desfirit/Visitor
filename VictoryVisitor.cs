using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class VictoryVisitor : Visitor
    {
        public void Visit(Warrior warrior)
        {
            Console.WriteLine("Warrior is winner");
            int exp = warrior.Stamina * 2 + warrior.Health;
            warrior.Experience = exp;
            Console.WriteLine("Warrior gain " + exp);
        }

        public void Visit(Wizard wizard)
        {
            Console.WriteLine("Wizard is winner");
            int exp = wizard.Mana * 5 + wizard.Health * 3;
            wizard.Experience = exp;
            Console.WriteLine("Wizard gain " + exp);
        }
    }
}
