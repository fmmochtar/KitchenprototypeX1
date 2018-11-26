namespace KitchenprototypeX1
{
    partial class MainForm
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
            this.button_show_all = new System.Windows.Forms.Button();
            this.button_order_group = new System.Windows.Forms.Button();
            this.button_ordermgt = new System.Windows.Forms.Button();
            this.dataCustomerMenu = new System.Windows.Forms.DataGridView();
            this.button_menumgt = new System.Windows.Forms.Button();
            this.button_adminmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_search_order = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomerMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // button_show_all
            // 
            this.button_show_all.Location = new System.Drawing.Point(62, 439);
            this.button_show_all.Name = "button_show_all";
            this.button_show_all.Size = new System.Drawing.Size(107, 68);
            this.button_show_all.TabIndex = 0;
            this.button_show_all.Text = "Show ALL orders";
            this.button_show_all.UseVisualStyleBackColor = true;
            this.button_show_all.Click += new System.EventHandler(this.button_show_all_Click);
            // 
            // button_order_group
            // 
            this.button_order_group.Location = new System.Drawing.Point(223, 439);
            this.button_order_group.Name = "button_order_group";
            this.button_order_group.Size = new System.Drawing.Size(107, 68);
            this.button_order_group.TabIndex = 1;
            this.button_order_group.Text = "Show orders in groups";
            this.button_order_group.UseVisualStyleBackColor = true;
            this.button_order_group.Click += new System.EventHandler(this.button_order_group_Click);
            // 
            // button_ordermgt
            // 
            this.button_ordermgt.Location = new System.Drawing.Point(621, 95);
            this.button_ordermgt.Name = "button_ordermgt";
            this.button_ordermgt.Size = new System.Drawing.Size(117, 48);
            this.button_ordermgt.TabIndex = 2;
            this.button_ordermgt.Text = "Order Management";
            this.button_ordermgt.UseVisualStyleBackColor = true;
            this.button_ordermgt.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataCustomerMenu
            // 
            this.dataCustomerMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomerMenu.Location = new System.Drawing.Point(48, 69);
            this.dataCustomerMenu.Name = "dataCustomerMenu";
            this.dataCustomerMenu.RowTemplate.Height = 24;
            this.dataCustomerMenu.Size = new System.Drawing.Size(532, 344);
            this.dataCustomerMenu.TabIndex = 4;
            // 
            // button_menumgt
            // 
            this.button_menumgt.Location = new System.Drawing.Point(621, 185);
            this.button_menumgt.Name = "button_menumgt";
            this.button_menumgt.Size = new System.Drawing.Size(117, 48);
            this.button_menumgt.TabIndex = 5;
            this.button_menumgt.Text = "Menu Management";
            this.button_menumgt.UseVisualStyleBackColor = true;
            this.button_menumgt.Click += new System.EventHandler(this.button_menumgt_Click);
            // 
            // button_adminmenu
            // 
            this.button_adminmenu.Location = new System.Drawing.Point(621, 277);
            this.button_adminmenu.Name = "button_adminmenu";
            this.button_adminmenu.Size = new System.Drawing.Size(117, 48);
            this.button_adminmenu.TabIndex = 6;
            this.button_adminmenu.Text = "Admin Menu";
            this.button_adminmenu.UseVisualStyleBackColor = true;
            this.button_adminmenu.Click += new System.EventHandler(this.button_adminmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitchen Ordering System (alpha)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Under maintenance";
            // 
            // button_search_order
            // 
            this.button_search_order.Location = new System.Drawing.Point(390, 439);
            this.button_search_order.Name = "button_search_order";
            this.button_search_order.Size = new System.Drawing.Size(107, 68);
            this.button_search_order.TabIndex = 9;
            this.button_search_order.Text = "Search order";
            this.button_search_order.UseVisualStyleBackColor = true;
            this.button_search_order.Click += new System.EventHandler(this.button_search_order_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(621, 449);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(117, 48);
            this.button_logout.TabIndex = 10;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(346, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Main Menu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_search_order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_adminmenu);
            this.Controls.Add(this.button_menumgt);
            this.Controls.Add(this.dataCustomerMenu);
            this.Controls.Add(this.button_ordermgt);
            this.Controls.Add(this.button_order_group);
            this.Controls.Add(this.button_show_all);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomerMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_show_all;
        private System.Windows.Forms.Button button_order_group;
        private System.Windows.Forms.Button button_ordermgt;
        private System.Windows.Forms.DataGridView dataCustomerMenu;
        private System.Windows.Forms.Button button_menumgt;
        private System.Windows.Forms.Button button_adminmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_search_order;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label3;
    }
}