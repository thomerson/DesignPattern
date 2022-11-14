using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new CarFactory();
            Product car = factory.Create();

            Factory phoneFactory = new PhoneFactory();
            Product phone = phoneFactory.Create();
        }
    }
}
