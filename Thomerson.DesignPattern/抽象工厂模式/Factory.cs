using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    public abstract class Factory
    {
        public abstract Yabo CreateYabo();
        public abstract Yajia CreateYajia();
    }
}
