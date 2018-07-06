using System;

namespace 代理模式
{
    /// <summary>
    /// 火车站售票处
    /// </summary>
    public class Station : SaleTicket
    {
        private String name;

        public Station(String name)
        {
            this.name = name;
        }

        public void Sale(string destination)
        {
            Console.WriteLine("您买了一张" + name + "到" + destination + "的票");
        }

    }
}
