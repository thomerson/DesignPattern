using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}
