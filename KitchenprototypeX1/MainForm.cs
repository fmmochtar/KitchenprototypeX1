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
    public partial class MainForm : Form
    {

       

        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void showTable()
        {
            DataSet tabelcustomer = new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select id_customer as 'Customer ID', name_customer as 'Name', seat_customer as 'Seat number' from customer");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelcustomer);
            dataCustomerMenu.DataSource = tabelcustomer.Tables[0];
            dataCustomerMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCustomerMenu.AutoResizeColumns();
        }


        public MainForm()
        {
            InitializeComponent();
            showTable();

            button_order_group.Visible = false;
            button_search_order.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm odf = new OrderForm();
            odf.ShowDialog();
            this.Close();
        }

        private void button_show_all_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllForm saf = new ShowAllForm();
            saf.ShowDialog();
            this.Close();
        }

        private void button_order_group_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupShowForm gsf = new GroupShowForm();
            gsf.ShowDialog();
            this.Close();
        }

        private void button_search_order_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
            this.Close();
        }

        private void button_menumgt_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm mf = new MenuForm();
            mf.ShowDialog();
            this.Close();
        }

        private void button_adminmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adf = new AdminForm();
            adf.ShowDialog();
            this.Close();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lgf = new LoginForm();
            lgf.ShowDialog();
            this.Close();
        }
    }
}
