using System;

namespace 观察者模式
{
    public class Observer
    {
        public Observer(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public void Listen()
        {
            Console.WriteLine(Name);
        }
    }
}
