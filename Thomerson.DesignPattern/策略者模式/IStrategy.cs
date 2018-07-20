using System;
using System.Collections.Generic;
using System.Text;

namespace 策略者模式
{
    interface IStrategy
    {
        int DoOperation(int num1, int num2);
    }
}
