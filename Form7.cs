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

namespace WindowsFormsApp1
{
    public partial class DbConnection : Form
    {
        public DbConnection()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            //connetionString = "Data Source=ServerName;Initial Catalog=CsharpDb;User ID=;Password=";
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =CsharpDb; Trusted_Connection = True";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
