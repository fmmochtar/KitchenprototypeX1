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
    public partial class OrderForm : Form
    {
        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void showTable()
        {
            DataSet tabelcustomer = new DataSet();
            DataSet tabelorder = new DataSet();
            DataSet tabelmenu = new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select * from customer");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelcustomer);
            dataCustomer.DataSource = tabelcustomer.Tables[0];
            dataCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCustomer.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from orders");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelorder);
            dataOrders.DataSource = tabelorder.Tables[0];
            dataOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOrders.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from menus");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelmenu);
            dataMenus.DataSource = tabelmenu.Tables[0];
            dataMenus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMenus.AutoResizeColumns();

        }

        public void showTableFoods()
        {
            DataSet tabelcustomer = new DataSet();
            DataSet tabelorder = new DataSet();
            DataSet tabelmenu = new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select * from customer");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelcustomer);
            dataCustomer.DataSource = tabelcustomer.Tables[0];
            dataCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCustomer.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from orders");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelorder);
            dataOrders.DataSource = tabelorder.Tables[0];
            dataOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOrders.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from menus where type_menu='Foods'");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelmenu);
            dataMenus.DataSource = tabelmenu.Tables[0];
            dataMenus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMenus.AutoResizeColumns();

        }

        public void showTableBeverages()
        {
            DataSet tabelcustomer = new DataSet();
            DataSet tabelorder = new DataSet();
            DataSet tabelmenu = new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select * from customer");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelcustomer);
            dataCustomer.DataSource = tabelcustomer.Tables[0];
            dataCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCustomer.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from orders");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelorder);
            dataOrders.DataSource = tabelorder.Tables[0];
            dataOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOrders.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from menus where type_menu='Beverages'");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelmenu);
            dataMenus.DataSource = tabelmenu.Tables[0];
            dataMenus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMenus.AutoResizeColumns();

        }

        public void showTableSearch()
        {
            DataSet tabelcustomer = new DataSet();
            DataSet tabelorder = new DataSet();
            DataSet tabelmenu = new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select * from customer");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelcustomer);
            dataCustomer.DataSource = tabelcustomer.Tables[0];
            dataCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCustomer.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from orders");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelorder);
            dataOrders.DataSource = tabelorder.Tables[0];
            dataOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOrders.AutoResizeColumns();

            table.SelectCommand = new SqlCommand("select * from menus where name_menu like '%"+ textBox6.Text +"%';");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelmenu);
            dataMenus.DataSource = tabelmenu.Tables[0];
            dataMenus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMenus.AutoResizeColumns();

        }

        public OrderForm()
        {
            InitializeComponent();
            showTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm maf = new MainForm();
            maf.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_addCustomer_Click(object sender, EventArgs e)
        {
            string kosong = string.Empty; // definites an empty string
            DataGridViewRow row = dataCustomer.Rows[0];
            if (namecustomerBox.Text.Trim() == kosong | seatnumberBox.Text.Trim() == kosong | adminIDBox.Text.Trim() == kosong)
            {
                MessageBox.Show("Please complete the form.");
            }
            else

            {
                String addMenu = "insert into customer values (next value for incseq.sequence_1, '" + namecustomerBox.Text + "', '" + seatnumberBox.Text + "', " + adminIDBox.Text + ");";
                using (SqlCommand tambah = new SqlCommand("", koneksi))
                {

                    koneksi.Open();
                    tambah.CommandType = CommandType.Text;
                    tambah.CommandText = addMenu;
                    tambah.ExecuteNonQuery();
                    tambah.CommandText = "select * from customer";
                    tambah.ExecuteNonQuery();
                    koneksi.Close();
                    showTable();
                }
            }
        }

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            // use this  string for order id = next value for orderid_seq

            string kosong = string.Empty; // definites an empty string
            DataGridViewRow row = dataCustomer.Rows[0];
            if (ordertypeCombo.Text.Trim() == kosong | menuBox.Text.Trim() == kosong | customeridBox.Text.Trim() == kosong)
            {
                MessageBox.Show("Please complete the form.");
            }
            else

            {
                String addOrders = "insert into orders values (next value for orderid_seq, '" + customeridBox.Text + "', '" + menuBox.Text + "', '" + ordertypeCombo.Text + "', '" + quantityBox.Text + "');";
                using (SqlCommand tambah = new SqlCommand("", koneksi))
                {

                    koneksi.Open();
                    tambah.CommandType = CommandType.Text;
                    tambah.CommandText = addOrders;
                    tambah.ExecuteNonQuery();
                    tambah.CommandText = "select * from orders";
                    tambah.ExecuteNonQuery();
                    koneksi.Close();
                    showTable();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kosong = string.Empty; // definites an empty string
            if (namecustomerBox.Text.Trim() == kosong | seatnumberBox.Text.Trim() == kosong | adminIDBox.Text.Trim() == kosong)
            {
                MessageBox.Show("Please complete the form.");
            }
            else
            {

                String editCustomer = "update customer set name_customer='" + namecustomerBox.Text + "' , seat_customer='" + seatnumberBox.Text + "' , id_admin='" + adminIDBox.Text + "' where id_customer=" + customeridBox.Text + ";" ;
                using (SqlCommand edit = new SqlCommand("", koneksi))
                {
                    //tambah.Parameters.AddWithValue("@xxxx", SqlDbType.VarChar).Value = xxxx-_input.Text;
                    koneksi.Open();
                    edit.CommandType = CommandType.Text;
                    edit.CommandText = editCustomer;
                    edit.ExecuteNonQuery();
                    edit.CommandText = "select * from customer;";
                    edit.ExecuteNonQuery();
                    koneksi.Close();
                    showTable();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kosong = string.Empty; // definites an empty string
            DataGridViewRow row = dataCustomer.Rows[0];
            if (namecustomerBox.Text.Trim() == kosong | seatnumberBox.Text.Trim() == kosong | adminIDBox.Text.Trim() == kosong)
            {
                MessageBox.Show("Please complete the form.");
            }
            else

            {
                String addMenu = "delete from customer where id_customer=" + customeridBox.Text + ";";
                using (SqlCommand tambah = new SqlCommand("", koneksi))
                {

                    koneksi.Open();
                    tambah.CommandType = CommandType.Text;
                    tambah.CommandText = addMenu;
                    tambah.ExecuteNonQuery();
                    tambah.CommandText = "select * from customer";
                    tambah.ExecuteNonQuery();
                    koneksi.Close();
                    showTable();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // use this  string for order id = next value for orderid_seq

            string kosong = string.Empty; // definites an empty string
            DataGridViewRow row = dataCustomer.Rows[0];
            if (ordertypeCombo.Text.Trim() == kosong | menuBox.Text.Trim() == kosong | customeridBox.Text.Trim() == kosong)
            {
                MessageBox.Show("Please complete the form.");
            }
            else

            {
                String deleteOrders = "delete from orders where id_orders =" + orderidBox.Text + ";";
                using (SqlCommand tambah = new SqlCommand("", koneksi))
                {

                    koneksi.Open();
                    tambah.CommandType = CommandType.Text;
                    tambah.CommandText = deleteOrders;
                    tambah.ExecuteNonQuery();
                    tambah.CommandText = "select * from orders";
                    tambah.ExecuteNonQuery();
                    koneksi.Close();
                    showTable();
                }
            }
        }

        private void dataCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataCustomer.Rows[e.RowIndex];
            customeridBox.Text = row.Cells[0].Value.ToString();
            namecustomerBox.Text = row.Cells[1].Value.ToString();
            seatnumberBox.Text = row.Cells[2].Value.ToString();
            adminIDBox.Text = row.Cells[3].Value.ToString();
        }

        private void dataOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataOrders.Rows[e.RowIndex];
            orderidBox.Text = row.Cells[0].Value.ToString();
            menuBox.Text = row.Cells[2].Value.ToString();
            ordertypeCombo.Text = row.Cells[3].Value.ToString();
            quantityBox.Text = row.Cells[4].Value.ToString();
        }

        private void dataMenus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataMenus.Rows[e.RowIndex];
            menuBox.Text = row.Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kosong = string.Empty; // definites an empty string
            if (ordertypeCombo.Text.Trim() == kosong | menuBox.Text.Trim() == kosong | customeridBox.Text.Trim() == kosong)
            {
                MessageBox.Show("Please complete the form.");
            }
            else
            {
                String editCustomer = "update orders set id_customer='" + customeridBox.Text + "' , id_menu='" + menuBox.Text + "' , type_order='" + ordertypeCombo.Text + "' where id_orders=" + orderidBox.Text + ";";
                using (SqlCommand edit = new SqlCommand("", koneksi))
                {
                    //tambah.Parameters.AddWithValue("@xxxx", SqlDbType.VarChar).Value = xxxx-_input.Text;
                    koneksi.Open();
                    edit.CommandType = CommandType.Text;
                    edit.CommandText = editCustomer;
                    edit.ExecuteNonQuery();
                    edit.CommandText = "select * from customer;";
                    edit.ExecuteNonQuery();
                    koneksi.Close();
                    showTable();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customeridBox.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            orderidBox.Text = null;
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            showTable();
        }

        private void radioButtonFoods_CheckedChanged(object sender, EventArgs e)
        {
            showTableFoods();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonBeverages_CheckedChanged(object sender, EventArgs e)
        {
            showTableBeverages();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox6.Text == null)
            {
                showTable();
            }
            else
            {
                showTableSearch();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == null)
            {
                showTable();
            }
            else
            {
                showTableSearch();
            }
        }
    }
}
