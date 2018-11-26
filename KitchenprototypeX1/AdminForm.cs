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
    public partial class AdminForm : Form
    {
        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void showTable()
        {
            DataSet tabeladmin= new DataSet();

            var table = new SqlDataAdapter();

            table.SelectCommand = new SqlCommand("select a.id_admin as 'Admin ID',a.username as 'Admin name',b.id_customer as 'Handled customer'from admins as a inner join customer b on a.id_admin = b.id_admin");
            table.SelectCommand.Connection = koneksi;
            table.SelectCommand.CommandType = CommandType.Text;
            table.Fill(tabeladmin);
            dataAdmin.DataSource = tabeladmin.Tables[0];
            dataAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAdmin.AutoResizeColumns();


        }

        public AdminForm()
        {
            InitializeComponent();
            showTable();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm maf = new MainForm();
            maf.ShowDialog();
            this.Close();
        }
    }
}
