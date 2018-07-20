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

/******************
 * 状态模式是策略模式的孪生兄弟，
 * 是因为它们的UML图是一样的，
 * 但意图却完全不一样，
 * 策略模式是让用户指定更换的策略算法，
 * 而状态模式是状态在满足一定条件下的自动更换，
 * 用户无法指定状态，最多只能设置初始状态。 
 * ************/