using System;

namespace 中介者模式
{
    public class Client
    {
        static void Main()
        {
            var seller = new User(1000);
            var buyer = new User(5000);

            var mediator = new Mediator(seller, buyer);

            mediator.Deal(300);

            Console.WriteLine(seller.MoneyCount);
            Console.WriteLine(buyer.MoneyCount);
            Console.ReadLine();
        }
    }
}
