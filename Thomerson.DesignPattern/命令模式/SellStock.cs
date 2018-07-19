using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    class SellStock : Order
    {
        private Stock abcStock;
        public SellStock(Stock stock)
        {
            this.abcStock = stock;
        }
        public void execute()
        {
            abcStock.sell();
        }
    }
}
