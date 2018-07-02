using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式
{
    class BuilderZhao : Builder
    {
        public override void BuildCpu()
        {
            this.Computar.CPU = "ADM";
        }

        public override void BuildMainBoard()
        {
            this.Computar.MainBoard = "ADM";
        }
    }
}
