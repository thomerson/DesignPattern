using System;
using System.Collections.Generic;
using System.Text;

namespace 责任链模式
{
    class VicePresident : Approver
    {
        public VicePresident(string name) : base(name)
        {
        }

        public override void ApproverReuqest(PurchaseRequest request)
        {
            if (request.Amount < 20000.0)
            {
                Console.WriteLine("{0}-{1} approved the request of purshing {2}", this, Name, request.ProductName);
            }
            else if (NextApprover != null)
            {
                NextApprover.ApproverReuqest(request);
            }
        }
    }
}
