using System;

namespace 责任链模式
{
    public abstract class Approver
    {

        public string Name { get; set; }

        public Approver(string name)
        {
            this.Name = name;
        }

        //责任链中的下一个元素
        public Approver NextApprover;

        public void setNextLogger(Approver nextApprover)
        {
            this.NextApprover = nextApprover;
        }

        public abstract void ApproverReuqest(PurchaseRequest request);

    }
}
