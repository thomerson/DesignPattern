using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰者模式
{
    class Accessories : Decorator
    {
        public Accessories(Phone phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();

            // 添加新的行为
            AddAccessories();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        public void AddAccessories()
        {
            Console.WriteLine("现在苹果手机有漂亮的挂件了");
        }
    }
}
