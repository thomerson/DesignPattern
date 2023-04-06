using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    /// <summary>
    /// 管理员，看管人
    /// </summary>
    class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento get(int index)
        {
            return mementoList[index];
        }
    }
}
