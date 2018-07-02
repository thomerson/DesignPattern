using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    class Circle : Shape
    {
        private String key;


        public Circle(String key)
        {
            this.key = key;
        }

        public void draw()
        {
            Console.WriteLine("Key is " + key);
        }
    }
}
