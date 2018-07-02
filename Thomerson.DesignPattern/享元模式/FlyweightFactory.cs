using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    class FlyweightFactory
    {
        private static Dictionary<String, Shape> Dict = new Dictionary<String, Shape>();

        public static Shape getCircle(String key)
        {
            if (Dict.ContainsKey(key))
            {
                return Dict[key];
            }

            var circle = new Circle(key);
            Dict.Add(key, circle);

            return circle;
        }
    }
}
