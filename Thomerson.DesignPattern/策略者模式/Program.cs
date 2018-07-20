using System;

namespace 策略者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.SetStrategy(new OperationAdd());
            context.DoAction(4, 5);

            context.SetStrategy(new OperationSubstract());
            context.DoAction(4, 5);
            Console.WriteLine("Hello World!");
        }
    }
}
