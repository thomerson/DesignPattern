using System;

namespace 状态模式
{
    class StopState : State
    {
        public override void Action(Context context)
        {
            Console.WriteLine("end");
        }
    }
}
