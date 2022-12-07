using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式
{
    public class TerminalExpression : IExpression
    {

        private String data;

        public TerminalExpression(String data)
        {
            this.data = data;
        }

        public bool Interpret(String context)
        {
            if (context.Contains(data))
            {
                return true;
            }
            return false;
        }
    }
}
