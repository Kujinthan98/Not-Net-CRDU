using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); 
        }
        #region user define function
        private static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        private static int subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        private static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        private static int divition(int num1, int num2)
        {
            return num1 / num2;
        }
        #endregion

        #region Operator function
        private static int calculator(int num1, int num2, String Operator)
        {
            int result = 0;
            /*
            if (Operator == "+")
            {
           result = sum(num1, num2);
            }else if (Operator == "-")
            {
            result = subtract(num1, num2);
            }else if(Operator == "*")
            {
                result = multiply(num1, num2);
            }else if( Operator == "/")
            {
                result = divition(num1, num2); 
            }
            */
            switch (Operator)
            {
                case "+":
                    result = sum(num1, num2);
                    break;
                case "-":
                    result = subtract(num1, num2);
                    break;
                case "*":
                    result = multiply(num1, num2);
                    break;
                case "/":
                    result = divition(num1, num2);
                    break;
            }

            return result;
        }
        #endregion

        #region Number validation

        private Boolean NumberValidation(out Int32 num1, out Int32 num2)
        {
            if (String.IsNullOrEmpty(txtNumOne.Text))
            {
                MessageBox.Show("Enter the number one", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumOne.Focus();
                 num1 = 0;
                 num2 = 0;
                return false;
            }
            if (String.IsNullOrEmpty(txtNumTwo.Text))
            {
                MessageBox.Show("Enter the number Two", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumTwo.Focus();
                 num1 = 0;
                 num2 = 0;
                return false;
            }



            Boolean isNumber1 = Int32.TryParse(txtNumOne.Text, out num1);
            if (!isNumber1)
            {
                MessageBox.Show("Enter correct number one", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumOne.Focus();
                 num1 = 0;
                 num2 = 0;
                return false;
            }
            Boolean isNumber2 = Int32.TryParse(txtNumTwo.Text, out num2);
            if (!isNumber2)
            {
                MessageBox.Show("Enter correc number two", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumOne.Focus();
                 num2 = 0;
                return false;
            }
            return true;
        }

        #endregion

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            { 
                Int32 num1 = 0;
                Int32 num2 = 0;
                if(NumberValidation(out num1 , out num2 ))
                {
                    int result = calculator(num1, num2, "+");
                    txtResult.Text = result.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 num1 = 0;
                Int32 num2 = 0;
                if (NumberValidation(out num1, out num2))
                {
                    int result = calculator(num1, num2, "-");
                    txtResult.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnMutyply_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 num1 = 0;
                Int32 num2 = 0;
                if (NumberValidation(out num1, out num2))
                {
                    int result = calculator(num1, num2, "*");
                    txtResult.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnDivition_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 num1 = 0;
                Int32 num2 = 0;
                if (NumberValidation(out num1, out num2))
                {
                    int result = calculator(num1, num2, "/");
                    txtResult.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

    }
}
