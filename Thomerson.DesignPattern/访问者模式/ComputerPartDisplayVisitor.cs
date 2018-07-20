using System;
using System.Collections.Generic;
using System.Text;

namespace 访问者模式
{
    class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer.");
        }

        public void visit(Mouse mouse)
        {
            Console.WriteLine("Displaying mouse.");
        }

        public void visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying keyboard.");
        }

        public void visit(Monitor monitor)
        {
            Console.WriteLine("Displaying monitor.");
        }
    }
}
