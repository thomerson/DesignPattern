using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式
{
    class MiddlePen : Pen
    {
        public override void Write()
        {
            Console.WriteLine("this is a middle pen with " + nameof(Color) + " color");
        }
    }
}
