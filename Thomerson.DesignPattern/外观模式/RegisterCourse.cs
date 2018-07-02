using System;

namespace 外观模式
{
    // 相当于子系统A
    public class RegisterCourse
    {
        public bool CheckAvailable(string courseName)
        {
            Console.WriteLine("正在验证课程 {0}是否人数已满", courseName);
            return true;
        }
    }
}
