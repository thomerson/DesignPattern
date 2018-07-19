using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 股票
    /// </summary>
    class Stock
    {
        private String name = "ABC";
        private int quantity = 10;

        public void buy()
        {
            Console.WriteLine("Stock [ Name: " + name + ",  Quantity: " + quantity + " ] bought");
        }
        public void sell()
        {
            Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity + " ] sold");
        }
    }
}
