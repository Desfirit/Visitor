using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Warrior : Character
    {
        public int Stamina { get; set; }

        public Warrior()
        {
            Stamina = 100;
        }
        public int SwordStrike()
        {

            if (Stamina > 0)
            {
                Stamina = Stamina - 20 > 0 ? Stamina - 4 : 0;
                return 10;
            }
            else
            {
                RecoverStamina();
                return 0;
            }
        }
        

        public void RecoverStamina()
        {
            Stamina += 15;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public override int Attack()
        {
            int damage = SwordStrike();
            Console.WriteLine("Warrior deal " + damage + " damage" );
            return damage;
        }
    }
}
