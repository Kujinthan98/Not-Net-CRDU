using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnRead_Click_1(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();

        }

        private void btn_createStudent(object sender, EventArgs e)
        {
            Form6 f = new Form6(this);
            f.ShowDialog();
        }
    }
}
