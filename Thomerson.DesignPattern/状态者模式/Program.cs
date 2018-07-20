using System;

namespace 状态者模式
{
    /// <summary>
    /// 状态模式:允许一个对象在其内部状态改变时自动改变其行为，对象看起来就像是改变了它的类。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            context.SetState(new StartState());
            context.DoAction();

            context.SetState(new StopState());
            context.DoAction();

            Console.ReadLine();
        }
    }
}
