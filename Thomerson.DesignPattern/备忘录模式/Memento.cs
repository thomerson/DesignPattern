using System;

namespace 备忘录模式
{
    /// <summary>
    /// 备忘录角色
    /// </summary>
    class Memento
    {
        private String state;

        public Memento(String state)
        {
            this.state = state;
        }

        public String getState()
        {
            return state;
        }
    }
}



