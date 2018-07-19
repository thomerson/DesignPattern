using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式
{
    class ConcreteIterator : Iterator
    {
        private int _index;
        private ConcreteList _list;

        public ConcreteIterator(ConcreteList list)
        {
            _list = list;
            _index = 0;
        }

        public object GetCurrent()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            if (_index < _list.Length)
            {
                _index++;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
