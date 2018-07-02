using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式
{
    public class MonkeyKing : MonkeyKingPrototype
    {
        public MonkeyKing(string id) : base(id) { }

        public override MonkeyKingPrototype Clone()
        {
            //深copy 和 浅copy
            return (MonkeyKingPrototype)this.MemberwiseClone();
        }
    }
}
