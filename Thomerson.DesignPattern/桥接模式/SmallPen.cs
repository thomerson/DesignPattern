using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式
{
    class SmallPen : Pen
    {
        public override void Write()
        {
            Console.WriteLine("this is a small pen with " + nameof(Color) + " color");
        }
    }
}
