using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUS.Classes
{
    /// <summary>
    /// Class used to store item elements
    /// variables represent item's info
    /// </summary>
    public class Item
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Origin { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double SellingPrice { get; set; }
        public string Status { get; set; }
        public DateTime Received { get; set; }
        public string Details { get; set; }

        public Item()
        { }

        public Item(int id, string name, string origin, double quantity, double price, double sellingprice, string status, DateTime date, string details)
        {
            try
            {
                ID = id;
                Title = name;
                Origin = origin;
                if(status == "Out of stock")
                {
                    Quantity = 0;
                    Status = status;
                }
                else if (quantity >= 0)
                {
                    Quantity = quantity;
                    if (quantity == 0) Status = "Out of stock";
                    else Status = status;
                }
                else
                {
                    Quantity = 0;
                    Status = "Out of stock";
                }
                if (price > 0) Price = price;
                else Price = 0;
                if (sellingprice > 0) SellingPrice = sellingprice;
                else SellingPrice = 0;
                Received = date;
                Details = details;
            }
            catch (Exception e)
            {
                string error = e.Message;
            }
        }

        public Item(Item i)
        {
            ID = i.ID;
            Title = i.Title;
            Origin = i.Origin;
            Quantity = i.Quantity;
            Price = i.Price;
            SellingPrice = i.SellingPrice;
            Status = i.Status;
            Received = i.Received;
            Details = i.Details;
        }
    }
}
