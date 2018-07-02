using System;
using System.Collections.Generic;
using System.Text;

namespace 外观模式
{
    // 相当于子系统B
    class NotifyStudent
    {
        public bool Notify(string studentName)
        {
            Console.WriteLine("正在向{0}发生通知", studentName);
            return true;
        }
    }
}
