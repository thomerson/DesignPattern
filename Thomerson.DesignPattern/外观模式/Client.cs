using System;
using System.Collections.Generic;
using System.Text;

namespace 外观模式
{
    /// <summary>
    /// 如果增加新的子系统可能需要修改外观类或客户端的源代码，这样就违背了”开——闭原则“
    /// 在以下情况下可以考虑使用外观模式：
    /// 外一个复杂的子系统提供一个简单的接口
    /// 提供子系统的独立性
    /// 在层次化结构中，可以使用外观模式定义系统中每一层的入口。其中三层架构就是这样的一个例子。
    /// </summary>

    class Client
    {
        private static RegistrationFacade facade = new RegistrationFacade();

        public void Test()
        {
            if (facade.RegisterCourse("设计模式", "Learning Hard"))
            {
                Console.WriteLine("选课成功");
            }
            else
            {
                Console.WriteLine("选课失败");
            }

            Console.Read();
        }
    }
}
