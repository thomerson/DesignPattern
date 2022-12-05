using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.draw();
            greenCircle.draw();

            Console.WriteLine("Hello World!");
        }
    }

    public interface IDraw
    {
        void DrawCircle(int radius, int x, int y);
    }

    public abstract class Shape
    {
        protected IDraw Draw;
        public Shape(IDraw draw)
        {
            this.Draw = draw;
        }
        public abstract void draw();
    }

    public class Circle : Shape
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, IDraw draw)
            : base(draw)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void draw()
        {
            Draw.DrawCircle(radius, x, y);
        }
    }

    public class RedCircle : IDraw
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: "
               + radius + ", x: " + x + ", " + y + "]");
        }
    }

    public class GreenCircle : IDraw
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: "
           + radius + ", x: " + x + ", " + y + "]");
        }
    }
}
