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
    public partial class POView : Form
    {
        public Order order { get; set; }

        public POView(PendingOrder temp)
        {
            InitializeComponent();
            order = null;
            if (temp.Title.Length > 0)
            {
                idPO.Text = temp.ID.ToString();
                itemsPO.Text = temp.ItemID;
                datePO.Value = temp.Date;
                titlePO.Text = temp.Title;
                addressPO.Text = temp.Address;
                quantityPO.Text = temp.Quantity.ToString();
                statusPO.Text = temp.Status;
                paymentPO.Text = temp.Payment.ToString();
                detailsPO.Text = temp.Details;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (statusPO.SelectedItem.ToString() == "In progress")
            {
                string temp = int.Parse(idPO.Text) + "," + DateTime.Parse(datePO.Value.ToString("MM/dd/yyyy")) + "," +
                    titlePO.Text + "," + addressPO.Text + "," + itemsPO.Text + "," + quantityPO.Text + "," +
                    double.Parse(paymentPO.Text) + "," + statusPO.SelectedItem.ToString() + "," + detailsPO.Text;

                using (StreamReader sr = new StreamReader(@"PendingOrders.csv"))
                {
                    StreamWriter sw = new StreamWriter(@"temp.csv");
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == idPO.Text)
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
                File.Delete(@"PendingOrders.csv");
                File.Move("temp.csv", "PendingOrders.csv");
                File.Delete("temp.csv");
                DialogResult = DialogResult.OK;
            }

            if (statusPO.SelectedItem.ToString() == "Done")
            {
                Order temp = new Order(int.Parse(idPO.Text), DateTime.Parse(datePO.Value.ToString("MM/dd/yyyy")), itemsPO.Text,
                    quantityPO.Text, double.Parse(paymentPO.Text), detailsPO.Text);


                using (StreamReader sr = new StreamReader(@"PendingOrders.csv"))
                {
                    StreamWriter sw = new StreamWriter(@"temp.csv");
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == idPO.Text)
                        {

                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                    sw.Close();
                }
                File.Delete(@"PendingOrders.csv");
                File.Move("temp.csv", "PendingOrders.csv");
                File.Delete("temp.csv");
                order = temp;
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }
    }
}
