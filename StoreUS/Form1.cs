using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreUS.Classes;
using System.Xml;
using System.IO;
using System.Security.Cryptography;

namespace StoreUS
{
    public partial class Form1 : Form
    {
        List<Item> Items;
        List<Order> Orders;
        bool loggedin = false;
        List<PendingOrder> OrdersPending;
        double TotalNewOrder;
        private List<Item> orders;
        List<Item> tempItems;
        string error;

        public Form1()
        {
            
            InitializeComponent();
            InitializeItems();
            tabControl.Visible = false;
            logout.Visible = false;
        }

        /// <summary>
        /// Reads the txt file which cointains all of the item data and puts it into a list
        /// </summary>
        public void InitializeItems()
        {
            //Running an instance of bg1 so it doesnt crash the GUI
            backgroundWorker1.RunWorkerAsync();
        }

        private void Button_Add_Item_Click(object sender, EventArgs e)
        {
            int id = GetItemID();
            Item temp = new Item();
            using (ItemAdd forma = new ItemAdd())
            {
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    temp = forma.item;
                    if (temp != null)
                    {
                        temp.ID = id;
                        AddItemToCSV(temp);
                    }
                }

            }
            

        }

        /// <summary>
        /// Need to edit this. create a settings file with an ID inside.
        /// </summary>
        /// <returns></returns>
        private int GenerateID()
        {
            return Items[Items.Count - 1].ID + 1;
        }

        private void AddItemToCSV(Item item)
        {
            List<string> lines = new List<string>();
            string newline = item.ID + "," + item.Title + "," + item.Origin + "," + item.Quantity + "," + item.Price + "," + item.SellingPrice + "," + item.Status + "," + item.Received + "," + item.Details;
            lines.Add(newline);
            File.AppendAllLines(@"Items.csv", lines);
            //Items.Add(item);
            //AddItems(Items);
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (this.itemView.DataSource != null)
                {
                    this.itemView.DataSource = null;
                }
                else
                {
                    this.itemView.Rows.Clear();
                }

                if (this.dataGridPO.DataSource != null)
                {
                    this.dataGridPO.DataSource = null;
                }
                else
                {
                    this.dataGridPO.Rows.Clear();
                }

                if (this.dataGridO.DataSource != null)
                {
                    this.dataGridO.DataSource = null;
                }
                else
                {
                    this.dataGridO.Rows.Clear();
                }

                if (this.cart.DataSource != null)
                {
                    this.cart.DataSource = null;
                }
                else
                {
                    this.cart.Rows.Clear();
                }

                error = "";
                orders = new List<Item>();
                tempItems = new List<Item>();
                TotalNewOrder = 0;
                newTotal.Text = TotalNewOrder.ToString();

                Items = new List<Item>();

                string line;
                using (System.IO.StreamReader reader = new System.IO.StreamReader(@"Items.csv"))
                {
                    reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                 
                        string[] part = line.Split(',');
                        int ID = int.Parse(part[0]);
                        string Title = part[1];
                        string Origin = part[2];
                        double Quantity = double.Parse(part[3]);
                        double Price = System.Math.Round(double.Parse(part[4]), 2);
                        double SellingPrice = System.Math.Round(double.Parse(part[5]), 2);
                        string Status = part[6];
                        DateTime Date = DateTime.Parse(part[7]);
                        string Details = part[8];
                        Item temp = new Item(ID, Title, Origin, Quantity, Price, SellingPrice, Status, Date, Details);
                        Items.Add(temp);
                    }
                    AddItems(Items);
                }

                OrdersPending = new List<PendingOrder>();
                using (StreamReader reader = new StreamReader(@"PendingOrders.csv"))
                {
                    reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                    
                        string[] part = line.Split(',');
                        int ID = int.Parse(part[0]);
                        DateTime Date = DateTime.Parse(part[1]);
                        string Title = part[2];
                        string Address = part[3];
                        string ItemID = part[4];
                        string Quantity = part[5];
                        double Payment = double.Parse(part[6]);
                        string Status = part[7];
                        string Details = part[8];
                        PendingOrder temp = new PendingOrder(ID, Date, Title, Address, ItemID, Quantity, Payment, Status, Details);
                        OrdersPending.Add(temp);
                    }
                
                    AddPendingOrders(OrdersPending);
               
                }

                Orders = new List<Order>();
                double total = 0;
                using (StreamReader reader = new StreamReader(@"Orders.csv"))
                {
                    reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] part = line.Split(',');
                        int ID = int.Parse(part[0]);
                        DateTime Date = DateTime.Parse(part[1]);
                        string ItemID = part[2];
                        string Quantity = part[3];
                        double Payment = double.Parse(part[4]);
                        total += Payment;
                        string Details = part[5];
                        Order temp = new Order(ID, Date, ItemID, Quantity, Payment, Details);
                        Orders.Add(temp);
                    }

                    AddOrders(Orders);
                    totalReceivedPayment.Text = total.ToString();
                }
            }
            catch (Exception exc)
            {
                error = exc.Message;
                errorMessage.Text += "Failed to load data. Fatal error. " + error;
                errorMessage.Visible = true;
                tabControl.Visible = false;
            }
        }

        /// <summary>
        /// Adds List of Items to Datagridview. 
        /// </summary>
        /// <param name="Items">Items to be added</param>
        private void AddItems(List<Item> things)
        {
            if (this.itemView.DataSource != null)
            {
                this.itemView.DataSource = null;
            }
            else
            {
                this.itemView.Rows.Clear();
            }
            
            foreach(Item c in things)
            {
                string[] row = new string[] { c.ID.ToString(), c.Title, c.Origin, c.SellingPrice.ToString(), c.Status, "View/Edit" };
                itemView.Rows.Add(row);
            }

            //if (this.dataGridShop.DataSource != null)
            //{
            //    this.dataGridShop.DataSource = null;
            //}
            //else
            //{
            //    this.dataGridShop.Rows.Clear();
            //}

            //foreach (Item c in things)
            //{
            //    if (c.Quantity > 0)
            //    {
            //        string[] row = new string[] { c.ID.ToString(), c.Title, c.Origin, c.Quantity.ToString(), c.SellingPrice.ToString(), "Add" };
            //        dataGridShop.Rows.Add(row);
            //    }
                
            //}

            makeTemp();
            updateShop();
        }

        private void AddPendingOrders(List<PendingOrder> orders)
        {
            //System_Log.Text += "Peanut";
            if (this.dataGridPO.DataSource != null)
            {
                this.dataGridPO.DataSource = null;
            }
            else
            {
                this.dataGridPO.Rows.Clear();
            }

            foreach (PendingOrder c in orders)
            {
                string[] row = new string[] { c.ID.ToString(), c.Date.ToString(), c.Title, c.ItemID.ToString(), c.Quantity.ToString(), "View" };
                dataGridPO.Rows.Add(row);
            }
            
        }

        private void AddOrders(List<Order> orders)
        {
            if (this.dataGridO.DataSource != null)
            {
                this.dataGridO.DataSource = null;
            }
            else
            {
                this.dataGridO.Rows.Clear();
            }

            foreach (Order c in Orders)
            {
                string[] row = new string[] { c.ID.ToString(), c.Date.ToString(), c.ItemID.ToString(), c.Quantity.ToString(), c.Price.ToString()};
                dataGridO.Rows.Add(row);
            }
        }

        private void updateTotal()
        {
            TotalNewOrder = 0;
            foreach (Item i in orders)
            {
                TotalNewOrder += i.SellingPrice * i.Quantity;
            }
            newTotal.Text = TotalNewOrder.ToString();
        }

        private void makeTemp()
        {
            tempItems = new List<Item>();
            foreach (Item i in Items)
                tempItems.Add(new Item(i.ID, i.Title, i.Origin, i.Quantity, i.Price, i.SellingPrice, i.Status, i.Received, i.Details));
        }

        private void dataGridShop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && int.Parse(dataGridShop.Rows[e.RowIndex].Cells[3].Value.ToString()) > 0)
            {
                int id = int.Parse(dataGridShop.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (!orders.Any(x => x.ID == id))
                {
                    var index = tempItems.FindIndex(c => c.ID == id);
                    tempItems[index].Quantity -= 1;
                    orders.Add(new Item(tempItems[index].ID, tempItems[index].Title, tempItems[index].Origin, 1, tempItems[index].Price, tempItems[index].SellingPrice, tempItems[index].Status, tempItems[index].Received, tempItems[index].Details));
                    index = orders.FindIndex(c => c.ID == id);
                    string[] row = new string[] { orders[index].ID.ToString(), orders[index].Title, orders[index].Origin.ToString(), orders[index].Quantity.ToString(), orders[index].SellingPrice.ToString() };
                    cart.Rows.Add(row);
                    updateShop();
                    updateTotal();
                }
            }
        }

        private void updateShop()
        {
            if (this.dataGridShop.DataSource != null)
            {
                this.dataGridShop.DataSource = null;
            }
            else
            {
                this.dataGridShop.Rows.Clear();
            }

            foreach (Item c in tempItems)
            {
                if (c.Quantity > 0)
                {
                    string[] row = new string[] { c.ID.ToString(), c.Title, c.Origin, c.Quantity.ToString(), c.SellingPrice.ToString(), "Add" };
                    dataGridShop.Rows.Add(row);
                }
            }
        }

        private void cart_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int id = int.Parse(cart.Rows[e.RowIndex].Cells[0].Value.ToString());
                var indexItems = tempItems.FindIndex(c => c.ID == id);
                var index = orders.FindIndex(c => c.ID == id);
                //if (!orders.Any(c => c.ID == id)) clearOrder();
                tempItems[indexItems].Quantity += orders[index].Quantity;
                updateShop();
                if (tempItems[indexItems].Status == "Out of stock" && tempItems[indexItems].Quantity > 0)
                    tempItems[indexItems].Status = "In stock";

            }
        }

        private void cart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int id = int.Parse(cart.Rows[e.RowIndex].Cells[0].Value.ToString());
                var indexItems = tempItems.FindIndex(c => c.ID == id);
                var indexOriginal = Items.FindIndex(c => c.ID == id);
                var index = orders.FindIndex(c => c.ID == id);
                int newQuantity = int.Parse(cart.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (newQuantity <= 0)
                {
                    orders[index].Quantity = 0;
                    cart.Rows[e.RowIndex].Cells[3].Value = 0;
                    tempItems[indexItems].Quantity = Items[indexOriginal].Quantity;
                }
                else if(newQuantity <= Items[indexOriginal].Quantity)
                {
                    orders[index].Quantity = newQuantity;
                    tempItems[indexItems].Quantity -= orders[index].Quantity;
                }
                else
                {
                    orders[index].Quantity = Items[indexOriginal].Quantity;
                    cart.Rows[e.RowIndex].Cells[3].Value = Items[indexOriginal].Quantity;
                    tempItems[indexItems].Status = "Out of stock";
                    tempItems[indexItems].Quantity = 0;
                }
                cart.Rows[e.RowIndex].Cells[4].Value = orders[index].Quantity * orders[index].SellingPrice;
                updateShop();
                updateTotal();
            }
        }


        private void itemsSearchButton_Click(object sender, EventArgs e)
        {
            List<Item> temp = new List<Item>();
            if (textBox8.TextLength != 0) //Searches by Title
            {
                temp = Items.Where(x => x.Title.ToLower() == textBox8.Text.ToString().ToLower()).ToList();
            }
            if (textBox9.TextLength != 0)//Searches by ID
            {
                if (temp.Count == 0)
                {
                    temp = Items.Where(x => x.ID == int.Parse(textBox9.Text)).ToList();
                }
                else
                {
                    temp = temp.Where(x => x.ID == int.Parse(textBox9.Text)).ToList();

                }
            }
            if (textBox7.TextLength != 0)//Searches by Origin
            {
                if (temp.Count == 0)
                {
                    temp = Items.Where(x => x.Origin.ToLower() == textBox7.Text.ToLower()).ToList();
                }
                else
                {
                    temp = temp.Where(x => x.Origin.ToLower() == textBox7.Text.ToLower()).ToList();

                }
            }

            if (textBox10.TextLength != 0)//Searches by price
            {
                if (temp.Count == 0)
                {
                    temp = Items.Where(x => x.SellingPrice == int.Parse(textBox10.Text)).ToList();
                }
                else
                {
                    temp = temp.Where(x => x.SellingPrice == int.Parse(textBox10.Text)).ToList();

                }
            }

            if (comboBox2.SelectedIndex > -1) //searches by status
            {
                if (temp.Count == 0)
                {
                    temp = Items.Where(x => x.Status == comboBox2.Items[comboBox2.SelectedIndex].ToString()).ToList();
                }
                else
                {
                    temp = temp.Where(x => x.Status == comboBox2.Items[comboBox2.SelectedIndex].ToString()).ToList();

                }
            }
            if (temp.Count == 0)
            {
                if (this.itemView.DataSource != null)
                {
                    this.itemView.DataSource = null;
                }
                else
                {
                    this.itemView.Rows.Clear();
                }
            }
            else AddItems(temp);
        }

        private void searchPO_Click(object sender, EventArgs e)
        {
            List<PendingOrder> temp = new List<PendingOrder>();
            if (searchIDPO.TextLength != 0) //by ID
            {
                temp = OrdersPending.Where(x => x.ID.ToString() == searchIDPO.Text).ToList();
            }
            if (searchTitlePO.TextLength != 0)
            {
                if (temp.Count == 0)
                {
                    temp = OrdersPending.Where(x => x.Title.ToLower() == searchTitlePO.Text.ToLower()).ToList();
                }
                else
                {
                    temp = temp.Where(x => x.ID.ToString() == searchTitlePO.Text).ToList();
                }
            }
            if (searchAddressPO.TextLength != 0)
            {
                if (temp.Count == 0)
                {
                    temp = OrdersPending.Where(x => x.Address.ToLower() == searchAddressPO.Text.ToLower()).ToList();
                }
                else
                {
                    temp = temp.Where(x => x.ID.ToString() == searchAddressPO.Text).ToList();
                }
            }
            if (temp.Count == 0)
            {
                if (this.dataGridPO.DataSource != null)
                {
                    this.dataGridPO.DataSource = null;
                }
                else
                {
                    this.dataGridPO.Rows.Clear();
                }
            }
            else AddPendingOrders(temp);
        }

        private void clearPO_Click(object sender, EventArgs e)
        {
            searchIDPO.Text = "";
            searchTitlePO.Text = "";
            searchAddressPO.Text = "";
            AddPendingOrders(OrdersPending);
        }

        private void itemView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5 && e.RowIndex >= 0)
                {
                    int id = int.Parse(itemView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int index = Items.FindIndex(x => x.ID == id);
                    Item temp = new Item(Items[index]);
                
                    using (ItemView forma = new ItemView(temp))
                    {
                        if (forma.ShowDialog() == DialogResult.OK)
                        {
                            backgroundWorker1.RunWorkerAsync();
                        }
                    }
                }
            }
            catch(Exception exc)
            {
                error = exc.Message;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void dataGridPO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    int id = int.Parse(dataGridPO.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int index = OrdersPending.FindIndex(x => x.ID == id);
                    PendingOrder temp = new PendingOrder(OrdersPending[index]);
                    using (POView forma = new POView(temp))
                    {
                        if (forma.ShowDialog() == DialogResult.OK)
                        {
                            if (forma.order != null)
                            {
                                Order order = forma.order;
                                AddOrderToCSV(order);
                            }
                            else
                            {
                                backgroundWorker1.RunWorkerAsync();
                            }
                        }
                    }
                }
            }
            catch(Exception exc)
            {
                error = exc.Message;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void newClear_Click(object sender, EventArgs e)
        {
            clearOrder();
        }

        private void clearOrder()
        {
            
            newTitle.BackColor = Color.White;
            newAddress.BackColor = Color.White;
            newTitle.Text = "";
            newAddress.Text = "";
            newDetails.Text = "";
            TotalNewOrder = 0;
            newTotal.Text = TotalNewOrder.ToString();
            orders = new List<Item>();
            makeTemp();
            updateShop();
            if (this.cart.DataSource != null)
            {
                this.cart.DataSource = null;
            }
            else
            {
                this.cart.Rows.Clear();
            }
        }

        private void newAdd_Click(object sender, EventArgs e)
        {
            if (newTitle.Text.Length <= 0)
            {
                newTitle.BackColor = Color.DarkSalmon;
            }
            if (newAddress.Text.Length <= 0)
            {
                newAddress.BackColor = Color.DarkSalmon;
            }
            if (newTitle.Text.Length > 0 && newAddress.Text.Length > 0)
            {
                string items = "", quantities = "";
                foreach(Item i in orders)
                {
                    if (i.Quantity > 0)
                    {
                        items += i.ID + " ";
                        quantities += i.Quantity + " ";
                    }
                }
                if (items.Length > 0)
                {
                    foreach(Item i in tempItems)
                    {
                        if (i.Quantity == 0) i.Status = "Out of stock";
                    }
                    PendingOrder newOrder = new PendingOrder();
                    newOrder.ID = GetOrderID();
                    newOrder.Title = newTitle.Text;
                    newOrder.Address = newAddress.Text;
                    newOrder.Date = DateTime.Now;
                    newOrder.Details = newDetails.Text;
                    newOrder.Payment = double.Parse(newTotal.Text);
                    newOrder.ItemID = items;
                    newOrder.Status = "In Progress";
                    newOrder.Quantity = quantities;
                    //OrdersPending.Add(newOrder);
                    AddPendingOrderToCSV(newOrder);
                    //AddPendingOrders(OrdersPending);
                    updateItemsFile(tempItems);
                }
                clearOrder();
            }
            
        }

        private void updateItemsFile(List<Item> items)
        {
            StreamWriter sw = new StreamWriter(@"temp.csv");
            sw.WriteLine();
            foreach (Item i in items)
            {
                string temp = i.ID + "," + i.Title + "," + i.Origin + "," + i.Quantity + "," + i.Price + "," +
                                i.SellingPrice + "," + i.Status + "," + i.Received + "," + i.Details;
                sw.WriteLine(temp);
            }
            sw.Close();
            File.Delete(@"Items.csv");
            File.Move("temp.csv", "Items.csv");
            File.Delete("temp.csv");
            backgroundWorker1.RunWorkerAsync();
        }

        private void AddPendingOrderToCSV(PendingOrder order)
        {
            List<string> lines = new List<string>();
            string newline = order.ID + "," + order.Date + "," + order.Title + "," + order.Address + "," + order.ItemID + "," + order.Quantity + "," + order.Payment + "," + order.Status + "," + order.Details;
            lines.Add(newline);
            File.AppendAllLines(@"PendingOrders.csv", lines);
            //backgroundWorker1.RunWorkerAsync();
        }


        private void AddOrderToCSV(Order order)
        {
            List<string> lines = new List<string>();
            string newline = order.ID + "," + order.Date + "," + order.ItemID + "," + order.Quantity + "," + order.Price + "," + order.Details;
            lines.Add(newline);
            File.AppendAllLines(@"Orders.csv", lines);
            backgroundWorker1.RunWorkerAsync();
        }


        private int GetItemID()
        {
            int id = int.Parse(File.ReadAllText(@"ItemID.txt"));
            int id2 = id + 1;
            File.WriteAllText(@"ItemID.txt", id2.ToString());
            return id;
        }

        private int GetOrderID()
        {
            int id = int.Parse(File.ReadAllText(@"OrderID.txt"));
            int id2 = id + 1;
            File.WriteAllText(@"OrderID.txt", id2.ToString());
            return id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddItems(Items);
            textBox8.Text = "";
            textBox7.Text = "";
            comboBox2.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (loggedin == false)
            {
                tabControl.Visible = false;
                string psw = File.ReadAllText(@"psw.txt");
                string textofbox = textBox11.Text;
                string hashtext = ComputeSha256Hash(textofbox);
                if (psw.ToLower() == hashtext.ToLower())
                {
                    loggedin = true;
                    welcome.Visible = false;
                    textBox11.Visible = false;
                    label13.Visible = false;
                    button3.Visible = false;
                    tabControl.Visible = true;
                    label14.Visible = false;
                    logout.Visible = true;
                    textBox11.Text = "";
                }
                else
                {
                    label14.Visible = true;
                    textBox11.Text = "";
                }
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            loggedin = false;
            tabControl.Visible = false;
            welcome.Visible = true;
            textBox11.Visible = true;
            label13.Visible = true;
            button3.Visible = true;
            label14.Visible = false;
            textBox11.Text = "";
            logout.Visible = false;
        }
    }
}
