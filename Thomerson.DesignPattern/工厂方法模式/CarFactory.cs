using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式
{
    class CarFactory : Factory
    {
        public override Product Create()
        {
            return new Car();
        }
    }
}
