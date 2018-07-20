using System;
using System.Collections.Generic;
using System.Text;

namespace 状态者模式
{
    abstract class State
    {
        public abstract void Action(Context context);
    }
}
