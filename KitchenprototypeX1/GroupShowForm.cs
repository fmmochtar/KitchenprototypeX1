using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenprototypeX1
{
    public partial class GroupShowForm : Form
    {
        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void showTableGroup()
        {
            DataSet table1= new DataSet();
            DataSet table2 = new DataSet();
            DataSet table3 = new DataSet();
            DataSet table4 = new DataSet();


            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select a.id_orders as 'Order ID', b.name_menu as 'Menu', a.quantity_order as 'Quantity', c.name_customer as 'Customer Name', c.seat_customer as 'Seat number' from orders as a inner join menus b on a.id_menu = b.id_menu inner join customer c on c.id_customer = a.id_customer order by a.id_orders;");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(table1);
            dataOrders1.DataSource = table1.Tables[0];
            dataOrders1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOrders1.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select a.id_orders as 'Order ID', b.name_menu as 'Menu', a.quantity_order as 'Quantity', c.name_customer as 'Customer Name', c.seat_customer as 'Seat number' from orders as a inner join menus b on a.id_menu = b.id_menu inner join customer c on c.id_customer = a.id_customer order by a.id_orders; ");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(table2);
            dataOrders2.DataSource = table2.Tables[0];
            dataOrders2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOrders2.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select a.id_orders as 'Order ID', b.name_menu as 'Menu', a.quantity_order as 'Quantity', c.name_customer as 'Customer Name', c.seat_customer as 'Seat number' from orders as a inner join menus b on a.id_menu = b.id_menu inner join customer c on c.id_customer = a.id_customer order by a.id_orders; ");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(table3);
            dataOrders3.DataSource = table3.Tables[0];
            dataOrders3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOrders3.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select a.id_orders as 'Order ID', b.name_menu as 'Menu', a.quantity_order as 'Quantity', c.name_customer as 'Customer Name', c.seat_customer as 'Seat number' from orders as a inner join menus b on a.id_menu = b.id_menu inner join customer c on c.id_customer = a.id_customer order by a.id_orders; ");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(table4);
            dataOrders4.DataSource = table4.Tables[0];
            dataOrders4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOrders4.AutoResizeColumns();

        }

        public void showTableInfo()
        {
            DataSet table1 = new DataSet();
            DataSet table2 = new DataSet();
            DataSet table3 = new DataSet();
            DataSet table4 = new DataSet();


            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select * from(select id_customer as 'Customer ID', name_customer as 'Name', row_number() over(order by id_customer)as 'Queue'  from customer)as temp where Queue = 1");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(table1);
            dataQueue1.DataSource = table1.Tables[0];
            dataQueue1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataQueue1.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from(select id_customer as 'Customer ID', name_customer as 'Name', row_number() over(order by id_customer)as 'Queue'  from customer)as temp where Queue = 2");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(table2);
            dataQueue2.DataSource = table2.Tables[0];
            dataQueue2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataQueue2.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from(select id_customer as 'Customer ID', name_customer as 'Name', row_number() over(order by id_customer)as 'Queue'  from customer)as temp where Queue = 3");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(table3);
            dataQueue3.DataSource = table3.Tables[0];
            dataQueue3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataQueue3.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from(select id_customer as 'Customer ID', name_customer as 'Name', row_number() over(order by id_customer)as 'Queue'  from customer)as temp where Queue = 4");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(table4);
            dataQueue4.DataSource = table4.Tables[0];
            dataQueue4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataQueue4.AutoResizeColumns();

        }

        public GroupShowForm()
        {
            InitializeComponent();
            showTableGroup();
            showTableInfo();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm maf = new MainForm();
            maf.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
