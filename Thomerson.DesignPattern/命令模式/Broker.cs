using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{

    /// <summary>
    /// 经纪人
    /// </summary>
    class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void takeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void placeOrders()
        {
            foreach (Order order in orderList)
            {
                order.execute();
            }
            orderList.Clear();
        }
    }
}
