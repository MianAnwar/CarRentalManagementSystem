using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Controller Cntlr = Controller.Instance;

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (Cntlr.CheckExistenceInDatabase(username, password) == true)
            {
                mainForm mf = new mainForm();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Enter Correct username or passord.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            registerForm rf = new registerForm();
            rf.Show();
        }
    }
}
