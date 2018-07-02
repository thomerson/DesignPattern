using System;

namespace 建造者模式
{
    public abstract class Builder
    {

        public Computar Computar { get; set; }
        public abstract void BuildCpu();
        public abstract void BuildMainBoard();
    }
}
