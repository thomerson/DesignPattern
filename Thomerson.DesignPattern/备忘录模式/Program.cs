using System;

namespace 备忘录模式
{
    /// <summary>
    /// 意图：在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。
    /// 主要解决：所谓备忘录模式就是在不破坏封装的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态，这样可以在以后将对象恢复到原先保存的状态。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();
            originator.setState("State #1");
            originator.setState("State #2");
            careTaker.add(originator.saveStateToMemento());
            originator.setState("State #3");
            careTaker.add(originator.saveStateToMemento());
            originator.setState("State #4");

            Console.WriteLine("Current State: " + originator.getState());
            originator.getStateFromMemento(careTaker.get(0));
            Console.WriteLine("First saved State: " + originator.getState());
            originator.getStateFromMemento(careTaker.get(1));
            Console.WriteLine("Second saved State: " + originator.getState());

            Console.WriteLine("Hello World!");
        }
    }
}

/* ***************
 * 备忘录模式中主要有三类角色：
 * 发起人角色：记录当前时刻的内部状态，负责创建和恢复备忘录数据。
 * 备忘录角色：负责存储发起人对象的内部状态，在进行恢复时提供给发起人需要的状态。
 * 管理者角色：负责保存备忘录对象。
* ************/
