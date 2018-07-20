using System;
using System.Collections.Generic;
using System.Text;

namespace 策略者模式
{
    class Context
    {
        private IStrategy Strategy;

        public void SetStrategy(IStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public void DoAction(int a, int b)
        {
            Strategy?.DoOperation(a, b);
        }
    }
}
