using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    class ShanghaiFactory : Factory
    {
        public override Yabo CreateYabo()
        {
            return new ShanghaiYabo();
        }

        public override Yajia CreateYajia()
        {
            return new ShanghaiYajia();
        }
    }
}
