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
    public partial class MenuForm : Form
    {

        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);

        

        public void showTable()
        {
            DataSet tabelmenu = new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select * from menus");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelmenu);
            dataGridView1.DataSource = tabelmenu.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();
        }

        public MenuForm()
        {
            InitializeComponent();
            showTable();
            categoryMenu.SelectedIndex=0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm maf = new MainForm();
            maf.ShowDialog();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataSet tabelmenu = new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select * from menus where type_menu='Foods'");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelmenu);
            dataGridView1.DataSource = tabelmenu.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DataSet tabelmenu = new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select * from menus");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelmenu);
            dataGridView1.DataSource = tabelmenu.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataSet tabelmenu = new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select * from menus where type_menu='Beverages'");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabelmenu);
            dataGridView1.DataSource = tabelmenu.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kosong = string.Empty; // definites an empty string
            DataGridViewRow row = dataGridView1.Rows[0];
            if (idMenu.Text.Trim() == kosong | nameMenu.Text.Trim() == kosong | categoryMenu.Text.Trim() == kosong)
            {
                MessageBox.Show("Please complete the form.");
            }
            else

            {
                String addMenu = "insert into menus values('"+ idMenu.Text + "', '" + nameMenu.Text + "' , '" + categoryMenu.Text + "')";
                using (SqlCommand tambah = new SqlCommand("", koneksi))
                {

                    koneksi.Open();
                    tambah.CommandType = CommandType.Text;
                    tambah.CommandText = addMenu;
                    tambah.ExecuteNonQuery();
                    tambah.CommandText = "select * from menus";
                    tambah.ExecuteNonQuery();
                    koneksi.Close();
                    showTable();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kosong = string.Empty; // definites an empty string
            if (idMenu.Text.Trim() == kosong | nameMenu.Text.Trim() == kosong | categoryMenu.Text.Trim() == kosong)
            {
                MessageBox.Show("Please complete the form.");
            }
            else
            {

                String editMenu = "update menus set name_menu='" + nameMenu.Text + "' , type_menu='" + categoryMenu.Text + "' where id_menu='" + idMenu.Text + "';";
                using (SqlCommand edit = new SqlCommand("", koneksi))
                {
                    //tambah.Parameters.AddWithValue("@xxxx", SqlDbType.VarChar).Value = xxxx-_input.Text;
                    koneksi.Open();
                    edit.CommandType = CommandType.Text;
                    edit.CommandText = editMenu;
                    edit.ExecuteNonQuery();
                    edit.CommandText = "select * from menus;";
                    edit.ExecuteNonQuery();
                    koneksi.Close();
                    showTable();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            idMenu.Text = row.Cells[0].Value.ToString();
            nameMenu.Text = row.Cells[1].Value.ToString();
            categoryMenu.Text = row.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kosong = string.Empty; // definites an empty string
            DataGridViewRow row = dataGridView1.Rows[0];
            if (idMenu.Text.Trim() == kosong | nameMenu.Text.Trim() == kosong | categoryMenu.Text.Trim() == kosong)
            {
                MessageBox.Show("Please complete the form.");
            }
            else

            {
                String addMenu = "delete from menus where id_menu ='" + idMenu.Text + "'";
                using (SqlCommand tambah = new SqlCommand("", koneksi))
                {

                    koneksi.Open();
                    tambah.CommandType = CommandType.Text;
                    tambah.CommandText = addMenu;
                    tambah.ExecuteNonQuery();
                    tambah.CommandText = "select * from menus";
                    tambah.ExecuteNonQuery();
                    koneksi.Close();
                    showTable();
                }
            }
        }
    }
}
