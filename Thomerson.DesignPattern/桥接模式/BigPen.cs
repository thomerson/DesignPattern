using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式
{
    class BigPen : Pen
    {
        public override void Write()
        {
            Console.WriteLine("this is a big pen with " + nameof(Color) + " color");
        }
    }
}
