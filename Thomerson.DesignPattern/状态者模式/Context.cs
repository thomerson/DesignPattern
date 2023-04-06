namespace 状态模式
{
    class Context
    {
        private State state { get; set; }


        public void SetState(State state)
        {
            this.state = state;
        }

        public void DoAction()
        {
            state?.Action(this);
        }
    }
}
