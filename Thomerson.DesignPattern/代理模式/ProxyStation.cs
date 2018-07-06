using System;
using System.Collections.Generic;
using System.Text;

namespace 代理模式
{
    /// <summary>
    /// 代理售票点
    /// </summary>
    class ProxyStation : SaleTicket
    {
        private Station station;
        private String name;

        public ProxyStation(String name)
        {
            this.name = name;
        }

        public void Sale(string destination)
        {
            if (station == null)
            {
                station = new Station(name);
            }
            station.Sale(destination);
        }
    }
}
