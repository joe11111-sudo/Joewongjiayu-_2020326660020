using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace 作业4_1
{
    [Serializable]
    class OrderServices
    {
        public void Export(List<Order> order)   //object->xml
        {
            XmlSerializer serializar = new XmlSerializer(typeof(List<Order>));
            using (FileStream theXmlFileToCreate = new FileStream("order.xml", FileMode.Create))
            {
                serializar.Serialize(theXmlFileToCreate, order);
            }
        }

        public List<Order> Import()    //xml->object
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream XmlFile = new FileStream("order", FileMode.Open))
            {
                List<Order> deserializedObjects = (List<Order>)serializer.Deserialize(XmlFile);
                return deserializedObjects;
            }
        }
        public void ShowOrder(List<Order> order)
        {
            Console.WriteLine("order number customer amount");
            Console.WriteLine("____________________________");
            foreach(Order ShowOrder in order)
            {
                Console.WriteLine("{0}  | {1} |  {2}", ShowOrder.id, ShowOrder.customerName, ShowOrder.amount);
                Console.WriteLine("\n");
                ShowOrder.showOrderItem();
                Console.WriteLine("\n");
            }
        }

        public Order AddOrder(int id, string customerName)
        {
            Order addorder = new Order(id, customerName);
            Console.WriteLine("order detail:");
            bool judge = true;
            while (judge)
            {
                Console.WriteLine("insert Product name:");
                string name = Console.ReadLine();
                Console.WriteLine("insert volume:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cost per unit:");
                double price = Convert.ToDouble(Console.ReadLine());
                addorder.addItemToOrder(name, num, price);
                Console.WriteLine("Y/N to continue add items");
                string x = Console.ReadLine();
                if(x =="n" || x =="N")
                {
                    judge = false;
                }else if(x=="y" || x == "Y")
                {
                    continue;
                }
                else
                {
                    Exception e = new Exception();
                    throw e;
                }
            }
            addorder.getAllPrice();
            Console.WriteLine("proceed");
            return addorder;

        }

        public List<Order> RemoveOrder(List<Order>order,int id)
        {
            int index = 0;
            foreach(Order OrderRemove in order)
            {
                if (OrderRemove.id == id) index = order.IndexOf(OrderRemove);
            }
            Console.WriteLine("1:remove list , 2:continue romove list detail");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    order.RemoveAt(index);
                    Console.WriteLine("deleted");
                    break;
                case 2:
                    order[index].showOrderItem();
                    order[index].removeItemFromOrder(id);
                    break;
                default: 
                    Console.WriteLine("error");
                    break;
            }
            return order;
        }

        public void SearchOrderByMoney(int minNum,int maxNum, List<Order> order)
        {
            try
            {
                var query1 = from s1 in order
                             where maxNum > s1.amount
                             orderby s1.amount
                             select s1;

                var query3 = from s3 in query1
                             where s3.amount > minNum
                             orderby s3.amount
                             select s3;

                List<Order> requiredOrderList = query3.ToList();
                Console.WriteLine("Id    customer   amount");
                Console.WriteLine("_______________________");
                foreach (Order requireOrder in requiredOrderList)
                {
                    Console.WriteLine("{0}   {1}   {2}", requireOrder.id, requireOrder.customerName, requireOrder.amount);
                    requireOrder.showOrderItem();
                    Console.WriteLine("\n");
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
        }

        public void SearchOrderByName(string customerName, List<Order> orders)
        {
            var query2 = from s2 in orders
                         where s2.customerName == customerName
                         orderby s2.amount
                         select s2;
            List<Order> requiredOrderList = query2.ToList();
            if (requiredOrderList.Count() == 0)
            {
                Console.WriteLine("查无此用户");
            }
            Console.WriteLine("订单号 客户 总金额");
            Console.WriteLine("--------------------------------");
            foreach (Order requireOrder in requiredOrderList)
            {
                Console.WriteLine("{0}      {1}   :{2}", requireOrder.id, requireOrder.customerName, requireOrder.amount);
                requireOrder.showOrderItem();
                Console.WriteLine("\n");
            }
        }
    }
}
