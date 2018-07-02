using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式
{
    class BuilderWang : Builder
    {
        public override void BuildCpu()
        {
            this.Computar.CPU = "Inter";
        }

        public override void BuildMainBoard()
        {
            this.Computar.MainBoard = "Huasuo";
        }
    }
}
