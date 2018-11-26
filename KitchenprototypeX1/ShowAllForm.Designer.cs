namespace KitchenprototypeX1
{
    partial class ShowAllForm
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
            this.dataGridAllShow = new System.Windows.Forms.DataGridView();
            this.button_back = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAllShow
            // 
            this.dataGridAllShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllShow.Location = new System.Drawing.Point(30, 77);
            this.dataGridAllShow.Name = "dataGridAllShow";
            this.dataGridAllShow.RowTemplate.Height = 24;
            this.dataGridAllShow.Size = new System.Drawing.Size(740, 383);
            this.dataGridAllShow.TabIndex = 0;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(30, 517);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 32);
            this.button_back.TabIndex = 1;
            this.button_back.Text = "< Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(695, 517);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 32);
            this.button_refresh.TabIndex = 2;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(329, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of all orders";
            // 
            // ShowAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dataGridAllShow);
            this.Name = "ShowAllForm";
            this.Text = "Showing all orders in one table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAllShow;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label1;
    }
}