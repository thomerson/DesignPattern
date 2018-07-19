using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    public class Subject
    {

        private List<Observer> Observers = new List<Observer>() { };

        public void AddObserver(Observer observer)
        {
            Observers.Add(observer);
        }


        public void Update()
        {
            Console.WriteLine("Subject update");

            foreach (var item in Observers)
            {
                item.Listen();
            }
        }
    }
}
