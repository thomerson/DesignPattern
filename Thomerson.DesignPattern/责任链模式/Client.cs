using System;
using System.Collections.Generic;
using System.Text;

namespace 责任链模式
{
    /// <summary>
    /// 一个系统的审批需要多个对象才能完成处理的情况下，例如请假系统等。
    /// 代码中存在多个if-else语句的情况下，此时可以考虑使用责任链模式来对代码进行重构。
    /// </summary>
    class Client
    {
        void Test()
        {
            PurchaseRequest requestTelphone = new PurchaseRequest(4000.0, "Telphone");
            PurchaseRequest requestSoftware = new PurchaseRequest(10000.0, "Visual Studio");
            PurchaseRequest requestComputers = new PurchaseRequest(40000.0, "Computers");

            Approver manager = new Manager("LearningHard");
            Approver Vp = new VicePresident("Tony");
            Approver Pre = new President("BossTom");

            // 设置责任链
            manager.NextApprover = Vp;
            Vp.NextApprover = Pre;

            // 处理请求
            manager.ApproverReuqest(requestTelphone);
            manager.ApproverReuqest(requestSoftware);
            manager.ApproverReuqest(requestComputers);
            Console.ReadLine();
        }
    }
}
