using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式.Delegate
{
    //
    public delegate void BoilEventHander(int temprature);

    /// <summary>
    /// 热水器
    /// </summary>
    class Heater
    {
        public int Temperature { get; set; }

        public string name { get; set; }

        /// <summary>
        /// EventHandler 没有用event修饰
        /// </summary>
        //public BoilEventHander BoilEvent;

        //public event BoilEventHander BoilEvent;//with event 

        //        .Net Framework中的委托与事件
        //尽管上面的范例很好地完成了我们想要完成的工作，但是我们不仅疑惑：为什么.Net Framework 中的事件模型和上面的不同？为什么有很多的EventArgs参数？

        //在回答上面的问题之前，我们先搞懂.Net Framework的编码规范：

        //委托类型的名称都应该以EventHandler结束。
        //委托的原型定义：有一个void返回值，并接受两个输入参数：一个Object 类型，一个 EventArgs类型(或继承自EventArgs)。
        //事件的命名为 委托去掉 EventHandler之后剩余的部分。
        //继承自EventArgs的类型应该以EventArgs结尾。
        //再做一下说明：

        //委托声明原型中的Object类型的参数代表了Subject，也就是监视对象，在本例中是 Heater(热水器)。回调函数(比如Alarm的MakeAlert)可以通过它访问触发事件的对象(Heater)。
        //EventArgs 对象包含了Observer所感兴趣的数据。
        //EventHandler泛型 
        public event EventHandler<MyEventArgs> DotnetBoilEvent;

        //public void HeaterWater()
        public void HeaterWater()
        {
            for (int i = 0; i < 100; i++)
            {
                Temperature = i;

                if (Temperature > 95)
                {
                    //BoilEvent(Temperature);
                    //DotnetBoilEvent?.Invoke(this, args);
                    OnTemeratureChange(new MyEventArgs(Temperature));
                }
            }
        }

        private void OnTemeratureChange(MyEventArgs args)
        {
            DotnetBoilEvent?.Invoke(this, args);
        }
    }

    public class MyEventArgs : EventArgs
    {

        public MyEventArgs(int temperature)
        {
            this.temperature = temperature;
        }
        public int temperature { get; set; }
    }
}
