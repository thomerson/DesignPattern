using System;

namespace 迭代器模式
{
    public class ConcreteList : IListCollection
    {
        Array collection;

        public Iterator getIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get { return collection.Length; }
        }
    }
}
