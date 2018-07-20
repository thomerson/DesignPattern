using System;
using System.Collections.Generic;
using System.Text;

namespace 访问者模式
{
    class Keyboard : IComputerPart
    {
        public void accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
