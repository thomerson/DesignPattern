using System;
using System.Collections.Generic;
using System.Text;

namespace 访问者模式
{
    /// <summary>
    /// Visitor接口:定义了对每一个元素（Element）访问的行为，它的参数就是可以访问的元素
    /// 方法个数理论上来讲与元素个数（Element的实现类个数）是一样的
    /// 访问者模式要求元素类的个数不能改变
    /// </summary>
    interface IComputerPartVisitor
    {
        void visit(Computer computer);
        void visit(Mouse mouse);
        void visit(Keyboard keyboard);
        void visit(Monitor monitor);
    }
}
