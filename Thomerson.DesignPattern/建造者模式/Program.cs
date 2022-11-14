using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder wang = new BuilderWang();
            wang.BuildCpu();
            wang.BuildMainBoard();

            Computar pc = wang.Computar;
        }
    }
}


/* *********
 * 当需要构建不同风格的对象，同时需要避免构造器重叠时使用生成器模式。
 * 与工厂模式的主要区别在于：当创建过程一步到位时，使用工厂模式，而当创建过程需要多个步骤时，使用生成器模式。
 * *************/
