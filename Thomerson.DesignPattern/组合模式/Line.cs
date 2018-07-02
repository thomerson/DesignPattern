using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式
{
    class Line : Graphics
    {
        public Line(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("画  Line " + Name);
        }
    }
}
