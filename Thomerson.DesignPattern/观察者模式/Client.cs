﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    class Client
    {
        void Test()
        {
            var subject1 = new Subject() { };

            var observer_A = new Observer("A");

            var observer_B = new Observer("B");

            var observer_C = new Observer("C");

            subject1.AddObserver(observer_A);
            subject1.AddObserver(observer_B);
            subject1.AddObserver(observer_C);

            subject1.Update();
        }
    }
}
