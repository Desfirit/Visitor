using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class MoveVisitor : Visitor
    {
        public void Visit(Warrior warrior)
        {
            
        }

        public void Visit(Wizard wizard)
        {
            throw new NotImplementedException();
        }
    }
}
