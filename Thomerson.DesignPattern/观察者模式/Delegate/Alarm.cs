using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式.Delegate
{
    /// <summary>
    /// 警报器
    /// </summary>
    public class Alarm
    {
        //public void Alert(int temperature)
        public void Alert(Object sender, MyEventArgs e)
        {
            var heater = sender as Heater;

            Console.WriteLine(heater.name);

            Console.WriteLine("Alarm：嘀嘀嘀，水已经 {0} 度了：", e.temperature);
        }
    }
}
