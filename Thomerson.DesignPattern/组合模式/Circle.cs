using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式
{
    class Circle : Graphics
    {
        public Circle(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("画  Circle " + Name);
        }
    }
}
