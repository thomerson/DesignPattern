using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式
{
    class PowerAdapter : TwoHole, IThreeHole
    {
        public void ThreePower()
        {
            Console.WriteLine("我是3个孔的插头");
        }
    }
}
