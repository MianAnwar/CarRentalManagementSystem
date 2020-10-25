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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        Controller Cntlr = Controller.Instance;

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox0.Text == "")
            {
                MessageBox.Show("Must Fill the CNIC field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Must Fill both the Username and password field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ////////////////
            if (Cntlr.CheckExistenceInDatabase("CNIC", textBox0.Text ,"Login") == true)
            {
                MessageBox.Show("The user with '" + textBox0.Text + " is already registed! Can't Register Again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                if (Cntlr.CheckExistenceInDatabase("username", textBox6.Text, "Login") == true)
                {
                    MessageBox.Show("The user with '" + textBox6.Text + "' username is already registed! Select another username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // make further to add data in database
                MessageBox.Show("Welcome, New User!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                User u = new User();
                u.Setcnic(textBox0.Text);
                u.Setname(textBox1.Text);
                u.Setgender(comboBox1.Text);
                u.Setage(textBox2.Text);
                u.Setemail(textBox3.Text);
                u.Setphno(textBox4.Text);
                u.Setaddress(textBox5.Text);
                u.Setusername(textBox6.Text);
                u.Setpassword(textBox7.Text);

                if (Cntlr.SaveToDatabase(u) == false)   // agr save nhi hota tu ye msg show kr
                {
                    MessageBox.Show("While Registering new member error due to some problem,\nwhile saving data to db Please contact MMA!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                return;
            }
        }

        private void textBox0_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch!= 8 && ch!=46)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
