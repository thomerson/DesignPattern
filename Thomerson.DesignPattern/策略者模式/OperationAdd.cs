﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 策略者模式
{
    class OperationAdd : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
