using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式
{
    class PhoneFactory : Factory
    {
        public override Product Create()
        {
            return new Phone();
        }
    }
}
