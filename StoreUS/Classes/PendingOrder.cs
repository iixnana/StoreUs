using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUS.Classes
{
    public class PendingOrder
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string ItemID { get; set; }
        public string Quantity { get; set; }
        public double Payment { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }

        public PendingOrder() { }

        public PendingOrder(int id, DateTime date, string title, string address, string itemid, string quantity, double payment, string status, string details)
        {
            ID = id;
            Date = date;
            Title = title;
            Address = address;
            ItemID = itemid;
            Quantity = quantity;
            Payment = payment;
            Status = status;
            Details = details;
        }

        public PendingOrder(PendingOrder p)
        {
            ID = p.ID;
            Date = p.Date;
            Title = p.Title;
            Address = p.Address;
            ItemID = p.ItemID;
            Quantity = p.Quantity;
            Payment = p.Payment;
            Status = p.Status;
            Details = p.Details;
        }

    }
}
