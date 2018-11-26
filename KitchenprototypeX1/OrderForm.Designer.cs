namespace KitchenprototypeX1
{
    partial class OrderForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_addCustomer = new System.Windows.Forms.Button();
            this.button_addOrder = new System.Windows.Forms.Button();
            this.namecustomerBox = new System.Windows.Forms.TextBox();
            this.dataCustomer = new System.Windows.Forms.DataGridView();
            this.dataOrders = new System.Windows.Forms.DataGridView();
            this.seatnumberBox = new System.Windows.Forms.TextBox();
            this.ordertypeCombo = new System.Windows.Forms.ComboBox();
            this.dataMenus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.orderidBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuBox = new System.Windows.Forms.ComboBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonBeverages = new System.Windows.Forms.RadioButton();
            this.radioButtonFoods = new System.Windows.Forms.RadioButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.adminIDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customeridBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenus)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1208, 659);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "< Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(30, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Order Management";
            // 
            // button_addCustomer
            // 
            this.button_addCustomer.Location = new System.Drawing.Point(1188, 128);
            this.button_addCustomer.Name = "button_addCustomer";
            this.button_addCustomer.Size = new System.Drawing.Size(130, 27);
            this.button_addCustomer.TabIndex = 18;
            this.button_addCustomer.Text = "Add Customer";
            this.button_addCustomer.UseVisualStyleBackColor = true;
            this.button_addCustomer.Click += new System.EventHandler(this.button_addCustomer_Click);
            // 
            // button_addOrder
            // 
            this.button_addOrder.Location = new System.Drawing.Point(1188, 325);
            this.button_addOrder.Name = "button_addOrder";
            this.button_addOrder.Size = new System.Drawing.Size(130, 27);
            this.button_addOrder.TabIndex = 19;
            this.button_addOrder.Text = "Add order";
            this.button_addOrder.UseVisualStyleBackColor = true;
            this.button_addOrder.Click += new System.EventHandler(this.button_addOrder_Click);
            // 
            // namecustomerBox
            // 
            this.namecustomerBox.Location = new System.Drawing.Point(627, 535);
            this.namecustomerBox.Name = "namecustomerBox";
            this.namecustomerBox.Size = new System.Drawing.Size(191, 22);
            this.namecustomerBox.TabIndex = 20;
            this.namecustomerBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataCustomer
            // 
            this.dataCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomer.Location = new System.Drawing.Point(36, 82);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.RowTemplate.Height = 24;
            this.dataCustomer.Size = new System.Drawing.Size(434, 267);
            this.dataCustomer.TabIndex = 21;
            this.dataCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCustomer_CellDoubleClick);
            // 
            // dataOrders
            // 
            this.dataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrders.Location = new System.Drawing.Point(503, 82);
            this.dataOrders.Name = "dataOrders";
            this.dataOrders.RowTemplate.Height = 24;
            this.dataOrders.Size = new System.Drawing.Size(629, 322);
            this.dataOrders.TabIndex = 22;
            this.dataOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOrders_CellDoubleClick);
            // 
            // seatnumberBox
            // 
            this.seatnumberBox.Location = new System.Drawing.Point(627, 584);
            this.seatnumberBox.Name = "seatnumberBox";
            this.seatnumberBox.Size = new System.Drawing.Size(191, 22);
            this.seatnumberBox.TabIndex = 23;
            this.seatnumberBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ordertypeCombo
            // 
            this.ordertypeCombo.FormattingEnabled = true;
            this.ordertypeCombo.Items.AddRange(new object[] {
            "Eat in",
            "Take out"});
            this.ordertypeCombo.Location = new System.Drawing.Point(981, 635);
            this.ordertypeCombo.Name = "ordertypeCombo";
            this.ordertypeCombo.Size = new System.Drawing.Size(151, 24);
            this.ordertypeCombo.TabIndex = 25;
            this.ordertypeCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataMenus
            // 
            this.dataMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMenus.Location = new System.Drawing.Point(36, 430);
            this.dataMenus.Name = "dataMenus";
            this.dataMenus.RowTemplate.Height = 24;
            this.dataMenus.Size = new System.Drawing.Size(434, 273);
            this.dataMenus.TabIndex = 26;
            this.dataMenus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMenus_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Seat number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(881, 642);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Order type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(981, 587);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(151, 22);
            this.quantityBox.TabIndex = 31;
            this.quantityBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // orderidBox
            // 
            this.orderidBox.Location = new System.Drawing.Point(981, 451);
            this.orderidBox.Name = "orderidBox";
            this.orderidBox.ReadOnly = true;
            this.orderidBox.Size = new System.Drawing.Size(96, 22);
            this.orderidBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1192, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Customer control";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(881, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Order ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(881, 537);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Menu ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(881, 587);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1209, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Order control";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1188, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Edit Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1188, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Delete Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1188, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Edit order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1188, 430);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 23);
            this.button5.TabIndex = 44;
            this.button5.Text = "Remove order";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuBox
            // 
            this.menuBox.FormattingEnabled = true;
            this.menuBox.Location = new System.Drawing.Point(981, 534);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(151, 24);
            this.menuBox.TabIndex = 45;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(1195, 538);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(44, 21);
            this.radioButtonAll.TabIndex = 48;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonBeverages
            // 
            this.radioButtonBeverages.AutoSize = true;
            this.radioButtonBeverages.Location = new System.Drawing.Point(1195, 606);
            this.radioButtonBeverages.Name = "radioButtonBeverages";
            this.radioButtonBeverages.Size = new System.Drawing.Size(97, 21);
            this.radioButtonBeverages.TabIndex = 47;
            this.radioButtonBeverages.TabStop = true;
            this.radioButtonBeverages.Text = "Beverages";
            this.radioButtonBeverages.UseVisualStyleBackColor = true;
            this.radioButtonBeverages.CheckedChanged += new System.EventHandler(this.radioButtonBeverages_CheckedChanged);
            // 
            // radioButtonFoods
            // 
            this.radioButtonFoods.AutoSize = true;
            this.radioButtonFoods.Location = new System.Drawing.Point(1195, 571);
            this.radioButtonFoods.Name = "radioButtonFoods";
            this.radioButtonFoods.Size = new System.Drawing.Size(68, 21);
            this.radioButtonFoods.TabIndex = 46;
            this.radioButtonFoods.TabStop = true;
            this.radioButtonFoods.Text = "Foods";
            this.radioButtonFoods.UseVisualStyleBackColor = true;
            this.radioButtonFoods.CheckedChanged += new System.EventHandler(this.radioButtonFoods_CheckedChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(134, 382);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(320, 22);
            this.textBox6.TabIndex = 49;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 385);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "Search";
            // 
            // adminIDBox
            // 
            this.adminIDBox.Location = new System.Drawing.Point(627, 639);
            this.adminIDBox.Name = "adminIDBox";
            this.adminIDBox.Size = new System.Drawing.Size(195, 22);
            this.adminIDBox.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 642);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Admin ID";
            // 
            // customeridBox
            // 
            this.customeridBox.Location = new System.Drawing.Point(627, 451);
            this.customeridBox.Name = "customeridBox";
            this.customeridBox.ReadOnly = true;
            this.customeridBox.Size = new System.Drawing.Size(145, 22);
            this.customeridBox.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(500, 454);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 54;
            this.label13.Text = "Customer ID";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.button6.Location = new System.Drawing.Point(1088, 450);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 23);
            this.button6.TabIndex = 55;
            this.button6.Text = "CLR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1192, 506);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 56;
            this.label14.Text = "Show:";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.button7.Location = new System.Drawing.Point(778, 450);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 23);
            this.button7.TabIndex = 57;
            this.button7.Text = "CLR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 764);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.customeridBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adminIDBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.radioButtonBeverages);
            this.Controls.Add(this.radioButtonFoods);
            this.Controls.Add(this.menuBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderidBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataMenus);
            this.Controls.Add(this.ordertypeCombo);
            this.Controls.Add(this.seatnumberBox);
            this.Controls.Add(this.dataOrders);
            this.Controls.Add(this.dataCustomer);
            this.Controls.Add(this.namecustomerBox);
            this.Controls.Add(this.button_addOrder);
            this.Controls.Add(this.button_addCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_addCustomer;
        private System.Windows.Forms.Button button_addOrder;
        private System.Windows.Forms.TextBox namecustomerBox;
        private System.Windows.Forms.DataGridView dataCustomer;
        private System.Windows.Forms.DataGridView dataOrders;
        private System.Windows.Forms.TextBox seatnumberBox;
        private System.Windows.Forms.ComboBox ordertypeCombo;
        private System.Windows.Forms.DataGridView dataMenus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.TextBox orderidBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox menuBox;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonBeverages;
        private System.Windows.Forms.RadioButton radioButtonFoods;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox adminIDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customeridBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button7;
    }
}