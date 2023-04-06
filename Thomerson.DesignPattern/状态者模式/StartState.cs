using System;

namespace 状态模式
{
    class StartState : State
    {
        public override void Action(Context context)
        {
            Console.WriteLine("start to work");
            context.SetState(new WorkState());
        }
    }
}
