using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式.Delegate
{
    /// <summary>
    /// 显示器
    /// </summary>
    class Displayer
    {
        //public void Show(int temperature)
        public void Show(Object sender, MyEventArgs e)
        {
            //如果我们不光想获得热水器的温度，
            //还想在Observer端(警报器或者显示器)方法中获得它的生产日期、型号、价格，
            //那么委托和方法的声明都会变得很麻烦，而如果我们将热水器的引用传给警报器的方法，就可以在方法中直接访问热水器了。
            var heater = sender as Heater;
            Console.WriteLine(heater.name);


            Console.WriteLine("Display：水已烧开，当前温度：{0}度。", e.temperature);
        }
    }
}
