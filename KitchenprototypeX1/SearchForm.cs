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
    public partial class SearchForm : Form
    {
        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void showTableDoSearch()
        {
            DataSet tabelsearch = new DataSet();


            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select a.id_orders as 'Order ID', b.name_menu as 'Menu', a.quantity_order as 'Quantity', c.name_customer as 'Customer Name', c.seat_customer as 'Seat number' from orders as a inner join menus b on a.id_menu = b.id_menu inner join customer c on c.id_customer = a.id_customer order by a.id_orders where " + categoryBox.Text + " like '%" + searchBox.Text + "%'");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelsearch);
            dataSearch.DataSource = tabelsearch.Tables[0];
            dataSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSearch.AutoResizeColumns();

        }

        public void showTableSearch()
        {
            DataSet tabelsearch = new DataSet();


            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select a.id_orders as 'Order ID', b.name_menu as 'Menu', a.quantity_order as 'Quantity', c.name_customer as 'Customer Name', c.seat_customer as 'Seat number' from orders as a inner join menus b on a.id_menu = b.id_menu inner join customer c on c.id_customer = a.id_customer order by a.id_orders;");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelsearch);
            dataSearch.DataSource = tabelsearch.Tables[0];
            dataSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSearch.AutoResizeColumns();

        }

        public SearchForm()
        {
            InitializeComponent();
            showTableSearch();
            categoryBox.SelectedIndex = 0;

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm maf = new MainForm();
            maf.ShowDialog();
            this.Close();
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            showTableDoSearch();
        }
    }
}
