using System;

namespace 状态模式
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
