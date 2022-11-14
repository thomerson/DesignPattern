using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory shanghaiFactory = new ShanghaiFactory();
            Product shanghaiYabo = shanghaiFactory.CreateYabo();
            Product shanghaiYajia = shanghaiFactory.CreateYajia();


            Factory wuhanFactory = new WuhanFactory();
            Product wuhanYabo = wuhanFactory.CreateYabo();
            Product wuhanYajia = wuhanFactory.CreateYajia();

        }
    }
}
