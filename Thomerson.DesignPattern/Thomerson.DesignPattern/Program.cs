using System;

namespace Thomerson.DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var decorate = new 装饰者模式.Client();
            decorate.Test();
            Console.WriteLine("Hello World!");
        }
    }
}
