using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰者模式
{
    /// <summary>
    /// 装饰抽象类,要让装饰完全取代抽象组件，所以必须继承自Phone
    /// </summary>
    abstract class Decorator : Phone
    {
        private Phone Phone { get; set; }

        public Decorator(Phone phone)
        {
            this.Phone = phone;
        }
        public override void Print()
        {
            if (this.Phone != null)
            {
                this.Phone.Print();
            }
        }
    }
}
