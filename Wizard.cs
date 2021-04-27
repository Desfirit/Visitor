using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Wizard : Character
    {
        public int Mana { get; set; }

        public Wizard()
        {
            Mana = 20;
        }
        public int CastSpell()
        {
            
            if (Mana - 4 > 0)
            {
                Mana = Mana - 4 > 0 ? Mana - 4 : 0;
                return 15;
            }
            else
            {
                RecoverMana();
                return 0;
            }
        }


        public void RecoverMana()
        {
            Mana += 2;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public override int Attack()
        {
            int damage = CastSpell();
            Console.WriteLine("Wizard deal " + damage + " damage");
            return damage;
        }
    }
}
