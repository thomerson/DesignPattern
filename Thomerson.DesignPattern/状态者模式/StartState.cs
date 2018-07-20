﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 状态者模式
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
