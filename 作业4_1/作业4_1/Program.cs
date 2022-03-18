using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 作业4_1

/*d1. 写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。
提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
要求：
（1）使用LINQ实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
*/
{
    class Program
    {
        public static List<Order> allOrders = new List<Order>();

        static void Main(string[] args)
        {
            bool ifNotExit = true;
            while (ifNotExit)
            {
                if (File.Exists("order.xml"))
                {
                    OrderServices os = new OrderServices();
                    allOrders = os.Import();
                }
                Console.WriteLine("1:add item      2:delete item   3:check item    4:show detail   5:exit");
                string user1 = Console.ReadLine();
                switch (user1)
                {
                    case "1":
                        int orderId = allOrders.Count() + 1;
                        Console.WriteLine("enter user name:");
                        string username = Console.ReadLine();
                        OrderServices os = new OrderServices();
                        allOrders.Add(os.AddOrder(orderId, username));
                        break;

                    case "2":
                        Console.WriteLine("enter delete item id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        OrderServices os1 = new OrderServices();
                        allOrders = os1.RemoveOrder(allOrders, id);
                        os1.Export(allOrders);  //save
                        break;

                    case "3":
                        Console.WriteLine("1:check by $~$ range，2：check by id");
                        int i = Convert.ToInt32(Console.ReadLine());
                        OrderServices os2 = new OrderServices();
                        if (i == 1)
                        {
                            Console.WriteLine("enter max amonut：");
                            int maxnum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter min amount：");
                            int minnum = Convert.ToInt32(Console.ReadLine());
                            os2.SearchOrderByMoney(minnum, maxnum, allOrders);
                        }
                        else if (i == 2)
                        {
                            Console.WriteLine("enter name：");
                            string name = Console.ReadLine();
                            os2.SearchOrderByName(name, allOrders);
                        }
                        break;
                    case "4":
                        OrderServices od3 = new OrderServices();
                        od3.ShowOrder(allOrders);
                        break;
                    case "5":
                        System.Environment.Exit(0);
                        break;
                    default: Console.WriteLine("error"); break;
                }
            }
        }
    }
}
