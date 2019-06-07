namespace StoreUS
{
    partial class ItemView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.itemsInfoSelling = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.itemInfoStatus = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.itemsInfoQuantity = new System.Windows.Forms.TextBox();
            this.itemsInfoPrice = new System.Windows.Forms.TextBox();
            this.itemsInfoOrigin = new System.Windows.Forms.TextBox();
            this.itemsInfoName = new System.Windows.Forms.TextBox();
            this.itemsInfoID = new System.Windows.Forms.TextBox();
            this.Label_Item_Quantity = new System.Windows.Forms.Label();
            this.Label_Item_Price = new System.Windows.Forms.Label();
            this.Label_Item_Status = new System.Windows.Forms.Label();
            this.Label_Item_Name = new System.Windows.Forms.Label();
            this.Label_Item_Origin = new System.Windows.Forms.Label();
            this.Label_Item_ID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.itemsInfoAdditional = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.itemsInfoSelling);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.itemInfoStatus);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.itemsInfoQuantity);
            this.groupBox1.Controls.Add(this.itemsInfoPrice);
            this.groupBox1.Controls.Add(this.itemsInfoOrigin);
            this.groupBox1.Controls.Add(this.itemsInfoName);
            this.groupBox1.Controls.Add(this.itemsInfoID);
            this.groupBox1.Controls.Add(this.Label_Item_Quantity);
            this.groupBox1.Controls.Add(this.Label_Item_Price);
            this.groupBox1.Controls.Add(this.Label_Item_Status);
            this.groupBox1.Controls.Add(this.Label_Item_Name);
            this.groupBox1.Controls.Add(this.Label_Item_Origin);
            this.groupBox1.Controls.Add(this.Label_Item_ID);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 435);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(2019, 4, 17, 0, 0, 0, 0);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Date:";
            // 
            // itemsInfoSelling
            // 
            this.itemsInfoSelling.Location = new System.Drawing.Point(79, 148);
            this.itemsInfoSelling.Name = "itemsInfoSelling";
            this.itemsInfoSelling.Size = new System.Drawing.Size(100, 20);
            this.itemsInfoSelling.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Selling Price:";
            // 
            // itemInfoStatus
            // 
            this.itemInfoStatus.FormattingEnabled = true;
            this.itemInfoStatus.Items.AddRange(new object[] {
            "In stock",
            "Out of stock",
            "Pending"});
            this.itemInfoStatus.Location = new System.Drawing.Point(79, 95);
            this.itemInfoStatus.Name = "itemInfoStatus";
            this.itemInfoStatus.Size = new System.Drawing.Size(100, 21);
            this.itemInfoStatus.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(233, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemsInfoQuantity
            // 
            this.itemsInfoQuantity.Location = new System.Drawing.Point(79, 174);
            this.itemsInfoQuantity.Name = "itemsInfoQuantity";
            this.itemsInfoQuantity.Size = new System.Drawing.Size(100, 20);
            this.itemsInfoQuantity.TabIndex = 13;
            // 
            // itemsInfoPrice
            // 
            this.itemsInfoPrice.Location = new System.Drawing.Point(79, 122);
            this.itemsInfoPrice.Name = "itemsInfoPrice";
            this.itemsInfoPrice.Size = new System.Drawing.Size(100, 20);
            this.itemsInfoPrice.TabIndex = 12;
            // 
            // itemsInfoOrigin
            // 
            this.itemsInfoOrigin.Location = new System.Drawing.Point(79, 69);
            this.itemsInfoOrigin.Name = "itemsInfoOrigin";
            this.itemsInfoOrigin.Size = new System.Drawing.Size(100, 20);
            this.itemsInfoOrigin.TabIndex = 10;
            // 
            // itemsInfoName
            // 
            this.itemsInfoName.Location = new System.Drawing.Point(79, 43);
            this.itemsInfoName.Name = "itemsInfoName";
            this.itemsInfoName.Size = new System.Drawing.Size(100, 20);
            this.itemsInfoName.TabIndex = 9;
            // 
            // itemsInfoID
            // 
            this.itemsInfoID.Enabled = false;
            this.itemsInfoID.Location = new System.Drawing.Point(79, 17);
            this.itemsInfoID.Name = "itemsInfoID";
            this.itemsInfoID.Size = new System.Drawing.Size(100, 20);
            this.itemsInfoID.TabIndex = 8;
            // 
            // Label_Item_Quantity
            // 
            this.Label_Item_Quantity.AutoSize = true;
            this.Label_Item_Quantity.Location = new System.Drawing.Point(24, 177);
            this.Label_Item_Quantity.Name = "Label_Item_Quantity";
            this.Label_Item_Quantity.Size = new System.Drawing.Size(49, 13);
            this.Label_Item_Quantity.TabIndex = 7;
            this.Label_Item_Quantity.Text = "Quantity:";
            // 
            // Label_Item_Price
            // 
            this.Label_Item_Price.AutoSize = true;
            this.Label_Item_Price.Location = new System.Drawing.Point(39, 125);
            this.Label_Item_Price.Name = "Label_Item_Price";
            this.Label_Item_Price.Size = new System.Drawing.Size(34, 13);
            this.Label_Item_Price.TabIndex = 6;
            this.Label_Item_Price.Text = "Price:";
            // 
            // Label_Item_Status
            // 
            this.Label_Item_Status.AutoSize = true;
            this.Label_Item_Status.Location = new System.Drawing.Point(33, 98);
            this.Label_Item_Status.Name = "Label_Item_Status";
            this.Label_Item_Status.Size = new System.Drawing.Size(40, 13);
            this.Label_Item_Status.TabIndex = 5;
            this.Label_Item_Status.Text = "Status:";
            // 
            // Label_Item_Name
            // 
            this.Label_Item_Name.AutoSize = true;
            this.Label_Item_Name.Location = new System.Drawing.Point(35, 46);
            this.Label_Item_Name.Name = "Label_Item_Name";
            this.Label_Item_Name.Size = new System.Drawing.Size(38, 13);
            this.Label_Item_Name.TabIndex = 4;
            this.Label_Item_Name.Text = "Name:";
            // 
            // Label_Item_Origin
            // 
            this.Label_Item_Origin.AutoSize = true;
            this.Label_Item_Origin.Location = new System.Drawing.Point(36, 72);
            this.Label_Item_Origin.Name = "Label_Item_Origin";
            this.Label_Item_Origin.Size = new System.Drawing.Size(37, 13);
            this.Label_Item_Origin.TabIndex = 3;
            this.Label_Item_Origin.Text = "Origin:";
            // 
            // Label_Item_ID
            // 
            this.Label_Item_ID.AutoSize = true;
            this.Label_Item_ID.Location = new System.Drawing.Point(52, 20);
            this.Label_Item_ID.Name = "Label_Item_ID";
            this.Label_Item_ID.Size = new System.Drawing.Size(21, 13);
            this.Label_Item_ID.TabIndex = 2;
            this.Label_Item_ID.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.itemsInfoAdditional);
            this.groupBox2.Location = new System.Drawing.Point(4, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional info";
            // 
            // itemsInfoAdditional
            // 
            this.itemsInfoAdditional.Location = new System.Drawing.Point(7, 20);
            this.itemsInfoAdditional.Name = "itemsInfoAdditional";
            this.itemsInfoAdditional.Size = new System.Drawing.Size(291, 144);
            this.itemsInfoAdditional.TabIndex = 0;
            this.itemsInfoAdditional.Text = "";
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 455);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item View";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox itemsInfoSelling;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox itemInfoStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox itemsInfoQuantity;
        private System.Windows.Forms.TextBox itemsInfoPrice;
        private System.Windows.Forms.TextBox itemsInfoOrigin;
        private System.Windows.Forms.TextBox itemsInfoName;
        private System.Windows.Forms.TextBox itemsInfoID;
        private System.Windows.Forms.Label Label_Item_Quantity;
        private System.Windows.Forms.Label Label_Item_Price;
        private System.Windows.Forms.Label Label_Item_Status;
        private System.Windows.Forms.Label Label_Item_Name;
        private System.Windows.Forms.Label Label_Item_Origin;
        private System.Windows.Forms.Label Label_Item_ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox itemsInfoAdditional;
    }
}