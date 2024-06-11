using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        String id;
        public Form4()
        {
            InitializeComponent(); 
        }
        /*
        private void dbConnection(String sql)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
             sql = sql;
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =CsharpDb; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stdtable.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        */
        private void Form4_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = "Select * from students";
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =CsharpDb; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stdtable.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            //this.dbConnection("Select * from students");
           // sql = "Select * from students";
               
        }

        private void btnClouse_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //String id = stdtable.CurrentRow.Cells["id"].Value.ToString();
            //String id = stdtable.SelectedRows[0].Cells["id"].Value.ToString();
           // MessageBox.Show(id);
                
            
            if (stdtable.SelectedRows.Count > 0)
            {
                int selectedIndex = stdtable.SelectedRows[0].Index;
                //int id = Convert.ToInt32(stdtable[0, selectedIndex].Value);
                //String id = stdtable.SelectedRows[0].Cells["id"].Value.ToString();
                string sql = "DELETE FROM students WHERE id ='" + this.id + "'";
                string connectionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =CsharpDb; Trusted_Connection = True";
                using (SqlConnection cnn = new SqlConnection(connectionString))

                {
                    try
                    {
                       
                        cnn.Open();
                        SqlCommand command = new SqlCommand(sql, cnn);
                       // command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        DialogResult dr = MessageBox.Show("Do you want delete!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            return;
                        }
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete row! ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
            //this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (stdtable.SelectedRows.Count > 0)
            {

                
                String first_name = stdtable.SelectedRows[0].Cells["first_name"].Value.ToString();
                String last_name = stdtable.SelectedRows[0].Cells["last_name"].Value.ToString();
                String address = stdtable.SelectedRows[0].Cells["address"].Value.ToString();
                String grade = stdtable.SelectedRows[0].Cells["grade"].Value.ToString();
                String gender= stdtable.SelectedRows[0].Cells["gender"].Value.ToString();

                Form8 form = new Form8(this.id, first_name, last_name, gender, grade, address);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
            //this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
             String firstName;
             String lastName;
             String gender;
             String Grade;
             String Address;

            String connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            String sql = null;
            gender = null;
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
                MessageBox.Show(" data stored successfully !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        
        private void stdtable_SelectionChanged(object sender, EventArgs e)
        {
            if (stdtable.SelectedRows.Count > 0)
            {
                btnSubmit.Text = "Edit";
                btnSubmit.BackColor = Color.Blue;
                this. id = stdtable.SelectedRows[0].Cells["id"].Value.ToString();
                String first_name = stdtable.SelectedRows[0].Cells["first_name"].Value.ToString();
                String last_name = stdtable.SelectedRows[0].Cells["last_name"].Value.ToString();
                String addres = stdtable.SelectedRows[0].Cells["address"].Value.ToString();
                String gradee = stdtable.SelectedRows[0].Cells["grade"].Value.ToString();
                String genderr = stdtable.SelectedRows[0].Cells["gender"].Value.ToString();

                txtFirstName.Text = first_name;
                txtLastName.Text = last_name;
                address.Text = addres;
                grade.Text = gradee;
                string gender = genderr;
                if (gender == "Male")
                {
                    male.Checked = true;
                }
                else if (gender == "Female")
                {
                    female.Checked = true;
                }

            }
            //else
            //    {
            //        MessageBox.Show("Please select a row to update.");
            //    }

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Save")
            {
                string connetionString = null;
                SqlConnection connection;
                SqlCommand command;
                string sql = null;
                String gender = null;
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
                    MessageBox.Show(" data stored successfully !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                string connetionString = null;
                SqlConnection connection;
                SqlCommand command;
                string sql = null;
                connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =CsharpDb; Trusted_Connection = True";
                connection = new SqlConnection(connetionString);
                String gender = null;
                if (male.Checked)
                {
                    gender = "Male";
                }
                if (female.Checked)
                {
                    gender = "Female";
                }
                sql = "UPDATE [students] SET [first_name] = '" + txtFirstName.Text + "', [last_name] = '" + txtLastName.Text + "',[gender]='" + gender + "', [grade]='" + grade.Text + "',[address]='" + address.Text + "' WHERE [id]='" + this.id + "';";
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.id = null;
            txtFirstName.Text = null;
            txtLastName.Text = null;
            address.Text = null;
            grade.SelectedIndex = -1;
            male.Checked = true;
            btnSubmit.Text = "Save";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = "Select * from students";
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =CsharpDb; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stdtable.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
 