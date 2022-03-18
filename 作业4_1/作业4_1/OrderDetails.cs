using System;
using System.Collections.Generic;
using System.Text;

namespace 作业4_1
{
    class OrderDetails
    {
        private string itemName;
        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                if (value != null)
                {
                    itemName = value;
                }
                else Console.WriteLine("error != null");
            }
        }
        private int amountBought;
        public int AmountBought
        {
            get
            {
                return amountBought;
            }
            set
            {
                if (value > 0)
                {
                    AmountBought = value;
                }
                else Console.WriteLine("error >0");
            }
        }
        private double amount;
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (amount > 0)
                {
                    amount = value;
                }
                else Console.WriteLine("单价应大于0.");
            }
        }
        public OrderDetails()
        {
            this.itemName = string.Empty;
            this.amountBought = 0;
            this.amount = 0;
        }

        public OrderDetails(string name, int number, double amount)
        {
            this.itemName = name;
            this.amountBought = number;
            this.amount = amount;
        }

        public double getTotalPriceOftheItem()
        {
            return this.amountBought * this.amount;
        }

    }
}
