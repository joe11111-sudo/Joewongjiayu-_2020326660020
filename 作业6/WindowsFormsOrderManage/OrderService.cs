﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsOrderManage
{
    public class OrderService
    {
        public List<Order> OrderList { get; set; }

        public OrderService()
        {
            try
            {
                Import("orders.xml");
            }
            catch(FileNotFoundException)
            {
                OrderList = new List<Order>();     
            }
        }

        public void AddOrder(Order order)
        {
            OrderList.Add(order);
        }

        public void AddOrderItem(Order order, OrderItem orderItem)
        {
            try
            {
                order.AddOrderItem(orderItem);
            }
            catch(ApplicationException e)
            {
                throw e;
            }
        }


        public void RemoveOrder(long orderID)
        {
         
            Order order = QueryByOrderID(orderID);

            if(order == null)
            {
                throw new ApplicationException("Error: No such order");
            }
            else
            {
                OrderList.Remove(order);
            }
        }

        
        public void RemoveOrder(Order order)
        {
            OrderList.Remove(order);
        }

        public void RemoveOrderItem(Order order, OrderItem orderItem)
        {
            try
            {
                order.RemoveOrderItem(orderItem);
            }
            catch(ApplicationException e)
            {
                throw e;
            }
        }

       
   
        public void ModifyOrder(long orderID, int type, string modifiedContent)
        {        
            Order order = QueryByOrderID(orderID);

            if(order == null)
            {
                throw new ApplicationException("Error: No such order");
            }

            switch(type)
            {
                case 1:
                    order.CustomerName = modifiedContent;
                    break;
                case 2:
                    order.Address = modifiedContent;
                    break;
            }
        }

      
        public void ModifyOrder(Order order, int type, string modifiedContent)
        {
            switch(type)
            {
                case 1:
                    order.CustomerName = modifiedContent;
                    break;
                case 2:
                    order.Address = modifiedContent;
                    break;
            }
        }

      
        public void ModifyOrder(Order order, Order newOrder)
        {
            order = newOrder;
        }

        
        public Order QueryByOrderID(long orderID)
        {

            var query = OrderList.Where(x => x.OrderID == orderID).OrderBy(s => s.TotalPrice);

            return query.FirstOrDefault();
        }

   
        public List<Order> QueryByProductName(string queryContent)
        {
            var query = OrderList.Where(x => x.OrderItemList.Exists(y => y.ProductName.Contains(queryContent))).OrderBy(s => s.TotalPrice);

            return query.ToList();
        }

 
        public List<Order> QueryByCustomerName(string queryContent)
        {
           
            var query = OrderList.Where(x => x.CustomerName.Contains(queryContent)).OrderBy(s => s.TotalPrice);

            return query.ToList();
        }

        public void SortOrderList()
        {
            OrderList.Sort((x, y) => (int)(x.OrderID - y.OrderID));
        }

   
        public void SortOrderList(Func<Order, Order, int> sortAction)
        {
            OrderList.Sort((x, y) => sortAction(x, y));
        }

    
        public void Export(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, OrderList);
            }
        }

        //从XML文件中载入订单
        public void Import(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

            try
            {
                using(FileStream fs = new FileStream(path, FileMode.Open))
                {
                    OrderList = (List<Order>)xmlSerializer.Deserialize(fs);
                }
            }
            catch(FileNotFoundException e)
            {
                throw e;
            }
        }
    }
}
