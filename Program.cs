using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Character> characters = new List<Character>();
            characters.Add(new Warrior());
            characters.Add(new Wizard());


            while (!characters.Any(a => a.IsDead))
            {
                for (int i = 0; i < characters.Count; ++i)
                    for (int j = 0; j < characters.Count; ++j)
                        if(i!=j)
                            characters[i].TakeDamage(characters[j].Attack());
            }

            VictoryVisitor victoryVisitor = new VictoryVisitor();

            for (int i = 0; i < characters.Count; ++i)
                if (!characters[i].IsDead)
                    characters[i].Accept(victoryVisitor);

            Console.ReadKey();
        }
    }
}
