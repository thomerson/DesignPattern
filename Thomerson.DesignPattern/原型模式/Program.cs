using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            MonkeyKing monkeyKing = new MonkeyKing("齐天大圣");

            MonkeyKingPrototype prototype1 = monkeyKing.Clone();

            MonkeyKingPrototype prototype2 = monkeyKing.Clone();

            Console.WriteLine("Hello World!");
        }
    }
}
