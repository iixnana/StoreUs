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

namespace StoreUS
{
    public partial class ItemAdd : Form
    {
        public Item item { get; set; }

        

        public ItemAdd()
        {
            InitializeComponent();
            item = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemName.Text.Length > 0 && ItemOrigin.Text.Length > 0 && ItemQuant.Text.Length > 0 && ItemPrice.Text.Length > 0 && ItemSell.Text.Length > 0 && dateTimePicker1.Value.ToString().Length > 0)
                {
                    Item temp = new Item(1, ItemName.Text, ItemOrigin.Text, double.Parse(ItemQuant.Text),
                    double.Parse(ItemPrice.Text), double.Parse(ItemSell.Text), comboBox1.Text, DateTime.Parse(dateTimePicker1.Value.ToString("MM/dd/yyyy")), ItemDetails.Text);
                    DialogResult = DialogResult.OK;
                    item = temp;
                }
                else item = null;
                
            }
            catch (Exception exc)
            {
                string error = exc.Message;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
