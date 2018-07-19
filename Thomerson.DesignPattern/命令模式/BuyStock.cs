using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    class BuyStock : Order
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.buy();
        }
    }
}
