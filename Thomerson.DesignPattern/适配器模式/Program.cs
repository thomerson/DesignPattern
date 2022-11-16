using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerAdapter = new PowerAdapter();
            powerAdapter.TwoPower();

            powerAdapter.ThreePower();

            Console.WriteLine("Hello World!");
        }
    }
}
