using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    /// <summary>
    /// 中介
    /// </summary>
    class Mediator
    {
        private User seller { get; set; }
        private User buyer { get; set; }
        public Mediator(User seller, User buyer)
        {
            this.seller = seller;
            this.buyer = buyer;
        }

        //成交
        public void Deal(int amount)
        {
            seller.MoneyCount += amount;
            buyer.MoneyCount -= amount;
        }

    }
}
