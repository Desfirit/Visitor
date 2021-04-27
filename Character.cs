using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Character
    {
        public int Health { get;set; }
        public int Level { get;set; }

        public int Experience { get; set; }

        public bool IsDead { get; set; }

        public void Die()
        {
            Console.WriteLine("It was my last breath...");
            IsDead = true;
        }

        public Character()
        {
            Health = 100;
            Level = 1;
            Experience = 0;
            IsDead = false;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
                Die();
        }

        public abstract int Attack();

        public abstract void Accept(Visitor visitor);

    }
}
