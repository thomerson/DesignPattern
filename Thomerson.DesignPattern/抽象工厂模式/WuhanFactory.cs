using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    public class WuhanFactory : Factory
    {
        public override Yabo CreateYabo()
        {
            return new WuhanYabo();
        }

        public override Yajia CreateYajia()
        {
            return new WuhanYajia();
        }
    }
}
