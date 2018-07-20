using System;
using System.Collections.Generic;
using System.Text;

namespace 状态者模式
{
    class StopState : State
    {
        public override void Action()
        {
            Console.WriteLine("end");
        }
    }
}
