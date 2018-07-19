using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式
{
    class Client
    {
        void Test()
        {
            Iterator iterator;
            IListCollection list = new ConcreteList();
            iterator = list.getIterator();

            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                Console.WriteLine(i.ToString());
                iterator.Next();
            }

        }
    }
}
