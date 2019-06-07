using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUS.Classes
{
    public class Order
    {
        public DateTime Date { get; set; }
        public int ID { get; set; }
        public string ItemID { get; set; }
        public string Quantity { get; set; }
        public double Price { get; set; }
        public string Details { get; set; }

        public Order() { }

        public Order(int id, DateTime date, string itemid, string quantity, double price, string details)
        {
            Date = date;
            ID = id;
            ItemID = itemid;
            Quantity = quantity;
            Price = price;
            Details = details;
        }

    }
}
