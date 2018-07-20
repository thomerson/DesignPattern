using System;
using System.Collections.Generic;
using System.Text;

namespace 状态者模式
{
    class WorkState : State
    {
        public override void Action(Context context)
        {
            Console.WriteLine("end");
            context.SetState(new StopState());
        }
    }
}
