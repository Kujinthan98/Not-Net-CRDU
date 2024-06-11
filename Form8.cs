using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        String id = null;
        String firstName=null;
        String lastName=null;
        String gender = null;
        String stdGrade = null;
        String stdAddress = null;

        public Form8(String id, String firstName, String lastName, String gender, String grade, String address)
        {
            InitializeComponent();
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.stdGrade = grade;
            this.stdAddress = address;
            //MessageBox.Show(gender);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            if (this.gender == "Male")
            {
                male.Checked = true;
            }
            else if (this.gender == "Female")
            {
                female.Checked = true;
            }
            grade.Text = stdGrade;
            address.Text = stdAddress;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            if (male.Checked)
            {
                gender = "Male";
            }
            else if (female.Checked)
            {
                gender = "Female";
            }

            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =CsharpDb; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "UPDATE [students] SET [first_name] = '"+txtFirstName.Text+"', [last_name] = '" + txtLastName.Text + "',[gender]='"+ gender + "', [grade]='" + grade.Text+"',[address]='"+address.Text+"' WHERE [id]='"+this.id+"';";
           // sql = "UPDATE [students] SET [first_name] = @firstName, [last_name] = @lastName, [gender] = @gender, [grade] = @grade, [address] = @address WHERE [id] = @id";
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show(" data stored successfully !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }
    }
}


