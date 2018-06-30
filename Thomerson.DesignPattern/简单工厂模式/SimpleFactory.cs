using System;

namespace 简单工厂模式
{
    public class SimpleFactory
    {
        public Product Create(string name)
        {
            if (name == "car")
            {
                return new Car();
            }
            if (name == "Phone")
            {
                return new Phone();
            }
            return null;
        }
    }
}
