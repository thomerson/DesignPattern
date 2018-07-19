using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式
{
    /// <summary>
    /// // 迭代器抽象类
    /// </summary>
    public interface Iterator
    {
        bool MoveNext();
        Object GetCurrent();
        void Next();
        void Reset();
    }
}
