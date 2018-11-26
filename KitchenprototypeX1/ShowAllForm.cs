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
using System.Timers;

namespace KitchenprototypeX1
{
    public partial class ShowAllForm : Form
    {
        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);

        const double interval = 15 * 1000; // milliseconds to one hour

        public void executeTimerRefresh()
        {
            System.Timers.Timer checkForTime = new System.Timers.Timer(interval);
            checkForTime.Elapsed += new ElapsedEventHandler(checkForTime_Elapsed);
            checkForTime.Enabled = true;
        }



        public void showTable()
        {
            DataSet tabelcustomer = new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select a.id_orders as 'Order ID', b.name_menu as 'Menu', a.quantity_order as 'Quantity', c.name_customer as 'Customer Name', c.seat_customer as 'Seat number' from orders as a inner join menus b on a.id_menu = b.id_menu inner join customer c on c.id_customer = a.id_customer order by a.id_orders; ");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelcustomer);
            dataGridAllShow.DataSource = tabelcustomer.Tables[0];
            dataGridAllShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAllShow.AutoResizeColumns();
        }

        public ShowAllForm()
        {
            InitializeComponent();
            showTable();
        }

        void checkForTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (timeIsReady())
            {
                showTable();
            }
        }

        private bool timeIsReady()
        {
            throw new NotImplementedException();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm maf = new MainForm();
            maf.ShowDialog();
            this.Close();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            showTable();
        }
    }
}
