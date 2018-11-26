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
    public partial class LoginForm : Form
    {
        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public LoginForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String loginsql = "select * from admins where " + "username='"+userbox.Text+"' AND pass='"+passbox.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(loginsql, koneksi);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                MainForm maf = new MainForm();
                maf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password incorrect.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm regf = new RegisterForm();
            regf.ShowDialog();
            this.Close();
        }
    }
}
