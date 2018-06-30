using System;

namespace 单例模式
{
    /// <summary>
    /// 它只有一个实例
    /// 向外提供访问点
    /// </summary>
    public class Signleton
    {
        private Signleton() { }

        private static Signleton instance;

        /// <summary>
        /// 多线程访问
        /// </summary>
        private static object locker = new object();

        public Signleton GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Signleton();
                    }
                }
            }
            return instance;
        }
    }
}
