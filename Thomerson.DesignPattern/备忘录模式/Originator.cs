using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    /// <summary>
    /// 管理者角色
    /// </summary>
    class Originator
    {
        private String state;

        public void setState(String state)
        {
            this.state = state;
        }

        public String getState()
        {
            return state;
        }

        public Memento saveStateToMemento()
        {
            return new Memento(state);
        }

        public void getStateFromMemento(Memento Memento)
        {
            state = Memento.getState();
        }
    }
}
