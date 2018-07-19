using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式.Delegate
{
    /// <summary>
    /// 假设我们有个高档的热水器，我们给它通上电，当水温超过95度的时候：
    /// 1、扬声器会开始发出语音，告诉你水的温度；
    /// 2、液晶屏也会改变水温的显示，来提示水已经快烧开了。
    /// </summary>
    class Client
    {
        //Observer设计模式中主要包括如下两类对象：

        //Subject：监视对象，它往往包含着其他对象所感兴趣的内容。在本范例中，热水器就是一个监视对象，它包含的其他对象所感兴趣的内容，就是temprature字段，当这个字段的值快到100时，会不断把数据发给监视它的对象。
        //Observer：监视者，它监视Subject，当Subject中的某件事发生的时候，会告知Observer，而Observer则会采取相应的行动。在本范例中，Observer有警报器和显示器，它们采取的行动分别是发出警报和显示水温。

        void Test()
        {
            var heater = new Heater();

            // The event 'Heater.BoilEvent' can only appear on the left hand side of += or -= (except when used from within the type 'Heater')	
            //heater.BoilEvent = new Alarm().Alert; //用event修饰后 不能在Subject外面使用赋值,只能注册或者移除注册
            //heater.BoilEvent += new Alarm().Alert;
            //heater.BoilEvent += new Displayer().Show;

            heater.DotnetBoilEvent += new Alarm().Alert;
            heater.DotnetBoilEvent += new Displayer().Show;

            heater.HeaterWater();
        }

    }
}
