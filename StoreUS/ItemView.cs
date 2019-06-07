using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreUS.Classes;

namespace StoreUS
{
    public partial class ItemView : Form
    {
        //public Item itemret { get; set; }

        public ItemView(Item item)
        {
            //InitializeComponent();
            
            if (item != null)
            {
                InitializeComponent();
                itemsInfoID.Text = item.ID.ToString();
                itemsInfoName.Text = item.Title;
                itemsInfoOrigin.Text = item.Origin;
                itemInfoStatus.Text = item.Status;
                itemsInfoPrice.Text = item.Price.ToString();
                itemsInfoSelling.Text = item.SellingPrice.ToString();
                itemsInfoQuantity.Text = item.Quantity.ToString();
                dateTimePicker1.Value = item.Received;
                itemsInfoAdditional.Text = item.Details;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (itemInfoStatus.Text == "Out of stock")
            {
                itemsInfoQuantity.Text = "0";
            }
            if (double.Parse(itemsInfoQuantity.Text) <= 0)
            {
                itemsInfoQuantity.Text = "0";
                itemInfoStatus.Text = "Out of stock";
            }
            if (double.Parse(itemsInfoPrice.Text) <= 0)
            {
                itemsInfoPrice.Text = "0";
            }
            if (double.Parse(itemsInfoSelling.Text) <= 0)
            {
                itemsInfoSelling.Text = "0";
            }

            string temp = int.Parse(itemsInfoID.Text) + "," + itemsInfoName.Text + "," + itemsInfoOrigin.Text + "," + double.Parse(itemsInfoQuantity.Text) + "," + double.Parse(itemsInfoPrice.Text) + "," +
    double.Parse(itemsInfoSelling.Text) + "," + itemInfoStatus.Text + "," + DateTime.Parse(dateTimePicker1.Value.ToString("MM/dd/yyyy")) + "," + itemsInfoAdditional.Text;

            using (StreamReader sr = new StreamReader(@"Items.csv"))
            {
                StreamWriter sw = new StreamWriter(@"temp.csv");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == itemsInfoID.Text)
                    {
                        sw.WriteLine(temp);
                    }
                    else
                    {
                        sw.WriteLine(line);
                    }
                }
                sw.Close();
            }
            File.Delete(@"Items.csv");
            File.Move("temp.csv", "Items.csv");
            File.Delete("temp.csv");
            DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
