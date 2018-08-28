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

/* ******
 * 当需要创建一个与已有对象类似的对象，或者当创建对象的成本比克隆更高时，使用原型模式。
 * ***/
