using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    public class User
    {
        public int MoneyCount { get; set; }

        public User(int amount)
        {
            MoneyCount = amount;
        }

    }
}
