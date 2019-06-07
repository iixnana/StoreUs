namespace StoreUS
{
    partial class POView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POView));
            this.label1 = new System.Windows.Forms.Label();
            this.itemsPO = new System.Windows.Forms.TextBox();
            this.statusPO = new System.Windows.Forms.ComboBox();
            this.datePO = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.detailsPO = new System.Windows.Forms.RichTextBox();
            this.paymentPO = new System.Windows.Forms.TextBox();
            this.quantityPO = new System.Windows.Forms.TextBox();
            this.addressPO = new System.Windows.Forms.TextBox();
            this.titlePO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idPO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Items IDs:";
            // 
            // itemsPO
            // 
            this.itemsPO.Enabled = false;
            this.itemsPO.Location = new System.Drawing.Point(89, 45);
            this.itemsPO.Name = "itemsPO";
            this.itemsPO.Size = new System.Drawing.Size(121, 20);
            this.itemsPO.TabIndex = 19;
            // 
            // statusPO
            // 
            this.statusPO.FormattingEnabled = true;
            this.statusPO.Items.AddRange(new object[] {
            "Done",
            "In progress"});
            this.statusPO.Location = new System.Drawing.Point(89, 149);
            this.statusPO.Name = "statusPO";
            this.statusPO.Size = new System.Drawing.Size(121, 21);
            this.statusPO.TabIndex = 18;
            // 
            // datePO
            // 
            this.datePO.Enabled = false;
            this.datePO.Location = new System.Drawing.Point(88, 202);
            this.datePO.Name = "datePO";
            this.datePO.Size = new System.Drawing.Size(200, 20);
            this.datePO.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(214, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detailsPO
            // 
            this.detailsPO.Location = new System.Drawing.Point(10, 248);
            this.detailsPO.Name = "detailsPO";
            this.detailsPO.Size = new System.Drawing.Size(278, 111);
            this.detailsPO.TabIndex = 15;
            this.detailsPO.Text = "";
            // 
            // paymentPO
            // 
            this.paymentPO.Location = new System.Drawing.Point(89, 176);
            this.paymentPO.Name = "paymentPO";
            this.paymentPO.Size = new System.Drawing.Size(121, 20);
            this.paymentPO.TabIndex = 14;
            // 
            // quantityPO
            // 
            this.quantityPO.Enabled = false;
            this.quantityPO.Location = new System.Drawing.Point(89, 123);
            this.quantityPO.Name = "quantityPO";
            this.quantityPO.Size = new System.Drawing.Size(121, 20);
            this.quantityPO.TabIndex = 12;
            // 
            // addressPO
            // 
            this.addressPO.Location = new System.Drawing.Point(89, 97);
            this.addressPO.Name = "addressPO";
            this.addressPO.Size = new System.Drawing.Size(121, 20);
            this.addressPO.TabIndex = 11;
            // 
            // titlePO
            // 
            this.titlePO.Location = new System.Drawing.Point(89, 71);
            this.titlePO.Name = "titlePO";
            this.titlePO.Size = new System.Drawing.Size(121, 20);
            this.titlePO.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Other:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Order Status:";
            // 
            // idPO
            // 
            this.idPO.Enabled = false;
            this.idPO.Location = new System.Drawing.Point(89, 19);
            this.idPO.Name = "idPO";
            this.idPO.Size = new System.Drawing.Size(121, 20);
            this.idPO.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.itemsPO);
            this.groupBox1.Controls.Add(this.statusPO);
            this.groupBox1.Controls.Add(this.datePO);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.detailsPO);
            this.groupBox1.Controls.Add(this.paymentPO);
            this.groupBox1.Controls.Add(this.quantityPO);
            this.groupBox1.Controls.Add(this.addressPO);
            this.groupBox1.Controls.Add(this.titlePO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idPO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Payment:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Date:";
            // 
            // POView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 418);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pending Order View";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemsPO;
        private System.Windows.Forms.ComboBox statusPO;
        private System.Windows.Forms.DateTimePicker datePO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox detailsPO;
        private System.Windows.Forms.TextBox paymentPO;
        private System.Windows.Forms.TextBox quantityPO;
        private System.Windows.Forms.TextBox addressPO;
        private System.Windows.Forms.TextBox titlePO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idPO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}