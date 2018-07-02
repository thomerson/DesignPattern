using System;

namespace 原型模式
{
    /// <summary>
    /// 当创建一个类的实例的过程很昂贵或很复杂，
    /// 并且我们需要创建多个这样类的实例时，
    /// 如果我们用new操作符去创建这样的类实例，
    /// 这未免会增加创建类的复杂度和耗费更多的内存空间，
    /// 因为这样在内存中分配了多个一样的类实例对象
    /// </summary>
    public abstract class MonkeyKingPrototype
    {
        public string Id { get; set; }
        public MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }

        public abstract MonkeyKingPrototype Clone();
    }
}
