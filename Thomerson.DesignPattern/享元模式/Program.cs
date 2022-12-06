using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    /// <summary>
    /// 线程池/连接池 等
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var circleKey = Guid.NewGuid().ToString();
            var circle = FlyweightFactory.getCircle(circleKey);
            circle.draw();
        }
    }
}
