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
    public partial class RegisterForm : Form
    {
        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lgf = new LoginForm();
            lgf.ShowDialog();
            this.Close();
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            String regadminsql = "insert into admins values (" + idBox.Text + ", '" + userbox.Text + "', '" + passbox.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(regadminsql, koneksi);
        }
    }
}
