using System;
using System.Collections.Generic;
using System.Text;

namespace 代理模式
{
    /// <summary>
    /// 注意事项： 
    /// 1、和适配器模式的区别：适配器模式主要改变所考虑对象的接口，而代理模式不能改变所代理类的接口。 
    /// 2、和装饰器模式的区别：装饰器模式为了增强功能，而代理模式是为了加以控制。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var station = new ProxyStation("上海站");

            //售票
            station.Sale("无锡站");


            station = new ProxyStation("苏州站");

            //售票
            station.Sale("杭州站");
        }
    }
}
