using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式
{
    /// <summary>
    /// 复杂图形，由一些简单图形组成,这里假设该复杂图形由一个圆两条线组成的复杂图形
    /// </summary>
    class ComplexGraphics : Graphics
    {
        public ComplexGraphics(string name) : base(name)
        {
        }

        private List<Graphics> complexGraphicsList = new List<Graphics>();

        /// <summary>
        /// 复杂图形的画法
        /// </summary>
        public override void Draw()
        {
            foreach (Graphics g in complexGraphicsList)
            {
                g.Draw();
            }
        }

        public void Add(Graphics g)
        {
            complexGraphicsList.Add(g);
        }
        public void Remove(Graphics g)
        {
            complexGraphicsList.Remove(g);
        }
    }
}
