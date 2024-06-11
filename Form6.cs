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
    public partial class Form6 : Form
    {
        public String firstName;
        public String lastName;
        public String gender;
        public String Grade;
        public String Address;
        Form5 form5 = null;
        public Form6(Form5 f)
        {
            InitializeComponent();
            this.form5 = f;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            this.gender = null;
            if (male.Checked)
            {
                gender = "Male";
            }
            if (female.Checked)
            {
                gender = "Female";
            }
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =CsharpDb; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "INSERT INTO students (first_name, last_name, grade,address, gender) VALUES('" + txtFirstName.Text + "', '" + txtLastName.Text + "','" + grade.Text + "','" + address.Text + "','" + gender + "');";
           
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show(" data stored successfully !!" , "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            form5.txtFirstName.Text = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            form5.txtLastName.Text = txtLastName.Text;
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            //form5.male.Checked = male.Checked;
            form5.male.Checked = true;

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            //form5.female.Checked = female.Checked;
            form5.female.Checked = true;
        }

        private void grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            form5.grade.SelectedIndex = grade.SelectedIndex;
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            form5.address.Text = address.Text;  
        }
    }
}
