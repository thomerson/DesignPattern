using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式
{
    public abstract class Pen
    {
        public Color Color { get; set; }

        public void SetColor(Color color)
        {
            this.Color = color;
        }
        public abstract void Write();
    }
}
